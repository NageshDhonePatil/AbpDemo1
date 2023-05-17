using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpDemo1.Data;
using Volo.Abp.DependencyInjection;

namespace AbpDemo1.EntityFrameworkCore;

public class EntityFrameworkCoreAbpDemo1DbSchemaMigrator
    : IAbpDemo1DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpDemo1DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpDemo1DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpDemo1DbContext>()
            .Database
            .MigrateAsync();
    }
}
