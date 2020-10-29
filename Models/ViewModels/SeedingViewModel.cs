using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class SeedingViewModel
    {
        // public int LandDetailsId { get; set; }
        public int PartitionLandDetailId { get; set; }
        public int UserId { get; set; }
        public int ID { get; set; }
        
        public int Quantity { get; set; }
        [MaxLength(50)]
        public string SeedName { get; set; }
        
        public float SeedCost { get; set; }
        
        public int NoOfLabours { get; set; }
        public DateTime Date { get; set; }
        public float LabourCost { get; set; }
        public string Notes { get; set; }     
        public bool Deleted { get; set; }
    }
}
