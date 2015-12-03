using System.Configuration;
using Abp.Collections;
using Abp.Modules;
using Abp.TestBase;
using Senparc.Weixin.MP.CommonAPIs;

namespace Yufu.Notify.Tests
{
  public class YufuTestBase : AbpIntegratedTestBase
  {
    public YufuTestBase()
    {
    }

    protected override void AddModules(ITypeList<AbpModule> modules)
    {
      base.AddModules(modules);
      modules.Add<NotifyApplicationModule>();
      modules.Add<NotifyCoreModule>();
      modules.Add<NotifyDataModule>();
    }
  }
}