﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class WeedRemoveViewModel
    {
       
       // public int LandDetailsId { get; set; }
        public int PartitionLandDetailsId { get; set; }
        public int LandDetailsId { get; set; }
        public int ID { get; set; }
        public string Date { get; set; }

        [MaxLength(50)]
        public string Cost { get; set; }
        [MaxLength(50)]
        public string NOofLabours { get; set; }
        public int LabourCost { get; set; }
        public bool Deleted { get; set; }

    }
}
