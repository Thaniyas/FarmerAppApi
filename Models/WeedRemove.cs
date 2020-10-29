using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThaniyasFarmerAppAPI.Models
{
    public class WeedRemove : Base
    {

        public User User { get; set; }
        [ForeignKey("UserIDFK")]
        public int UserId { get; set; }
        public PartitionLandDetail PartitionLandDetail { get; set; }
        [ForeignKey("PartitionLandDetailIDFK")]
        public int PartitionLandDetailId { get; set; }

        public DateTime Date { get; set; }

       
        public float Cost { get; set; }
       
        public int NoOfLabours { get; set; }
        public float LabourCost { get; set; }
        [MaxLength(50)]
        public string Notes { get; set; }
    
        public new bool Deleted { get; set; }

        public WeedRemove()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
