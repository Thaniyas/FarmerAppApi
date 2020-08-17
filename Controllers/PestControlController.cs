using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Models.ViewModels;
using ThaniyasFarmerAppAPI.Repository;
using Mapster;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ActionFillter]
    public class PestControlController : ControllerBase
    {

        private readonly BaseDbContext _context;

        public PestControlController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpGet("pestControl-list")]
        public async Task<ActionResult<IEnumerable<PestControl>>> GetPestControlActivity(int userId)
        {
            var list= await _context.PestControls.Where(d => d.Deleted == false && d.PartitionLandDetail.LandDetail.Deleted == false && d.UserId == userId)
                    .Include(p => p.PartitionLandDetail).ToListAsync();
            return list.Where(x => x.UserId == userId).ToList();
        }

        [HttpPost]
        [Route("add-PestControl")]
        public async Task<ActionResult<PestControl>> AddPestControl([FromBody]PestControlViewModel input)
        {
            //_context.PestControls.Add(pestControl);
            //await _context.SaveChangesAsync();

            //return new JsonResult(pestControl);

            try
            {
                //if(isExists(input.NameofthePestSide)&& input.ID == 0)
                //{
                //    return new JsonResult(new { status = true, ErrorMessage = "Already Exist" });
                //}

                PestControl pestControl = null;
                if (input != null)
                {
                    pestControl = input.Adapt<PestControl>();

                    var user = _context.Users.Where(s => s.ID == input.UserId).FirstOrDefault();
                    if (user == null) return new JsonResult(new { ErrorMessage = "The given user id not found." });
                    pestControl.User = user;
                    var PartLandDetails = _context.PartitionLandDetails.Where(p => p.ID == input.PartitionLandDetailId).FirstOrDefault();
                    if (PartLandDetails == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });
                    pestControl.PartitionLandDetail = PartLandDetails;
                    //Deciding whether the action is Add or Update
                    if (input.ID <= 0) //Add
                    {
                        _context.PestControls.Add(pestControl);
                    }
                    else
                    { //Update
                        _context.PestControls.Update(pestControl);
                    }
                }
                await _context.SaveChangesAsync();
                //var result = GetPestControl(pestControl.ID);
                return new JsonResult(pestControl);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }
        }        

        [HttpGet("get-PestControl/{id}")]
        public async Task<ActionResult<PestControlEditViewModel>> GetPestControl(int id)
        {
            var pestControl = await _context.PestControls.FindAsync(id);
            PestControlEditViewModel pestControlEditViewModel = null;

            if (pestControl != null)
            {
                var landDetails = _context.LandDetails.ToList();
                var partLandDetails = _context.PartitionLandDetails.ToList();
                pestControlEditViewModel = new PestControlEditViewModel();
                pestControlEditViewModel.ID = pestControl.ID;
                pestControlEditViewModel.LabourCost = pestControl.LabourCost;
                pestControlEditViewModel.NameofthePestSide = pestControl.NameofthePestSide;
                pestControlEditViewModel.Purpose = pestControl.Purpose;
                pestControlEditViewModel.Notes = pestControl.Notes;
                //pestControlEditViewModel.PestControlDate = pestControl.PestControlDate;
                pestControlEditViewModel.Cost = pestControl.Cost;
                pestControlEditViewModel.LandDetailName = landDetails;
                pestControlEditViewModel.PartLandDetailName = partLandDetails;
            }
            return pestControlEditViewModel;
        }

        [HttpDelete("delete-PestControl/{id}")]
        public async Task<ActionResult<PestControl>> DeletePestControl(int id)
        {
            var pestControl = await _context.PestControls.FindAsync(id);
            if (pestControl == null)
            {
                return NotFound();
            }

            _context.Entry(pestControl).State = EntityState.Modified;

            pestControl.Deleted = true;

            await _context.SaveChangesAsync();

            return pestControl;
        }

        private bool isExists(string nameofPestSide)
        {
            var result = _context.PestControls.Where(a => a.NameofthePestSide.Equals(nameofPestSide));
            if (result.Any())
            {
                return true;
            }
            return false;
        }
    }
}
