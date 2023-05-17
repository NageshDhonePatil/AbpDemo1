using AbpDemo1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpDemo1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpDemo1Controller : AbpControllerBase
{
    protected AbpDemo1Controller()
    {
        LocalizationResource = typeof(AbpDemo1Resource);
    }
}
