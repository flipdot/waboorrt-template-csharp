using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Wabooorrt;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddJsonRpc(config =>
        {
            config.JsonSerializerSettings = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
        });

        services.AddSingleton<IBotLogic, RandomBotLogic>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseJsonRpc();
    }
}
