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
        private static readonly RegistryManager manager = RegistryManager.CreateFromConnectionString(Environment.GetEnvironmentVariable("IotHubSharedAccessPolicy"));


        [FunctionName("GetDevices")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "devices")] HttpRequest req,
            ILogger log)
        {
            var results = manager.CreateQuery("SELECT * FROM devices");
            var data = await results.GetNextAsTwinAsync();

            return new OkObjectResult(data);

        }
    }
}
