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

namespace AzureFunctions
{
    public static class DeleteDevice
    {
        private static readonly RegistryManager registry = RegistryManager.CreateFromConnectionString(Environment.GetEnvironmentVariable("IotHubConnectionString"));

        [FunctionName("DeleteDevice")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "delete", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {
                string deviceId = req.Query["deviceid"];
                await registry.RemoveDeviceAsync(deviceId);

                return new OkResult();
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }

        }
    }
}
