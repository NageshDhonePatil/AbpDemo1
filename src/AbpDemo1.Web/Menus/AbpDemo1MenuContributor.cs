using System.Threading.Tasks;
using AbpDemo1.Localization;
using AbpDemo1.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace AbpDemo1.Web.Menus;

public class AbpDemo1MenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<AbpDemo1Resource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                AbpDemo1Menus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );


        context.Menu.AddItem(
    new ApplicationMenuItem(
        "AbpDemo1",
        l["Menu:EmployeeStore"],
        icon: "fa fa-book"
    ).AddItem(
        new ApplicationMenuItem(
            "AbpDemo1.Employees",
            l["Menu:Employees"],
            url: "/Employees"
        )
    )
);




        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;


    }
}
