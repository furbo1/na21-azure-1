using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorManagementCentral.Models
{

    public class DeviceItem
    {
        public string DeviceId { get; set; }
        public DeviceLocation Location { get; set; }
        public string LastUpdated { get; set; }
        public DeviceType Type { get; set; }
        public string Status { get; set; }
    }

    public class DeviceLocation
    {
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class DeviceType
    {
        public string Sensor { get; set; }
        public string Description { get; set; }
    }

}
