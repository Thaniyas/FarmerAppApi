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
    public class ViewAllReportController : Controller
    {
        private readonly BaseDbContext _context;

        public ViewAllReportController(BaseDbContext context)
        {
            _context = context;
        }
        [HttpGet("get-viewAllreports")]
        public async Task<ActionResult<IEnumerable<ViewAllReportViewModel>>> GetViewReport()
        {
            //List<LandDetail> landDetailViewModel = new List<LandDetail>();
            List<ViewAllReportViewModel> viewAllReportViewModel = new List<ViewAllReportViewModel>();
            List<LandDetail> landDetailViewModel = await _context.LandDetails.ToListAsync();
            // List<PartitionLandDetail> partitionLandViewModel = await _context.PartitionLandDetails.Where(p => p.LandDetailId == id).ToListAsync();
            float sale = 0;
            float Total = 0;
            List<PartitionLandDetail> partitionLandViewModel = null; // await _context.PartitionLandDetails.ToListAsync();
            foreach (var land in landDetailViewModel) 
            {
                partitionLandViewModel = await _context.PartitionLandDetails.Where(p=>p.LandDetailId == land.ID).ToListAsync();

                foreach (var partition in partitionLandViewModel)
                {
                    Total = _context.WeedRemove.Where(m => m.PartitionLandDetailId.Equals(partition.ID)).Sum(m => m.Cost) + _context.WeedRemove.Sum(m => m.LabourCost);
                    Total = Total + _context.Harvestings.Where(m => m.PartitionLandDetailId.Equals(partition.ID)).Sum(m => m.Cost);
                    Total = Total + _context.PestControls.Where(m => m.PartitionLandDetailId.Equals(partition.ID)).Sum(m => m.Cost);
                    Total = Total + _context.Seedings.Where(m => m.PartitionLandDetailId.Equals(partition.ID)).Sum(m => m.LabourCost);
                    Total = Total + _context.Plowings.Where(m => m.PartitionLandDetailId.Equals(partition.ID)).Sum(m => m.PlowingExp);

                    sale = _context.Sales.Where(p => p.PartitionLandDetailId == partition.ID).Sum(m => m.Price);
                   // var viewall = await _context.Plowings.GroupBy(p => p.PartitionLandDetailId).ToListAsync();

                    viewAllReportViewModel.Add(new ViewAllReportViewModel
                    {
                        LandName = land.Name,
                        Partition = partition.LandDirection,
                        TotalExpenses = Total,
                        TotalIncome = sale
                         
                    });
                    
                }
         
                
           
            }
            return viewAllReportViewModel;


            
        }
    }
}
