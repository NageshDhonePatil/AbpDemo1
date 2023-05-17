using System.Threading.Tasks;

namespace AbpDemo1.Data;

public interface IAbpDemo1DbSchemaMigrator
{
    Task MigrateAsync();
}
