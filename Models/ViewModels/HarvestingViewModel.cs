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

        [MaxLength(50)]
        public string Cost { get; set; }
        [MaxLength(50)]
        public string NoOfLabours { get; set; }
        public int LabourCost { get; set; }
    }
}
