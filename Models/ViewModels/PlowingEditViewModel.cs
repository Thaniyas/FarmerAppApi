using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class PlowingEditViewModel
    {
        public int selectedLandDetailId { get; set; }
        public List<LandDetail> LandDetailName { get; set; }
        public int selectedPartLandDetailId { get; set; }
        public List<PartitionLandDetail> PartLandDetailName { get; set; }
        public int ID { get; set; }
        public DateTime PlowingDate { get; set; }
       
        public string TypeofPlowing { get; set; }
       
        public float PlowingExp { get; set; }
        public string Notes { get; set; }
      

    }
}
