using System.Collections.Generic;
using ThaniyasFarmerAppAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleDataController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            var returnResut= new List<User>();
           // returnResut.Add(new User {ID=1, FirstName="Robin", LastName="Jack", UserName="RobinJack"});
          
            return new JsonResult(returnResut);
        }
    }
}
