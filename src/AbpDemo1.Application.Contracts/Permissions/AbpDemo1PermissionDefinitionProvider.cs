using AbpDemo1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpDemo1.Permissions;

public class AbpDemo1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpDemo1Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpDemo1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpDemo1Resource>(name);
    }
}
