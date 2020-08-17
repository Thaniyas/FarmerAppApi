using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class PestControlEditViewModel
    {
        public int selectedLandDetailId { get; set; }
        public List<LandDetail> LandDetailName { get; set; }
        public int selectedPartLandDetailId { get; set; }
        public List<PartitionLandDetail> PartLandDetailName { get; set; }
        public int ID { get; set; }
        public string PestControlDate { get; set; }
       
        public string NameofthePestSide { get; set; }
       
        public string Cost { get; set; }
      
        public string Purpose { get; set; }
      
        public string LabourCost { get; set; }
        public string Notes { get; set; }
      
        public int UserId { get; set; }
    }
}
