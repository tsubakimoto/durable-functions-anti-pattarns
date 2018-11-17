using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace durable_functions_anti_pattarns
{
    public static class GenerateGuidInOrchestrator
    {
        [FunctionName("GenerateGuidInOrchestrator")]
        public static async Task Run(
            [OrchestrationTrigger] DurableOrchestrationContextBase context,
            ILogger log)
        {
            var myGuid = System.Guid.NewGuid();
            log.LogWarning($"myGuid: {myGuid}");

            await context.CallActivityAsync(nameof(ActivityA), "1");
            await context.CallActivityAsync(nameof(ActivityA), "2");
            await context.CallActivityAsync(nameof(ActivityA), "3");
        }

        [FunctionName("ActivityA")]
        public static void ActivityA([ActivityTrigger] string name) { }
    }
}
