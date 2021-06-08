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

namespace AzureApi
{
    public static class GetDevices
    {
        private static readonly RegistryManager registry = RegistryManager.CreateFromConnectionString(Environment.GetEnvironmentVariable("IotHubConnectionString"));


        [FunctionName("GetDevices")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "devices")] HttpRequest req,
            ILogger log)
        {
            var res = registry.CreateQuery("select * from devices");
            return new OkObjectResult(await res.GetNextAsTwinAsync());
        }
    }
}
