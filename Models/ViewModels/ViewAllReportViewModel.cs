using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class ViewAllReportViewModel
    {
        public string LandName { get; set; }
        public string Partition { get; set; }
        public float TotalExpenses { get; set; }
        public float TotalIncome { get; set; }
        public List<Plowing> plowings { get; set; }
        public List<Harvestings> harvestings { get; set; }
        public List<Seeding> seedings { get; set; }
        public List<PestControl> pestControls { get; set; }
        public List<WeedRemove> weedRemoves { get; set; }
        public List<Sale> sales { get; set; }
        
    }
}
