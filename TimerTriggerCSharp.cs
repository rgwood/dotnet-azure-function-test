using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Reilly.Function
{
    public static class TimerTriggerCSharp
    {
        [FunctionName("TimerTriggerCSharp")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            var dt = new DateTime();

            log.LogInformation($"JSON: {JsonConvert.SerializeObject(dt)}");

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
