using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpDemo1.Data;

/* This is used if database provider does't define
 * IAbpDemo1DbSchemaMigrator implementation.
 */
public class NullAbpDemo1DbSchemaMigrator : IAbpDemo1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
