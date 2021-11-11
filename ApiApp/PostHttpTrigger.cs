using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using AppModels;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

namespace ApiApp
{
    public static class PostHttpTrigger
    {
        private const string GetPosts = "https://public-api.wordpress.com/rest/v1.1/sites/{0}/posts";
        private static HttpClient http = new HttpClient();
        
        [FunctionName("PostHttpTrigger")]
        [OpenApiOperation(operationId: "posts.get", tags: new[] { "posts" })]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(PostCollection), Description = "The OK response")]
        public static async Task<IActionResult> GetPostsAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "posts")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var requestUri = new Uri(string.Format(GetPosts, Environment.GetEnvironmentVariable("SITE__NAME")));

            var json = await http.GetStringAsync(requestUri).ConfigureAwait(false);
            var posts = JsonConvert.DeserializeObject<PostCollection>(json);

            return new OkObjectResult(posts);
        }
    }
}
