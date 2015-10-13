using System.Data.Entity.Migrations;

namespace Yufu.Notify.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Notify.EntityFramework.NotifyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Notify";
        }

        protected override void Seed(Notify.EntityFramework.NotifyDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
