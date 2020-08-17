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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ActionFillter]
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
                //if (isExists(input.SeedName) && input.ID == 0)
                //{
                //    return new JsonResult(new { status = true, ErrorMessage = "Already Exist" });
                //}

               Seeding seeding = null;
                if (input != null)
                {
                    seeding = input.Adapt<Seeding>();
                    var user = _context.Users.Where(s => s.ID == input.UserId).FirstOrDefault();
                    if (user == null) return new JsonResult(new { ErrorMessage = "The given user id not found." });
                    seeding.User = user;
                    var PartLandDetails = _context.PartitionLandDetails.Where(p => p.ID == input.PartitionLandDetailId).FirstOrDefault();
                    if (PartLandDetails == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });
                    seeding.PartitionLandDetail = PartLandDetails;
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
                //var result = GetSeed(seeding.ID);
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
            var list= await _context.Seedings.Where(d => d.Deleted == false && d.PartitionLandDetail.LandDetail.Deleted == false && d.UserId == userId)
                    .Include(p => p.PartitionLandDetail).ToListAsync();
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
                seedEditViewModel.NoOfLabours = Seed.NoOfLabours;
                seedEditViewModel.Quantity = Seed.Quantity;
                seedEditViewModel.SeedCost = Seed.SeedCost;
                seedEditViewModel.Notes = Seed.Notes;
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

        private bool isExists(string seedName)
        {
            var result = _context.Seedings.Where(a => a.SeedName.Equals(seedName));
            if (result.Any())
            {
                return true;
            }
            return false;
        }

    }
}
