using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Models.ViewModels;
using ThaniyasFarmerAppAPI.Repository;
using ThaniyasFarmerAppAPI.Filters;
using Microsoft.AspNetCore.Cors;
using Mapster;
using System.Net.WebSockets;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlowingController : ControllerBase
    {

        private readonly BaseDbContext _context;

        public PlowingController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-Plowing")]
        public async Task<ActionResult<Plowing>> AddPlowing([FromBody]PlowingViewModel input)
        {
            //_context.Plowings.Add(plowing);
            //await _context.SaveChangesAsync();

            //return new JsonResult(plowing);
            try
            {
                //if (isExists(input.TypeofPlowing) && input.ID == 0)
                //{
                //    return new JsonResult(new { status = true, ErrorMessage = "Already Exist" });
                //}

                Plowing plowing = null;
                if (input != null)
                {
                    plowing = input.Adapt<Plowing>();
                    var user = _context.Users.Where(s => s.ID == input.UserId).FirstOrDefault();
                    if (user == null) return new JsonResult(new { ErrorMessage = "The given user id not found." });
                    plowing.User = user;
                    var PartLandDetails = _context.PartitionLandDetails.Where(p => p.ID == input.PartitionLandDetailId).FirstOrDefault();
                    if (PartLandDetails == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });
                    plowing.PartitionLandDetail = PartLandDetails;
                    //Deciding whether the action is Add or Update
                    if (input.ID <= 0) //Add
                    {
                        _context.Plowings.Add(plowing);
                    }
                    else
                    { //Update
                        _context.Plowings.Update(plowing);
                    }
                }
                await _context.SaveChangesAsync();
                //var result = GetPlowing(plowing.ID);
                return new JsonResult(plowing);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }
        }

        [HttpGet("plowing-list")]
        public async Task<ActionResult<IEnumerable<Plowing>>> GetPlowingActivity(int userId)
        {
            var list= await _context.Plowings.Where(d => d.Deleted == false && d.PartitionLandDetail.LandDetail.Deleted==false && d.UserId == userId)
                    .Include(p => p.PartitionLandDetail).ToListAsync();
            return list.Where(x => x.UserId == userId).ToList();
        }

        [HttpGet("get-Plowing/{id}")]
        public async Task<ActionResult<PlowingEditViewModel>> GetPlowing(int id)
        {
            var plowing = await _context.Plowings.FindAsync(id);
            PlowingEditViewModel plowingEditViewModel = null;

            if (plowing != null)
            {
                var landDetails = _context.LandDetails.ToList();
                var partLandDetails = _context.PartitionLandDetails.ToList();
                plowingEditViewModel = new PlowingEditViewModel();
                plowingEditViewModel.ID = plowing.ID;
                plowingEditViewModel.PlowingExp = plowing.PlowingExp;
                plowingEditViewModel.PlowingDate = plowing.PlowingDate;
                plowingEditViewModel.TypeofPlowing = plowing.TypeofPlowing;
                plowingEditViewModel.Notes = plowing.Notes;
                plowingEditViewModel.LandDetailName = landDetails;
                plowingEditViewModel.selectedPartLandDetailId = plowing.PartitionLandDetailId;
                plowingEditViewModel.PartLandDetailName = partLandDetails;
            }
            return plowingEditViewModel;
        }

        [HttpDelete("delete-Plowing/{id}")]
        public async Task<ActionResult<Plowing>> DeletePlowing(int id)
        {
            var plowing = await _context.Plowings.FindAsync(id);
            if (plowing == null)
            {
                return NotFound();
            }

            _context.Entry(plowing).State = EntityState.Modified;

            plowing.Deleted = true;

            await _context.SaveChangesAsync();

            return plowing;
        }

        private bool isExists(string typeofPlowing)
        {
            var result = _context.Plowings.Where(a => a.TypeofPlowing.Equals(typeofPlowing));
            if (result.Any())
            {
                return true;
            }
            return false;
        }

    }
}
