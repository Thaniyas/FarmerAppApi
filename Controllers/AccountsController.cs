using System.Collections.Generic;
using ThaniyasFarmerAppAPI.Models;
using Microsoft.AspNetCore.Mvc;
using ThaniyasFarmerAppAPI.Services.Interfaces;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using ThaniyasFarmerAppAPI.Models.ViewModels;

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[DisableCors]
    public class AccountsController : ControllerBase
    {
        private IAccountsServices accountsServices;
        public AccountsController(IAccountsServices _accountsServices)
        {
            accountsServices = _accountsServices;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginInput input)
        {
            var returnResut = await accountsServices.Login(input);
            return new JsonResult(returnResut);
        }

        
        [HttpPost("google-login")]
        public async Task<IActionResult> GoogleLogin(GoogleRegisterViewModel input)
        {
            var returnResut = await accountsServices.GoogleLogin(input);
            return new JsonResult(returnResut);
        }

    }
}
