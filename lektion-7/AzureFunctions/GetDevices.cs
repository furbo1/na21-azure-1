using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.Devices;
using System.Linq;

namespace AzureFunctions
{
    public static class GetDevices
    {
        private static readonly RegistryManager registry = RegistryManager.CreateFromConnectionString(Environment.GetEnvironmentVariable("IotHubConnectionString"));

        [FunctionName("GetDevices")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var results = registry.CreateQuery("SELECT * FROM devices");
            var twins = await results.GetNextAsTwinAsync();

            var data = twins.Select(x => new { x.DeviceId, x.ConnectionState, x.Properties.Desired });
            return new OkObjectResult(data);
        }
    }
}
