using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Serverless1Dreidel
{
    public static class Function1
    {
        [FunctionName("Dreidel")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string spinup = Dreidel.GetRandom();

            return !string.IsNullOrEmpty(spinup)
                ? (ActionResult)new OkObjectResult($"Hello dreidel says: {spinup}")
                : new BadRequestObjectResult("Sorry we're having a problem");
        }
    }
}
