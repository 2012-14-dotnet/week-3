using System;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace PizzaWorld.DemoClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Host.CreateDefaultBuilder().ConfigureWebHostDefaults(
        webHost => webHost.Configure(
          webBuilder =>
          {
            webBuilder.UseRouting();
            webBuilder.UseEndpoints(
              endpoints =>
              {
                endpoints.MapGet("/", async ctx =>
                {
                  await ctx.Response.WriteAsync("<h1>hello content</h1>");
                });

                endpoints.MapGet("/index", async ctx =>
                {
                  await ctx.Response.SendFileAsync("index.html");
                });
              }
            );
          }
        )
      ).Build().Run();
    }
  }
}
