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
    public class SaleController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public SaleController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-Sale")]
        public async Task<ActionResult<Sale>> AddSale(SalesViewModel input)
        {
            try
            {
                Sale sale = null;
                if (input != null)
                {
                    sale = input.Adapt<Sale>();
                    //Getting Land detail
                    var landDetail = _context.LandDetails.Where(s => s.ID == input.LandDetailsId).FirstOrDefault();
                    if (landDetail == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });
                    var PartLandDetails = _context.PartitionLandDetails.Where(p => p.ID == input.PartitionLandDetailsId).FirstOrDefault();
                    if (PartLandDetails == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });

                    //Setting the land detail value to the Partition Land detail object
                    sale.LandDetailsId = landDetail;
                    sale.PartitionLandDetailId = PartLandDetails;

                    //Deciding whether the action is Add or Update
                    if (input.ID <= 0) //Add
                    {
                        _context.Sales.Add(sale);
                    }
                    else
                    { //Update
                        _context.Sales.Update(sale);
                    }
                }
                await _context.SaveChangesAsync();
                var result = GetSale(sale.ID);
                return new JsonResult(sale);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }
        }

        [HttpGet("sale-list")]
        public async Task<ActionResult<IEnumerable<Sale>>> GetSaleActivity()
        {
            return await _context.Sales.ToListAsync();
        }

        [HttpGet("get-Sale/{id}")]
        public async Task<ActionResult<SalesEditViewModel>> GetSale(int id)
        {
            var sale = await _context.Sales.FindAsync(id);
            SalesEditViewModel salesEditViewModel = null;

            if (sale != null)
            {
                var landDetails = _context.LandDetails.ToList();
                var partLandDetails = _context.PartitionLandDetails.ToList();
                salesEditViewModel = new SalesEditViewModel();
                salesEditViewModel.BuyerMobileNumber = sale.BuyerMobileNumber;
                salesEditViewModel.BuyerName = sale.BuyerName;
                salesEditViewModel.SaleDate = sale.SaleDate;
                salesEditViewModel.ID = sale.ID;
                salesEditViewModel.Price = sale.Price;
                salesEditViewModel.Quantity = sale.Quantity;
                salesEditViewModel.LandDetailName = landDetails;
                salesEditViewModel.selectedLandDetailId = sale.LandDetailsId.ID;
                salesEditViewModel.PartLandDetailName = partLandDetails;
                salesEditViewModel.selectedPartLandDetailId = sale.PartitionLandDetailId.ID;
            }
            return salesEditViewModel;
        }

        [HttpDelete("delete-Sale/{id}")]
        public async Task<ActionResult<Sale>> DeleteSale(int id)
        {
            var sale = await _context.Sales.FindAsync(id);
            if (sale == null)
            {
                return NotFound();
            }

            _context.Entry(sale).State = EntityState.Modified;

            sale.Deleted = true;

            await _context.SaveChangesAsync();

            return sale;
        }

    }
}