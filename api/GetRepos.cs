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
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "repos")] HttpRequest req,
        ILogger log)
    {
      log.LogInformation("C# HTTP trigger function processed a request.");

      var repos = new List<Repo>();
      repos.Add(new Repo() { Name = "Static Web Apps", Url = "https://github.com/Azure/static-web-apps", Notes = "Official repo for Static Web Apps" });
      repos.Add(new Repo() { Name = "Azure Functions", Url = "https://github.com/Azure/Azure-Functions", Notes = "Official repo for Azure Functions" });
      repos.Add(new Repo() { Name = "VS Code", Url = "https://github.com/microsoft/vscode", Notes = "Official repo for Visual Studio Code" });
      repos.Add(new Repo() { Name = "VS Code Remote Development", Url = "https://github.com/microsoft/vscode-remote-release", Notes = "Official repo for VS Code Remote development extensions" });
      repos.Add(new Repo() { Name = "VS Code Docker Extension", Url = "https://github.com/microsoft/vscode-docker", Notes = "Official repo for VS Code Docker extension" });
      repos.Add(new Repo() { Name = ".NET", Url = "https://github.com/microsoft/dotnet", Notes = "Official repo for .NET" });

      string responseMessage = JsonConvert.SerializeObject(repos);

      return new OkObjectResult(responseMessage);
    }
  }
}
