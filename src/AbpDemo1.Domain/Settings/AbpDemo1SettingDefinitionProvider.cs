using Volo.Abp.Settings;

namespace AbpDemo1.Settings;

public class AbpDemo1SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpDemo1Settings.MySetting1));
    }
}
