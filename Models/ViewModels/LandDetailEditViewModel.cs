﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class LandDetailEditViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int selectedStateListId { get; set; }
        public List<StateList> States { get; set; }
        public string Village { get; set; }
        public string City { get; set; }
        public string PattaNumber { get; set; }
        public int AreaSize { get; set; }
    }
}
