using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace AbpDemo1;

public class AbpDemo1WebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<AbpDemo1WebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
