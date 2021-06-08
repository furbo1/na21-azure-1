using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunctions.Models
{

    public class CreateDeviceModel
    {
        public string DeviceId { get; set; }
        public string Placement { get; set; }
        public string Coordinates { get; set; }
        public string SensorType { get; set; }
    }

}
