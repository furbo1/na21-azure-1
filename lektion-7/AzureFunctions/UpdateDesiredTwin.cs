using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Devices;
using System;
using System.Threading.Tasks;

namespace AzureFunctions
{
    public static class UpdateDesiredTwin
    {
        private static HttpClient client = new HttpClient();
        private static readonly RegistryManager registry = RegistryManager.CreateFromConnectionString(Environment.GetEnvironmentVariable("IotHubConnectionString"));


        [FunctionName("UpdateDesiredTwin")]
        public static async Task Run([IoTHubTrigger("messages/events", Connection = "IotHubEndpoint", ConsumerGroup = "na21-1")]EventData message, ILogger log)
        {
            var data = Encoding.UTF8.GetString(message.Body.Array);
            var deviceId = message.SystemProperties["iothub-connection-device-id"].ToString();
            var temperatureAlert = message.Properties["temperatureAlert"].ToString();
            var placement = message.Properties["placement"].ToString();
            var coordinates = message.Properties["coordinates"].ToString();
            var sensorType = message.Properties["sensorType"].ToString();

            var twinprops = "{ \"properties\": { \"desired\": { \"temperatureAlert\": \"" + temperatureAlert + "\", \"placement\": \"" + placement + "\", \"coordinates\": [" + coordinates + "], \"sensorType\": \"" + sensorType + "\", \"data\": "+ data +" }}}";

            var twin = await registry.GetTwinAsync(deviceId);
            await registry.UpdateTwinAsync(twin.DeviceId, twinprops, twin.ETag);
        }
    }
}