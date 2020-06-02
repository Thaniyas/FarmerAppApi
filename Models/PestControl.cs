using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThaniyasFarmerAppAPI.Models
{
    public class PestControl : Base
    {
        public User User { get; set; }
        [ForeignKey("UserIDFK")]
        public int UserId { get; set; }
        public PartitionLandDetail PartitionLandDetail { get; set; }
        [ForeignKey("PartitionLandDetailIDFK")]
        public int PartitionLandDetailId { get; set; }
        public DateTime PestControlDate { get; set; }
        [MaxLength(50)]
        public string NameofthePestSide { get; set; }
        [MaxLength(50)]
        public string Cost { get; set; }
        [MaxLength(50)]
        public string Purpose { get; set; }
        [MaxLength(50)]
        public string LabourCost { get; set; }
        [MaxLength(50)]
        public new bool Deleted { get; set; }

        public PestControl()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
