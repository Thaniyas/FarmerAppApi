using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Models.ViewModels;
using ThaniyasFarmerAppAPI.Repository;
namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ActionFillter]
    public class ViewReportController : Controller
    {
        private readonly BaseDbContext _context;

        public ViewReportController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpGet("get-viewreports")]
        public async Task<ActionResult<IEnumerable<ViewReportViewModel>>> GetViewReport(int id)
        {
            LandDetail landDetailViewModel = await _context.LandDetails.FindAsync(id);
            List<PartitionLandDetail> partitionLandViewModel = await _context.PartitionLandDetails.Where(p => p.LandDetailId == id).ToListAsync();
            List<ViewReportViewModel> viewReportViewModel = new List<ViewReportViewModel>();

            List<Plowing> plowing = null;
            List<Seeding> seeding = null;
            List<PestControl> pestControl = null;
            List<WeedRemove> weedRemove = null;
            List<Sale> sale  = null;
            List<Harvestings> harvestings = null;

            foreach (var partition in partitionLandViewModel)
            {
                plowing = await _context.Plowings.Where(p => p.PartitionLandDetailId == partition.ID).ToListAsync();
                seeding = await _context.Seedings.Where(s => s.PartitionLandDetailId == partition.ID).ToListAsync();
                pestControl = await _context.PestControls.Where(p => p.PartitionLandDetailId == partition.ID).ToListAsync();
                weedRemove = await _context.WeedRemove.Where(p => p.PartitionLandDetailId == partition.ID).ToListAsync();
                sale = await _context.Sales.Where(p => p.PartitionLandDetailId == partition.ID).ToListAsync();
                harvestings = await _context.Harvestings.Where(p => p.PartitionLandDetailId == partition.ID).ToListAsync();
              
                foreach (var plow in plowing)
                {
                    viewReportViewModel.Add(new ViewReportViewModel
                    {
                        Expense = plow.PlowingExp,
                        Income = 0,
                        LandName = landDetailViewModel.Name,
                        Partition = partition.LandDirection,
                        Purpose = "Plowing"
                    });

                }
                foreach (var seed in seeding)
                {
                    viewReportViewModel.Add(new ViewReportViewModel
                    {
                        Expense = seed.SeedCost + seed.LabourCost,
                        Income = 0,
                        LandName = landDetailViewModel.Name,
                        Partition = partition.LandDirection,
                        Purpose = "Seeding"
                    });
                }
                foreach (var pest in pestControl)
                {
                    viewReportViewModel.Add(new ViewReportViewModel
                    {
                        Expense = pest.LabourCost + pest.Cost,
                        Income = 0,
                        LandName = landDetailViewModel.Name,
                        Partition = partition.LandDirection,
                        Purpose = "PestControl"
                    });
                }
                foreach (var weed in weedRemove)
                {
                    viewReportViewModel.Add(new ViewReportViewModel
                    {
                        Expense = weed.Cost + weed.LabourCost,
                        Income = 0,
                        LandName = landDetailViewModel.Name,
                        Partition = partition.LandDirection,
                        Purpose = "WeedRemove"
                    });
                }
                foreach (var harvest in harvestings)
                {
                    viewReportViewModel.Add(new ViewReportViewModel
                    {
                        Expense = harvest.Cost + harvest.LabourCost,
                        Income = 0,
                        LandName = landDetailViewModel.Name,
                        Partition = partition.LandDirection,
                        Purpose = "Harvesting"
                    });
                }

                foreach (var sales in sale)
                {
                    viewReportViewModel.Add(new ViewReportViewModel
                    {
                        Expense = sales.Price,
                        Income = 0,
                        LandName = landDetailViewModel.Name,
                        Partition = partition.LandDirection,
                        Purpose = "Sale"
                    });
                }

            }

            return viewReportViewModel;

            
        }

    }
}
    

