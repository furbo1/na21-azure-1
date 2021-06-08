using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementCentral.Models
{
    public class CreateDeviceModel
    {
        public CreateDeviceModel()
        {

        }


        public CreateDeviceModel(string deviceId, string placement, string coordinates, string sensorType)
        {
            DeviceId = deviceId;
            Placement = placement;
            Coordinates = coordinates;
            SensorType = sensorType;
        }

        //{ "deviceId": "na21-test1", "placement": "vega", "coordinates": "60.123,10.123", "sensorType": "test" }
        
        public string DeviceId { get; set; }
        public string Placement { get; set; }
        public string Coordinates { get; set; }
        public string SensorType { get; set; }
    }
}
