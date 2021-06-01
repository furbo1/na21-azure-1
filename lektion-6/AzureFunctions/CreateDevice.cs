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
    public static class CreateDevice
    {

        private static readonly RegistryManager manager = RegistryManager.CreateFromConnectionString(Environment.GetEnvironmentVariable("IotHubSharedAccessPolicy"));

        [FunctionName("CreateDevice")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "devices")] HttpRequest req,
            ILogger log)
        {
            dynamic data = JsonConvert.DeserializeObject(await new StreamReader(req.Body).ReadToEndAsync());
            var res = await manager.AddDeviceAsync(new Device(data.deviceId.ToString()));
            log.LogInformation("New Device Created");

            return new OkObjectResult(res);
        }

        
    }
}
