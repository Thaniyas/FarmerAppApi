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
    public class PartitionLandController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public PartitionLandController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-PartitionLand")]
        public async Task<ActionResult<PartitionLandEditViewModel>> AddpartitionLand([FromBody]PartitionLandViewModel input)
        {
            //try {
            //    var partitionLandDetail = input.Adapt<PartitionLandDetail>();
            //    _context.PartitionLandDetails.Add(partitionLandDetail);
            //    await _context.SaveChangesAsync();
            //    return new JsonResult(partitionLandDetail);
            //}
            //catch (Exception _ex)
            //{
            //    return new JsonResult(new { ErrorMessage = _ex.Message });
            //}


            try
            {
                PartitionLandDetail partitionLandDetail = null;
                if (input != null)
                {
                    partitionLandDetail = input.Adapt<PartitionLandDetail>();
                    //Getting Land detail
                    var landDetail = _context.LandDetails.Where(s => s.ID == input.LandDetailsId).FirstOrDefault();
                    if (landDetail == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });

                    //Setting the land detail value to the Partition Land detail object
                    partitionLandDetail.LandDetail = landDetail;

                    //Deciding whether the action is Add or Update
                    if (input.ID <= 0) //Add
                    {
                        _context.PartitionLandDetails.Add(partitionLandDetail);
                    }
                    else
                    { //Update  
                        _context.PartitionLandDetails.Update(partitionLandDetail);
                    }
                }
                await _context.SaveChangesAsync();
                var result = GetPartLand(partitionLandDetail.ID);
                return new JsonResult(partitionLandDetail);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }
        }

        [HttpGet("PartitionLand-list")]
        public async Task<ActionResult<IEnumerable<PartitionLandViewModel>>> GetPartLandActivity()
        {

            var partLandList = await _context.PartitionLandDetails.ToListAsync();
            var returnpartLandList = new List<PartitionLandViewModel>();
            foreach (var obj in partLandList)
            {
                returnpartLandList.Add(
                    new PartitionLandViewModel
                    {
                        AreaSize = obj.AreaSize,
                        LandDirection = obj.LandDirection,
                        ID = obj.ID,
                       // LandDetailsId = "",
                    });
            }
            return returnpartLandList;

        }
        [HttpGet("get-PartitionLand/{id}")]
        public async Task<ActionResult<PartitionLandEditViewModel>> GetPartLand(int id)
        {
            var PartLand = await _context.PartitionLandDetails.Where(a => a.ID == id).Include(l => l.LandDetail.State).FirstOrDefaultAsync();
            PartitionLandEditViewModel partitionLandEditViewModel = null;
            if (PartLand != null)
            {
                //Get the land details
                var landDetails = _context.LandDetails.ToList();
                partitionLandEditViewModel = new PartitionLandEditViewModel();
                partitionLandEditViewModel.ID = PartLand.ID;
                partitionLandEditViewModel.AreaSize = PartLand.AreaSize;
                partitionLandEditViewModel.LandDirection = PartLand.LandDirection;
                partitionLandEditViewModel.LandDetailName = landDetails;
                partitionLandEditViewModel.selectedLandDetailId = PartLand.LandDetail.ID;
                //return NotFound();
            }
            return partitionLandEditViewModel;
        }


        [HttpDelete("delete-PartLand/{id}")]
        public async Task<ActionResult<PartitionLandDetail>> DeletePartitionLand(int id)
        {
            var PartLand = await _context.PartitionLandDetails.FindAsync(id);
            if (PartLand == null)
            {
                return NotFound();
            }

            _context.Entry(PartLand).State = EntityState.Modified;

            PartLand.Deleted = true;

            await _context.SaveChangesAsync();

            return PartLand;
        }


    }
}
