namespace Yufu.Notify.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotifyApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyApplication_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotifyAppConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotifyApplicationId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyAppConfig_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotifyAppQueues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotifyApplicationId = c.Int(nullable: false),
                        Authtoken = c.String(maxLength: 100),
                        Email = c.String(maxLength: 255),
                        AppId = c.String(maxLength: 50),
                        Platforms = c.String(),
                        List = c.String(),
                        Title = c.String(maxLength: 500),
                        Body = c.String(maxLength: 1000),
                        QueueStatus = c.Int(nullable: false),
                        QueueStatusCode = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyAppQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotifyEmailConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotifyApplicationId = c.Int(nullable: false),
                        Smtp = c.String(maxLength: 100),
                        Email = c.String(maxLength: 255),
                        Password = c.String(maxLength: 150),
                        SendUserName = c.String(maxLength: 150),
                        Port = c.Int(nullable: false),
                        EnableSsl = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyEmailConfig_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotifyEmailQueues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyEmailQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotifyMobileConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotifyApplicationId = c.Int(nullable: false),
                        MobileProvide = c.Byte(nullable: false),
                        Url = c.String(maxLength: 255),
                        UserName = c.String(maxLength: 100),
                        Password = c.String(maxLength: 200),
                        RequestHeadersIdKey = c.String(maxLength: 100),
                        RequestHeadersIdValue = c.String(maxLength: 150),
                        RequestHeadersKeyName = c.String(maxLength: 100),
                        RequestHeadersKeyValue = c.String(maxLength: 150),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyMobileConfig_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotifyMobileQueues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyMobileQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotifyWeChatConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotifyApplicationId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyWeChatConfig_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotifyWeChatQueues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotifyApplicationId = c.Int(nullable: false),
                        OpenId = c.String(maxLength: 100),
                        TemplateId = c.String(maxLength: 100),
                        TopColor = c.String(maxLength: 50),
                        Url = c.String(maxLength: 255),
                        Body = c.String(),
                        QueueStatus = c.Int(nullable: false),
                        QueueStatusCode = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyWeChatQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NotifyWeChatQueues",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyWeChatQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.NotifyWeChatConfigs",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyWeChatConfig_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.NotifyMobileQueues",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyMobileQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.NotifyMobileConfigs",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyMobileConfig_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.NotifyEmailQueues",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyEmailQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.NotifyEmailConfigs",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyEmailConfig_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.NotifyAppQueues",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyAppQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.NotifyAppConfigs",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyAppConfig_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.NotifyApplications",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_NotifyApplication_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
