using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpDemo1.Web;

[Dependency(ReplaceServices = true)]
public class AbpDemo1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpDemo1";
}
