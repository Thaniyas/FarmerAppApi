using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class SalesViewModel
    {
        public int PartitionLandDetailId { get; set; }
        public int UserId { get; set; }
        public int ID { get; set; }
        public DateTime SaleDate { get; set; }
        [MaxLength(50)]
        public string Quantity { get; set; }
        [MaxLength(50)]
        public string Price { get; set; }
        [MaxLength(50)]
        public string BuyerName { get; set; }
        [MaxLength(50)]
        public string BuyerMobileNumber { get; set; }
        public bool Deleted { get; set; }
    }
}
