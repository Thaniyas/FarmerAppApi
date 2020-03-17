﻿using System;
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
        public int LandDetailsId { get; set; }
        public int ID { get; set; }
        public string AreaSize { get; set; }
        public bool Deleted { get; set; }
       
    }
}
