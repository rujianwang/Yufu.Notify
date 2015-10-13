using Abp.Collections;
using Abp.Modules;
using Abp.TestBase;

namespace Yufu.Notify.Tests
{
  public class YufuTestBase : AbpIntegratedTestBase
  {
    protected override void AddModules(ITypeList<AbpModule> modules)
    {
      base.AddModules(modules);
      modules.Add<NotifyApplicationModule>();
      modules.Add<NotifyCoreModule>();
      modules.Add<NotifyDataModule>();
    }
  }
}