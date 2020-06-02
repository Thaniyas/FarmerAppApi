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
        [MaxLength(50)]
        public string Quantity { get; set; }
        [MaxLength(50)]
        public string SeedName { get; set; }
        [MaxLength(50)]
        public string SeedCost { get; set; }
        [MaxLength(50)]
        public string NoOfLabours { get; set; }
        public DateTime Date { get; set; }
        public int LabourCost { get; set; }
        public bool Deleted { get; set; }
    }
}
