namespace Yufu.Notify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20151019 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NotifyWeChatQueues", "TopColor");
            DropColumn("dbo.NotifyWeChatQueues", "Url");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NotifyWeChatQueues", "Url", c => c.String(maxLength: 255));
            AddColumn("dbo.NotifyWeChatQueues", "TopColor", c => c.String(maxLength: 50));
        }
    }
}
