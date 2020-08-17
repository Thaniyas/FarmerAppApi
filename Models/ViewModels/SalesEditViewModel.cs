using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class SalesEditViewModel
    {
        public int selectedLandDetailId { get; set; }
        public List<LandDetail> LandDetailName { get; set; }
        public int selectedPartLandDetailId { get; set; }
        public List<PartitionLandDetail> PartLandDetailName { get; set; }
        public int ID { get; set; }
        public string SaleDate { get; set; }
       
        public string Quantity { get; set; }
      
        public string Price { get; set; }
      
        public string BuyerName { get; set; }
      
        public string BuyerMobileNumber { get; set; }
        public string Notes { get; set; }
       
    }
}
