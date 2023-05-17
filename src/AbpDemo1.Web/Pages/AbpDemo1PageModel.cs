using AbpDemo1.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpDemo1.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AbpDemo1PageModel : AbpPageModel
{
    protected AbpDemo1PageModel()
    {
        LocalizationResourceType = typeof(AbpDemo1Resource);
    }
}
