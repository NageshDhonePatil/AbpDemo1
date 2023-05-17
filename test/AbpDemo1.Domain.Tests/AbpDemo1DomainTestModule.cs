using AbpDemo1.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpDemo1;

[DependsOn(
    typeof(AbpDemo1EntityFrameworkCoreTestModule)
    )]
public class AbpDemo1DomainTestModule : AbpModule
{

}
