using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureFunctions
{
    public static class CreateCustomer
    {
        [FunctionName("CreateCustomer")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "customers")] HttpRequest req,
            [CosmosDB(
                databaseName: "NA21",
                collectionName: "Customers",
                ConnectionStringSetting = "CosmosDB",
                CreateIfNotExists = true
            )] out dynamic cosmos,
            ILogger log)
        {
 
            try
            {
                cosmos = new StreamReader(req.Body).ReadToEnd();
                return new OkResult(); // 200 OK
            }
            catch
            {
                cosmos = null;
                return new BadRequestResult(); // 400 Bad Request
            }


        }
    }
}
