using Volo.Abp.Modularity;

namespace AbpDemo1;

[DependsOn(
    typeof(AbpDemo1ApplicationModule),
    typeof(AbpDemo1DomainTestModule)
    )]
public class AbpDemo1ApplicationTestModule : AbpModule
{

}
