using System.Data.Entity;
using Abp.EntityFramework;
using Yufu.Notify.Entities;

namespace Yufu.Notify.EntityFramework
{
    public class NotifyDbContext : AbpDbContext
    {
        public virtual IDbSet<NotifyApplication> Applications { get; set; }
        public virtual IDbSet<NotifyAppConfig> NotifyAppConfigs { get; set; }
        public virtual IDbSet<NotifyEmailConfig> NotifyEmailConfigs { get; set; }
        public virtual IDbSet<NotifyMobileConfig> NotifyMobileConfigs { get; set; }
        public virtual IDbSet<NotifyWeChatConfig> NotifyWeChatConfigs { get; set; }

        public virtual IDbSet<NotifyAppQueue> NotifyAppQueues { get; set; }
        public virtual IDbSet<NotifyEmailQueue> NotifyEmailQueues { get; set; }
        public virtual IDbSet<NotifyMobileQueue> NotifyMobileQueues { get; set; }
        public virtual IDbSet<NotifyWeChatQueue> NotifyWeChatQueues { get; set; }


        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public NotifyDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in NotifyDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of NotifyDbContext since ABP automatically handles it.
         */
        public NotifyDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
