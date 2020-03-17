﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class PlowingViewModel
    {
        public int PartitionLandDetailsId { get; set; }
        public int LandDetailsId { get; set; }
        public int ID { get; set; }
        public DateTime PlowingDate { get; set; }
        [MaxLength(50)]
        public string TypeofPlowing { get; set; }
        [MaxLength(50)]
        public string PlowingExp { get; set; }
        public bool Deleted { get; set; }
    }
}
