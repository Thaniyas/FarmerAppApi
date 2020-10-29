﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class HarvestingEditViewModel
    {
        public int selectedLandDetailId { get; set; }
        public int UserId { get; set; }
        public LandDetail LandDetailName { get; set; }
        public int selectedPartLandDetailId { get; set; }
        public PartitionLandDetail PartLandDetailName { get; set; }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public float Cost { get; set; }
        public int NoOfLabours { get; set; }
        public float LabourCost { get; set; }
        public string Notes { get; set; }
       
    }
}
