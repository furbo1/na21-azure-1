using Microsoft.Azure.Devices;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GetDevicesTest
{
    class Program
    {
        private static readonly RegistryManager manager = RegistryManager.CreateFromConnectionString("HostName=na21-iothub.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=VaTNDUAHLgUJOxf/uUyY2qFreticAkc0yfChbMPs+DE=");

        static async Task Main(string[] args)
        {
            var results = manager.CreateQuery("SELECT * FROM devices");

            var data = await results.GetNextAsTwinAsync();

            if(data.Any())
            {
                var json = JsonConvert.SerializeObject(data);
                Console.WriteLine(json);
            }
        }
    }
}
