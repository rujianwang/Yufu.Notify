namespace Yufu.Notify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20151027 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NotifyAppQueues", "QueueStatusMsg", c => c.String(maxLength: 50));
            AlterColumn("dbo.NotifyAppQueues", "Platforms", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NotifyAppQueues", "Platforms", c => c.String());
            DropColumn("dbo.NotifyAppQueues", "QueueStatusMsg");
        }
    }
}
