using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class LandDetail : Base
    {
        public User User { get; set; }
        [ForeignKey("UserIDFK")]
        public int UserId { get; set; }
        
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        public StateList State { get; set; }
        [ForeignKey("StateIDFK")]
        public int StateId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Village { get; set; }

        [MaxLength(50)]
        public string City { get; set; }
      
        public int PattaNumber { get; set; }
  
        public int SurveyNumber { get; set; }
        public float AreaSize { get; set; }
        [MaxLength(50)]
        public string Notes { get; set; }
        
        public virtual ICollection<PartitionLandDetail> PartitionLandDetails { get; set; }
        // public string Unit { get; set; }

        public LandDetail()
        {
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
