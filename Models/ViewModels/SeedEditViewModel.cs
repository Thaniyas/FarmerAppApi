using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class SeedEditViewModel
    {
        public int selectedLandDetailId { get; set; }
        public List<LandDetail> LandDetailName { get; set; }
        public int selectedPartLandDetailId { get; set; }
        public List<PartitionLandDetail> PartLandDetailName { get; set; }
        public int ID { get; set; }      
        public string Quantity { get; set; }       
        public string SeedName { get; set; }       
        public string SeedCost { get; set; }      
        public string NoOfLabours { get; set; }
        public int LabourCost { get; set; }
    }
}
