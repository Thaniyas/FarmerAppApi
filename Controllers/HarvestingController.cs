﻿using System;
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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     [ActionFillter]
    public class HarvestingController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public HarvestingController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-Harvestings")]
        public async Task<ActionResult<HarvestingEditViewModel>> AddHarvestings([FromBody]HarvestingViewModel input)
        {            

            try
            {
                Harvestings harvest = null;
                if (input != null)
                {
                    harvest = input.Adapt<Harvestings>();
                    
                    
                    var user = _context.Users.Where(s => s.ID == input.UserId).FirstOrDefault();
                    if (user == null) return new JsonResult(new { ErrorMessage = "The given user id not found." });
                    harvest.User = user;
                    var PartLandDetails = _context.PartitionLandDetails.Where(p => p.ID == input.PartitionLandDetailsId).FirstOrDefault();
                    if (PartLandDetails == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });
                    harvest.PartitionLandDetail = PartLandDetails;

                    //Deciding whether the action is Add or Update
                    if (input.ID <= 0) //Add
                    {
                        _context.Harvestings.Add(harvest);
                    }
                    else
                    { //Update
                        _context.Harvestings.Update(harvest);
                    }

                }
                await _context.SaveChangesAsync();

                //return the getharverst method value
                var result = GetHarvest(harvest.ID);

                return new JsonResult(result);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }
        }

        [HttpGet("harvesting-list")]
        public async Task<ActionResult<IEnumerable<Harvestings>>> GetHarvestActivity(int userId)
        {
            var list= await _context.Harvestings.ToListAsync();
            return list.Where(x => x.UserId == userId).ToList();
        }

        [HttpGet("get-Harvesting/{id}")]
        public async Task<ActionResult<HarvestingEditViewModel>> GetHarvest(int id)
        {
            var Harvest = await _context.Harvestings.FindAsync(id);
            HarvestingEditViewModel harvestingEditViewModel = null;

            if (Harvest != null)
            {
                var landDetails = _context.LandDetails.ToList();
                var partLandDetails = _context.PartitionLandDetails.ToList();
                harvestingEditViewModel = new HarvestingEditViewModel();
                harvestingEditViewModel.ID = Harvest.ID;
                harvestingEditViewModel.LabourCost = Harvest.LabourCost;
                harvestingEditViewModel.NOofLabours = Harvest.NOofLabours;
                harvestingEditViewModel.Cost = Harvest.Cost;
                harvestingEditViewModel.Date = Harvest.Date;
            }
            return harvestingEditViewModel;
        }

        [HttpDelete("delete-Harvest/{id}")]
        public async Task<ActionResult<Harvestings>> DeleteHarvest(int id)
        {
            var harvest = await _context.Harvestings.FindAsync(id);
            if (harvest == null)
            {
                return NotFound();
            }

            _context.Entry(harvest).State = EntityState.Modified;

            harvest.Deleted = true;

            await _context.SaveChangesAsync();

            return harvest;
        }

    }
}
