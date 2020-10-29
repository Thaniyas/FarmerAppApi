using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class PartitionLandViewModel
    {
        [Required]
        [MaxLength(75)]
        public string LandDirection { get; set; }
        [Required]
        public int LandDetailId { get; set; }
        public int ID { get; set; }
        public float AreaSize { get; set; }
        [MaxLength(50)]
        public string Notes { get; set; }       
        public bool Deleted { get; set; }
        public int UserId { get; set; }

    }
}
