using Microsoft.Azure.Devices.Client;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDevice
{
    class Program
    {
        private static readonly DeviceClient device = DeviceClient.CreateFromConnectionString("", TransportType.Mqtt_Tcp_Only);

        static async Task Main(string[] args)
        {
            long counter = 0;

            while (true)
            {
                var message = $"Meddelande #{++counter}";
                await SendMessageAsync(device, message);

                Console.WriteLine(message);
                await Task.Delay(await GetDesiredIntervalPropertyAsync(device));
            }
        }

        private static async Task SendMessageAsync(DeviceClient deviceClient, string message)
        {
            await deviceClient.SendEventAsync(new Message(Encoding.UTF8.GetBytes(message)));
        }

        private static async Task<int> GetDesiredIntervalPropertyAsync(DeviceClient deviceClient)
        {
            try 
            {
                var twin = await deviceClient.GetTwinAsync();
                return twin.Properties.Desired?["interval"]; 
            }
            catch { return 60 * 1000; }

        }
    }
}
