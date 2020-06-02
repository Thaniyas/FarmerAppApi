using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class GoogleRegister:Base
    {
        public string email { get; set; }

        public string familyName { get; set; }

        public string givenName { get; set; }
       
        public string googleid { get; set; }

        public string imageUrl { get; set; }
        public string name { get; set; }

        public string serverAuthCode { get; set; }
        public string accessToken { get; set; }
        public string idToken { get; set; }
        public User User { get; set; }
        [ForeignKey("UserIDFK")]
        public int UserId { get; set; }

        public GoogleRegister()
        {    
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }

    }
}
