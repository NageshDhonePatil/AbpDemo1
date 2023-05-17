using System;
using System.Collections.Generic;
using System.Text;
using AbpDemo1.Localization;
using Volo.Abp.Application.Services;

namespace AbpDemo1;

/* Inherit your application services from this class.
 */
public abstract class AbpDemo1AppService : ApplicationService
{
    protected AbpDemo1AppService()
    {
        LocalizationResource = typeof(AbpDemo1Resource);
    }
}
