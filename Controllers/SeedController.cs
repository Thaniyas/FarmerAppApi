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
    public class SeedController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public SeedController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-Seed")]
        public async Task<ActionResult<Seeding>> AddSeeding([FromBody]SeedingViewModel input)
        {
            //_context.Seedings.Add(Seeding);
            //await _context.SaveChangesAsync();

            //return new JsonResult(Seeding); 

            try
            {
               Seeding seeding = null;
                if (input != null)
                {
                    seeding = input.Adapt<Seeding>();
                    
                    //Deciding whether the action is Add or Update
                    if (input.ID <= 0) //Add
                    {
                        _context.Seedings.Add(seeding);
                    }
                    else
                    { //Update
                        _context.Seedings.Update(seeding);
                    }
                }
                await _context.SaveChangesAsync();
                var result = GetSeed(seeding.ID);
                return new JsonResult(seeding);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }

        }

        [HttpGet("seed-list")]
        public async Task<ActionResult<IEnumerable<Seeding>>> GetSeedActivity(int userId)
        {
            var list= await _context.Seedings.ToListAsync();
            return list.Where(x => x.UserId == userId).ToList();
        }

        [HttpGet("get-Seed/{id}")]
        public async Task<ActionResult<SeedEditViewModel>> GetSeed(int id)
        {
            var Seed = await _context.Seedings.FindAsync(id);
            SeedEditViewModel seedEditViewModel = null;
            if (Seed != null)
            {
                var landDetails = _context.LandDetails.ToList();
                var partLandDetails = _context.PartitionLandDetails.ToList();
                seedEditViewModel = new SeedEditViewModel();
                seedEditViewModel.ID = Seed.ID;
                seedEditViewModel.LabourCost = Seed.LabourCost;
                seedEditViewModel.NOofLabours = Seed.NOofLabours;
                seedEditViewModel.Quantity = Seed.Quantity;
                seedEditViewModel.SeedCost = Seed.SeedCost;
                seedEditViewModel.SeedName = Seed.SeedName;
                seedEditViewModel.LandDetailName = landDetails;
                seedEditViewModel.PartLandDetailName = partLandDetails;
            }

            return seedEditViewModel;
        }

        [HttpDelete("delete-Seed/{id}")]
        public async Task<ActionResult<Seeding>> DeleteSeeds(int id)
        {
            var seed = await _context.Seedings.FindAsync(id);
            if (seed == null)
            {
                return NotFound();
            }

            _context.Entry(seed).State = EntityState.Modified;

            seed.Deleted = true;

            await _context.SaveChangesAsync();

            return seed;
        }

    }
}
