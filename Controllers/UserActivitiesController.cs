using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Repository;

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserActivitiesController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public UserActivitiesController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpGet("get-user-activities")]
        public async Task<ActionResult<IEnumerable<UserActivity>>> GetUserActivity()
        {
            var list = new List<UserActivity>();
            try
            {
                list = await _context.UserActivity.ToListAsync();
            }
            catch(Exception ex)
            {

            }
            return list.OrderByDescending(x=>x.TimeStamp).ToList();
        }

        [HttpGet("get-user-activity/{id}")]
        public async Task<ActionResult<UserActivity>> GetUserActivity(int id)
        {
            var userActivity = await _context.UserActivity.FindAsync(id);

            if (userActivity == null)
            {
                return NotFound();
            }

            return userActivity;
        }

        [HttpGet("get-user-activityby-userid/{id}")]
        public async Task<ActionResult<IEnumerable<UserActivity>>> GetUserActivityByUserId(int id)
        {
            var users = await _context.Users.ToListAsync();
            var user = users.Where(x => x.ID == id).FirstOrDefault();
            var userActivity = new List<UserActivity>();
            userActivity = await _context.UserActivity.Where(x => x.UserID == id).ToListAsync();
            if (userActivity == null)
            {
                return NotFound();
            }
            else
                userActivity = userActivity.OrderByDescending(x => x.TimeStamp).ToList();

            return userActivity;
        }

        [HttpPut("update-user-activity/{id}")]
        public async Task<IActionResult> UpdateUserActivity(int id, UserActivity userActivity)
        {
            if (id != userActivity.ID)
            {
                return BadRequest();
            }

            _context.Entry(userActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserActivityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("add-user-activity")]
        public async Task<ActionResult<UserActivity>> AddUserActivity([FromBody]UserActivity userActivity)
        {
            _context.UserActivity.Add(userActivity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserActivity", new { id = userActivity.ID }, userActivity);
        }

        [HttpDelete("delete-user-activity/{id}")]
        public async Task<ActionResult<UserActivity>> DeleteUserActivity(int id)
        {
            var userActivity = await _context.UserActivity.FindAsync(id);
            if (userActivity == null)
            {
                return NotFound();
            }

            _context.UserActivity.Remove(userActivity);
            await _context.SaveChangesAsync();

            return userActivity;
        }

        private bool UserActivityExists(int id)
        {
            return _context.UserActivity.Any(e => e.ID == id);
        }
    }
}
