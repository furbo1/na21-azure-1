using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AzureFunctions
{
    public static class GetCustomers
    {
        [FunctionName("GetCustomers")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "customers")] HttpRequest req,
            [CosmosDB(
                databaseName: "NA21",
                collectionName:"Customers",
                ConnectionStringSetting = "CosmosDB",
                SqlQuery = "SELECT c.firstName, c.lastName, c.id FROM c"
            )] IEnumerable<dynamic> customers,
            ILogger log)
        {
            return new OkObjectResult(customers);
        }
    }
}
