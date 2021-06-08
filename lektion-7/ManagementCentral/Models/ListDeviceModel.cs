using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementCentral.Models
{

    public class ListDeviceModel
    {
        public string deviceId { get; set; }
        public int connectionState { get; set; }
        public Desired desired { get; set; }
    }

    public class Desired
    {
        public string temperatureAlert { get; set; }
        public string placement { get; set; }
        public float[] coordinates { get; set; }
        public string sensorType { get; set; }
        public Data data { get; set; }
        public Metadata metadata { get; set; }
        public int version { get; set; }
    }

    public class Data
    {
        public float temperature { get; set; }
        public int humidity { get; set; }
    }

    public class Metadata
    {
        public DateTime lastUpdated { get; set; }
        public int lastUpdatedVersion { get; set; }
        public Temperaturealert temperatureAlert { get; set; }
        public Placement placement { get; set; }
        public Coordinates coordinates { get; set; }
        public Sensortype sensorType { get; set; }
        public Data1 data { get; set; }
    }

    public class Temperaturealert
    {
        public DateTime lastUpdated { get; set; }
        public int lastUpdatedVersion { get; set; }
    }

    public class Placement
    {
        public DateTime lastUpdated { get; set; }
        public int lastUpdatedVersion { get; set; }
    }

    public class Coordinates
    {
        public DateTime lastUpdated { get; set; }
        public int lastUpdatedVersion { get; set; }
    }

    public class Sensortype
    {
        public DateTime lastUpdated { get; set; }
        public int lastUpdatedVersion { get; set; }
    }

    public class Data1
    {
        public DateTime lastUpdated { get; set; }
        public int lastUpdatedVersion { get; set; }
        public Temperature temperature { get; set; }
        public Humidity humidity { get; set; }
    }

    public class Temperature
    {
        public DateTime lastUpdated { get; set; }
        public int lastUpdatedVersion { get; set; }
    }

    public class Humidity
    {
        public DateTime lastUpdated { get; set; }
        public int lastUpdatedVersion { get; set; }
    }

}
