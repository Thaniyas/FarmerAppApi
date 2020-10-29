using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class LandDetailViewModel
    {
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        public int ID { get; set; }

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
        public bool Deleted { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Plowing> PlowingDetails { get; set; }
    }
}
