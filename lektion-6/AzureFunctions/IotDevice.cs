using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureFunctions
{
    public static class IotDevice
    {
        private static readonly DeviceClient device = DeviceClient.CreateFromConnectionString(Environment.GetEnvironmentVariable("azfdevice"), TransportType.Mqtt_Tcp_Only);

        [FunctionName("IotDevice")]
        public static async Task Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            var json = JsonConvert.SerializeObject(new { location = "vega", time = DateTime.Now });
            await SendMessageAsync(json);

            log.LogInformation($"Skickade meddelande: {json}");
        }

        private static async Task SendMessageAsync(string json)
        {
            var payload = new Message(Encoding.UTF8.GetBytes(json));
            await device.SendEventAsync(payload);
        }
    }
}
