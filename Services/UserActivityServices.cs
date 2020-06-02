using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Repository;
using ThaniyasFarmerAppAPI.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using System.Text;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ThaniyasFarmerAppAPI.Services
{
    public class UserActivityServices : IUserActivityServices
    {
        private readonly IConfiguration _configuration;
        private readonly BaseDbContext _context;

        public UserActivityServices(IConfiguration _configuration, BaseDbContext context)
        {
            this._configuration = _configuration;
            this._context = context;
        }

        public async Task AddActivityLog(int userId, ActionExecutedContext response)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                var action = (string)response.RouteData.Values["action"];
                var controller = (string)response.RouteData.Values["controller"];
                var activity = "";
                if (user != null)
                {
                    activity = user.UserName;
                }
                
                if (action.ToLower().Contains("add"))
                {
                    activity = activity + " Added " + controller;                    
                }
                else if (action.ToLower().Contains("update"))
                {
                    activity = activity + " Updated " + controller;
                }
                else if (action.ToLower().Contains("delete"))
                {
                    activity = activity + " Deleted " + controller;
                }
                else if (action.ToLower().Contains("get"))
                {
                    activity = activity + " Viewed " + controller + " List ";
                }

                if (action.ToLower().Contains("delete") || action.ToLower().Contains("update") || action.ToLower().Contains("add"))
                {
                    var resultString = "";
                    if (response.Result is JsonResult json)
                    {
                        var x = json.Value;
                        var status = json.StatusCode;
                        resultString=(JsonConvert.SerializeObject(x));
                    }
                    if (response.Result is ObjectResult objectResult)
                    {
                        var status = objectResult.StatusCode;
                        var value = objectResult.Value;
                        var stringResult = objectResult.ToString();
                        resultString = (JsonConvert.SerializeObject(value));
                    }
                    if (controller.ToLower().Contains("user"))
                    {
                        ////TODO: need to find the result values                                                
                        var resultData = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(resultString); 
                        if (resultData != null)
                        {
                           // activity = activity+" " + resultData.FirstName + " " + resultData.LastName;
                        }
                    }
                    if (controller.ToLower().Contains("landdetail"))
                    {
                        var resultData = Newtonsoft.Json.JsonConvert.DeserializeObject<LandDetail>(resultString);
                        
                        if (resultData != null)
                        {
                            var LandDetail = _context.LandDetails.Where(x => x.ID == resultData.ID).FirstOrDefault();
                            activity = LandDetail.Village + " ("+LandDetail.Name+")" +" has Added"+ ".";
                        }
                    }
                }
                var userActivity = new UserActivity { TimeStamp = DateTime.Now, UserID = userId };
                userActivity.Activity = activity + "  Successfully";

                _context.UserActivity.Add(userActivity);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
