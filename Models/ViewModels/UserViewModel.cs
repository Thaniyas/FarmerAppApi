using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
        public int RoleID { get; set; }
       // public string JoinedDate { get; set; }
        //public bool IsFirstTimeLogin { get; set; }
        //public bool AcceptedTermsAndConditions { get; set; }
        //public List<WebPages> WebPages { get; set; }
        //public bool Deleted { get; set; }
    }

    public class LoginResults
    {
        public Status status { get; set; }
        public UserViewModel userDetail { get; set; }
    }

    public class ChangePasswordInput
    {
        public int id { get; set; }
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
    }

    public class AddResetToken
    {
        public string Email { get; set; }
    }

    public class ResetPassword
    {
        public string Email { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }

    }
    public class ChangePasswordResult
    {
        public Status status { get; set; }
        public UserViewModel userDetail { get; set; }
    }

    public class PostLoginViewModel
    {
        public int UserId { get; set; }
        public bool IsFirstTimeLogin { get; set; }
        public bool AcceptedTermsAndConditions { get; set; }
    }
}
