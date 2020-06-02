using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class User:Base
    {
        [Required]
        public string UserName { get; set; }

        [MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Password { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public int RoleID { get; set; }
        public bool IsFirstTimeLogin { get; set; }
        public string Source { get; set; } // google/facebook/none

        public bool AcceptedTermsAndConditions { get; set; }
        public string ResetPasswordToken { get; set; }


        public User()
        {
            AcceptedTermsAndConditions = false;
            IsFirstTimeLogin = true;         
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }

    }
}
