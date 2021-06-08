using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunctions.Models
{
    public class GetDevicesModel
    {
        public string DeviceId { get; set; }
        public string ConnectionState { get; set; }

    }
}
