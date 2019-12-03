using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace challenge_1
{
    public static class Dreidel
    {
        static readonly char[] CHARACTERS = {'נ', 'ג', 'ה', 'ש'};
        [FunctionName("dreidel")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("dreidel spin requested");
            var rand = new Random();
            var index = rand.Next(4);
            return new OkObjectResult($"{CHARACTERS[index]}");
        }
    }
}
