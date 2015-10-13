using System.Reflection;
using Abp.Modules;

namespace Yufu.Notify
{
    [DependsOn(typeof(NotifyCoreModule))]
    public class NotifyApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
