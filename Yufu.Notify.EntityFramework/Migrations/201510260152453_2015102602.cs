namespace Yufu.Notify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2015102602 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NotifyAppQueues", "AppId", c => c.String(maxLength: 50));
            DropColumn("dbo.NotifyAppConfigs", "AppId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NotifyAppConfigs", "AppId", c => c.String(maxLength: 50));
            DropColumn("dbo.NotifyAppQueues", "AppId");
        }
    }
}
