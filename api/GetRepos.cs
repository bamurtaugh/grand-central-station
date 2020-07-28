using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using grand.central.shared;
using System.Collections.Generic;

namespace grand.central
{
  public static class GetRepos
  {
    [FunctionName("GetRepos")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
      log.LogInformation("C# HTTP trigger function processed a request.");

      var repos = new List<Repo>();
      repos.Add(new Repo() { Name = "Static Web Apps", Url = "https://github.com/Azure/static-web-apps", Notes = "Official repo for Static Web Apps" });

      string responseMessage = JsonConvert.SerializeObject(repos);

      return new OkObjectResult(responseMessage);
    }
  }
}
