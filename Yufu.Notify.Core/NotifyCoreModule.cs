using System.Reflection;
using Abp.Modules;

namespace Yufu.Notify
{
    public class NotifyCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
