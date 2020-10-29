using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThaniyasFarmerAppAPI.Models
{
    public class Sale : Base
    {

        public User User { get; set; }
        [ForeignKey("UserIDFK")]
        public int UserId { get; set; }
        public PartitionLandDetail PartitionLandDetail { get; set; }
        [ForeignKey("PartitionLandDetailIDFK")]
        public int PartitionLandDetailId { get; set; }
        public DateTime SaleDate { get; set; }
     
        public int Quantity { get; set; }
        
        public float Price { get; set; }
        [MaxLength(50)]
        public string BuyerName { get; set; }
        [MaxLength(50)]
        public string BuyerMobileNumber { get; set; }
        [MaxLength(50)]
        public string Notes { get; set; }     
        public new bool Deleted { get; set; }

        public Sale()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
