using AbpDemo1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpDemo1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpDemo1EntityFrameworkCoreModule),
    typeof(AbpDemo1ApplicationContractsModule)
    )]
public class AbpDemo1DbMigratorModule : AbpModule
{

}
