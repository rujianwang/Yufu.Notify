using System.Reflection;
using Abp.Modules;
using Yufu.Notify.Mapping;

namespace Yufu.Notify
{
  [DependsOn(typeof (NotifyCoreModule))]
  public class NotifyApplicationModule : AbpModule
  {
    public override void Initialize()
    {
      IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
      DtoMapper.Map();
    }
  }
}