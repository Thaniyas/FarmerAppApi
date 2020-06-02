using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class PartitionLandEditViewModel
    {
       
        public string LandDirection { get; set; }
        public int selectedLandDetailId { get; set; }
        public List<LandDetail> LandDetailName { get; set; }
        public int ID { get; set; }
        public string AreaSize { get; set; }
        public bool Deleted { get; set; }
        public int UserId { get; set; }
    }
}
