using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class LoginViewModel
    {

    }

    public class GoogleRegisterViewModel
    {
        public Authentication authentication { get; set; }
        public string email { get; set; }

        public string familyName { get; set; }

        public string givenName { get; set; }

        public string id { get; set; }

        public string imageUrl { get; set; }
        public string name { get; set; }

        public string serverAuthCode { get; set; }        
    }

    public class Authentication
    {
        public string accessToken { get; set; }
        public string idToken { get; set; }
    }


}
