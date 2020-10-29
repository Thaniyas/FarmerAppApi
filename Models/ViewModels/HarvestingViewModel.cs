using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class HarvestingViewModel
    {
        public int PartitionLandDetailId { get; set; }
        public int UserId { get; set; }        
        public int ID { get; set; }
        public DateTime Date { get; set; }

        
        public float Cost { get; set; }
        
        public int NoOfLabours { get; set; }
        public float LabourCost { get; set; }
        public string Notes { get; set; }
       
    }
}
