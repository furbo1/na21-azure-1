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
using Microsoft.Azure.Devices.Shared;
using AzureFunctions.Models;

namespace AzureFunctions
{
    public static class CreateDevice
    {
        private static readonly RegistryManager registry = RegistryManager.CreateFromConnectionString(Environment.GetEnvironmentVariable("IotHubConnectionString"));


        [FunctionName("CreateDevice")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            var model = JsonConvert.DeserializeObject<CreateDeviceModel>(await new StreamReader(req.Body).ReadToEndAsync());         
            var device = await registry.AddDeviceAsync(new Device(model.DeviceId));

            var twin = await registry.GetTwinAsync(device.Id);
            var twinprops = "{ \"properties\": { \"desired\": { \"placement\": \"" + model.Placement + "\", \"coordinates\": [" + model.Coordinates + "], \"sensorType\": \"" + model.SensorType + "\" }}}";
            return new OkObjectResult(await registry.UpdateTwinAsync(twin.DeviceId, twinprops, twin.ETag));
        }
    }
}
