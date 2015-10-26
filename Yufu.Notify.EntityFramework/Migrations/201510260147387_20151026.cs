namespace Yufu.Notify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20151026 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NotifyAppConfigs", "Authtoken", c => c.String(maxLength: 100));
            AddColumn("dbo.NotifyAppConfigs", "Email", c => c.String(maxLength: 255));
            AddColumn("dbo.NotifyAppConfigs", "AppId", c => c.String(maxLength: 50));
            AddColumn("dbo.NotifyAppQueues", "PushType", c => c.Byte(nullable: false));
            DropColumn("dbo.NotifyAppQueues", "Authtoken");
            DropColumn("dbo.NotifyAppQueues", "Email");
            DropColumn("dbo.NotifyAppQueues", "AppId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NotifyAppQueues", "AppId", c => c.String(maxLength: 50));
            AddColumn("dbo.NotifyAppQueues", "Email", c => c.String(maxLength: 255));
            AddColumn("dbo.NotifyAppQueues", "Authtoken", c => c.String(maxLength: 100));
            DropColumn("dbo.NotifyAppQueues", "PushType");
            DropColumn("dbo.NotifyAppConfigs", "AppId");
            DropColumn("dbo.NotifyAppConfigs", "Email");
            DropColumn("dbo.NotifyAppConfigs", "Authtoken");
        }
    }
}
