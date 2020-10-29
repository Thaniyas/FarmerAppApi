using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class ViewReportViewModel
    {
        public string LandName { get; set; }
        public string Partition { get; set; }
        public string Purpose { get; set; }
        public float Income { get; set; }
        public float Expense { get; set; }
    }
}
