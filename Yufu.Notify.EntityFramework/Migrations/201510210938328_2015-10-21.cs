namespace Yufu.Notify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20151021 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NotifyWeChatConfigs", "AppId", c => c.String(maxLength: 50));
            AddColumn("dbo.NotifyWeChatConfigs", "Appsecret", c => c.String(maxLength: 64));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NotifyWeChatConfigs", "Appsecret");
            DropColumn("dbo.NotifyWeChatConfigs", "AppId");
        }
    }
}
