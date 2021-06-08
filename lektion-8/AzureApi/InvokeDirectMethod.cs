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
    public static class InvokeDirectMethod
    {

        private static readonly ServiceClient service = ServiceClient.CreateFromConnectionString(Environment.GetEnvironmentVariable("IotHubConnectionString"));

        [FunctionName("InvokeDirectMethod")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "method")] HttpRequest req,
            ILogger log)
        {
            string deviceid = req.Query["deviceid"];
            string command = req.Query["command"];

            var method = new CloudToDeviceMethod(command);
            method.SetPayloadJson(JsonConvert.SerializeObject(new { message = "" }));

            var response = await service.InvokeDeviceMethodAsync(deviceid, method);
         
            return new OkObjectResult(new { status = response.Status, payload = response.GetPayloadAsJson() });
        }
    }
}
