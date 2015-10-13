using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Yufu.Notify.EntityFramework;

namespace Yufu.Notify
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(NotifyCoreModule))]
    public class NotifyDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<NotifyDbContext>(null);
        }
    }
}
