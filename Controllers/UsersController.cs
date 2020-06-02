using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Repository;
using Mapster;
using ThaniyasFarmerAppAPI.Services.Interfaces;
using ThaniyasFarmerAppAPI.Services;
using ThaniyasFarmerAppAPI.Filters;
using Microsoft.Extensions.Configuration;

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(ActionFilter))]
    public class UsersController : ControllerBase
    {
        private IAccountsServices _accountsServices;
        private IEmailService _emailServices;
        private readonly BaseDbContext _context;
        private IConfiguration _configuration;
        public UsersController(IConfiguration _configuration,BaseDbContext _context, IAccountsServices _accountsServices, IEmailService _emailServices)
        {
            this._context = _context;
            this._accountsServices = _accountsServices;
            this._emailServices = _emailServices;
            this._configuration = _configuration;
        }

        [HttpGet("get-users")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var result = new List<User>();
            try
            {
                result = await _context.Users.Where(x => !x.Deleted).ToListAsync();
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        [HttpGet("get-user/{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        //[HttpPut("update-user/{id}")]
        //public async Task<ActionResult<User>> UpdateUser(int id, UserViewModel input)
        //{
        //    if (id != input.ID)
        //    {
        //        return BadRequest();
        //    }
        //    var existData= _context.Users.Where(x=>x.ID==id).Select(x=>x.Password).FirstOrDefault();
        //    if (existData == null)
        //    {
        //        return BadRequest();
        //    }
        //    var user = input.Adapt<User>();
        //    try
        //    {
        //        user.Password = existData;
        //        _context.Entry(user).State = EntityState.Modified;
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return user;
        //}

        [HttpPost("change-password")]
        public async Task<ActionResult<ChangePasswordResult>> ChangePassword(ChangePasswordInput input)
        {
            var returnResult = new ChangePasswordResult { status = new Status(), userDetail = new UserViewModel() };
            var existData = _context.Users.Where(x => x.ID == input.id).FirstOrDefault();
            if (existData == null)
            {
                returnResult.status = new Status { StatusCode = 301, StatusValue = false, StatusDisplay = "No user found" };
                return returnResult;
            }
            if (existData.Password != Helpers.StringCipher.Encrypt(input.oldPassword))
            {
                returnResult.status = new Status { StatusCode = 301, StatusValue = false, StatusDisplay = "The old password doesn't match." };
                return returnResult;
            }
            try
            {
                existData.Password = Helpers.StringCipher.Encrypt(input.newPassword);
                _context.Entry(existData).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                returnResult.status = new Status { StatusCode = 200, StatusValue = true, StatusDisplay = "Successfully" };
            }
            catch (Exception ex)
            {
                returnResult.status = new Status { StatusCode = 500, StatusValue = false, StatusDisplay = ex.Message };
            }

            return returnResult;
        }

        [HttpPost("add-user")]
        public async Task<ActionResult<User>> AddUser(UserViewModel input)
        {
            var user = input.Adapt<User>();
            string userPassword = user.Password;

            if (string.IsNullOrEmpty(user.Password))
            {
                //GENERATES PASSWORD
                userPassword = _accountsServices.CreatePassword(8);
            }

            //ENCRYPTS PASSWORD
            user.Password = Helpers.StringCipher.Encrypt(userPassword);
            user.IsFirstTimeLogin = true;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            try
            {
                //SEND WELCOME EMAIL WITH PASSWORD
                string to = user.Email, userID, password, SMTPPort, host;

                _emailServices.AppSettings(out userID, out password, out SMTPPort, out host);

                var url = this._configuration["webSiteUrl"];
                string subject = "Thaniyas Farmer App Account Created";
                string body = @"Welcome to Thaniyas Farmer App!<br /><br />

                                        You have been added to the Thaniyas Farmer App system found here: " + url + @"<br /><br />

                                        Please login with the below username and temporary password.<br /><br />

                                        Username: " + user.UserName + @"<br />
                                        Password: " + userPassword + @"<br />";


                _emailServices.SendEmail(subject, body, to, userID, password, SMTPPort, host);
            }
            catch (Exception ex)
            {

            }

            return CreatedAtAction("GetUser", new { id = user.ID }, user);
        }

        //[HttpDelete("delete-user/{id}")]
        //public async Task<ActionResult<User>> DeleteUser(int id)
        //{
        //    var user = await _context.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    try
        //    {
        //        user.Deleted = true;
        //        _context.Entry(user).State = EntityState.Modified;
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return user;
        //}

        //private bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.ID == id);
        //}
    }
}
