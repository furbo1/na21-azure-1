using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorManagementCentral.Models
{

    public class DailyStatsItem
    {
        public int TotalMessages { get; set; }
        public int TotalDevices { get; set; }
        public int TotalNewDevices { get; set; }
        public int TotalC2DCount { get; set; }
    }

}
