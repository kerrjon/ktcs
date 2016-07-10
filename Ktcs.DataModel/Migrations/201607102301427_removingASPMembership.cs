namespace Ktcs.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingASPMembership : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.aspnet_Membership", "UserId", "dbo.aspnet_Users");
            DropForeignKey("dbo.aspnet_PersonalizationAllUsers", "PathId", "dbo.aspnet_Paths");
            DropForeignKey("dbo.aspnet_PersonalizationPerUser", "PathId", "dbo.aspnet_Paths");
            DropForeignKey("dbo.aspnet_PersonalizationPerUser", "UserId", "dbo.aspnet_Users");
            DropForeignKey("dbo.aspnet_Profile", "UserId", "dbo.aspnet_Users");
            DropForeignKey("dbo.aspnet_UsersInRoles", "RoleId", "dbo.aspnet_Roles");
            DropForeignKey("dbo.aspnet_UsersInRoles", "UserId", "dbo.aspnet_Users");
            DropForeignKey("dbo.aspnet_Membership", "ApplicationId", "dbo.aspnet_Applications");
            DropForeignKey("dbo.aspnet_Paths", "ApplicationId", "dbo.aspnet_Applications");
            DropForeignKey("dbo.aspnet_Roles", "ApplicationId", "dbo.aspnet_Applications");
            DropForeignKey("dbo.aspnet_Users", "ApplicationId", "dbo.aspnet_Applications");
            DropIndex("dbo.aspnet_Membership", new[] { "UserId" });
            DropIndex("dbo.aspnet_Membership", new[] { "ApplicationId" });
            DropIndex("dbo.aspnet_Users", new[] { "ApplicationId" });
            DropIndex("dbo.aspnet_PersonalizationPerUser", new[] { "PathId" });
            DropIndex("dbo.aspnet_PersonalizationPerUser", new[] { "UserId" });
            DropIndex("dbo.aspnet_Paths", new[] { "ApplicationId" });
            DropIndex("dbo.aspnet_PersonalizationAllUsers", new[] { "PathId" });
            DropIndex("dbo.aspnet_Profile", new[] { "UserId" });
            DropIndex("dbo.aspnet_Roles", new[] { "ApplicationId" });
            DropIndex("dbo.aspnet_UsersInRoles", new[] { "RoleId" });
            DropIndex("dbo.aspnet_UsersInRoles", new[] { "UserId" });
            DropTable("dbo.aspnet_Applications");
            DropTable("dbo.aspnet_Membership");
            DropTable("dbo.aspnet_Users");
            DropTable("dbo.aspnet_PersonalizationPerUser");
            DropTable("dbo.aspnet_Paths");
            DropTable("dbo.aspnet_PersonalizationAllUsers");
            DropTable("dbo.aspnet_Profile");
            DropTable("dbo.aspnet_Roles");
            DropTable("dbo.aspnet_SchemaVersions");
            DropTable("dbo.aspnet_WebEvent_Events");
            DropTable("dbo.aspnet_UsersInRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.aspnet_UsersInRoles",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId });
            
            CreateTable(
                "dbo.aspnet_WebEvent_Events",
                c => new
                    {
                        EventId = c.String(nullable: false, maxLength: 32, fixedLength: true, unicode: false),
                        EventTimeUtc = c.DateTime(nullable: false),
                        EventTime = c.DateTime(nullable: false),
                        EventType = c.String(nullable: false, maxLength: 256),
                        EventSequence = c.Decimal(nullable: false, precision: 19, scale: 0),
                        EventOccurrence = c.Decimal(nullable: false, precision: 19, scale: 0),
                        EventCode = c.Int(nullable: false),
                        EventDetailCode = c.Int(nullable: false),
                        Message = c.String(maxLength: 1024),
                        ApplicationPath = c.String(maxLength: 256),
                        ApplicationVirtualPath = c.String(maxLength: 256),
                        MachineName = c.String(nullable: false, maxLength: 256),
                        RequestUrl = c.String(maxLength: 1024),
                        ExceptionType = c.String(maxLength: 256),
                        Details = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.aspnet_SchemaVersions",
                c => new
                    {
                        Feature = c.String(nullable: false, maxLength: 128),
                        CompatibleSchemaVersion = c.String(nullable: false, maxLength: 128),
                        IsCurrentVersion = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.Feature, t.CompatibleSchemaVersion });
            
            CreateTable(
                "dbo.aspnet_Roles",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        ApplicationId = c.Guid(nullable: false),
                        RoleName = c.String(nullable: false, maxLength: 256),
                        LoweredRoleName = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.aspnet_Profile",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        PropertyNames = c.String(nullable: false, storeType: "ntext"),
                        PropertyValuesString = c.String(nullable: false, storeType: "ntext"),
                        PropertyValuesBinary = c.Binary(nullable: false, storeType: "image"),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.aspnet_PersonalizationAllUsers",
                c => new
                    {
                        PathId = c.Guid(nullable: false),
                        PageSettings = c.Binary(nullable: false, storeType: "image"),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PathId);
            
            CreateTable(
                "dbo.aspnet_Paths",
                c => new
                    {
                        PathId = c.Guid(nullable: false),
                        ApplicationId = c.Guid(nullable: false),
                        Path = c.String(nullable: false, maxLength: 256),
                        LoweredPath = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.PathId);
            
            CreateTable(
                "dbo.aspnet_PersonalizationPerUser",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PathId = c.Guid(),
                        UserId = c.Guid(),
                        PageSettings = c.Binary(nullable: false, storeType: "image"),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.aspnet_Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        ApplicationId = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        LoweredUserName = c.String(nullable: false, maxLength: 256),
                        MobileAlias = c.String(maxLength: 16),
                        IsAnonymous = c.Boolean(nullable: false),
                        LastActivityDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.aspnet_Membership",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        ApplicationId = c.Guid(nullable: false),
                        Password = c.String(nullable: false, maxLength: 128),
                        PasswordFormat = c.Int(nullable: false),
                        PasswordSalt = c.String(nullable: false, maxLength: 128),
                        MobilePIN = c.String(maxLength: 16),
                        Email = c.String(maxLength: 256),
                        LoweredEmail = c.String(maxLength: 256),
                        PasswordQuestion = c.String(maxLength: 256),
                        PasswordAnswer = c.String(maxLength: 128),
                        IsApproved = c.Boolean(nullable: false),
                        IsLockedOut = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        LastPasswordChangedDate = c.DateTime(nullable: false),
                        LastLockoutDate = c.DateTime(nullable: false),
                        FailedPasswordAttemptCount = c.Int(nullable: false),
                        FailedPasswordAttemptWindowStart = c.DateTime(nullable: false),
                        FailedPasswordAnswerAttemptCount = c.Int(nullable: false),
                        FailedPasswordAnswerAttemptWindowStart = c.DateTime(nullable: false),
                        Comment = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.aspnet_Applications",
                c => new
                    {
                        ApplicationId = c.Guid(nullable: false),
                        ApplicationName = c.String(nullable: false, maxLength: 256),
                        LoweredApplicationName = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
            CreateIndex("dbo.aspnet_UsersInRoles", "UserId");
            CreateIndex("dbo.aspnet_UsersInRoles", "RoleId");
            CreateIndex("dbo.aspnet_Roles", "ApplicationId");
            CreateIndex("dbo.aspnet_Profile", "UserId");
            CreateIndex("dbo.aspnet_PersonalizationAllUsers", "PathId");
            CreateIndex("dbo.aspnet_Paths", "ApplicationId");
            CreateIndex("dbo.aspnet_PersonalizationPerUser", "UserId");
            CreateIndex("dbo.aspnet_PersonalizationPerUser", "PathId");
            CreateIndex("dbo.aspnet_Users", "ApplicationId");
            CreateIndex("dbo.aspnet_Membership", "ApplicationId");
            CreateIndex("dbo.aspnet_Membership", "UserId");
            AddForeignKey("dbo.aspnet_Users", "ApplicationId", "dbo.aspnet_Applications", "ApplicationId");
            AddForeignKey("dbo.aspnet_Roles", "ApplicationId", "dbo.aspnet_Applications", "ApplicationId");
            AddForeignKey("dbo.aspnet_Paths", "ApplicationId", "dbo.aspnet_Applications", "ApplicationId");
            AddForeignKey("dbo.aspnet_Membership", "ApplicationId", "dbo.aspnet_Applications", "ApplicationId");
            AddForeignKey("dbo.aspnet_UsersInRoles", "UserId", "dbo.aspnet_Users", "UserId", cascadeDelete: true);
            AddForeignKey("dbo.aspnet_UsersInRoles", "RoleId", "dbo.aspnet_Roles", "RoleId", cascadeDelete: true);
            AddForeignKey("dbo.aspnet_Profile", "UserId", "dbo.aspnet_Users", "UserId");
            AddForeignKey("dbo.aspnet_PersonalizationPerUser", "UserId", "dbo.aspnet_Users", "UserId");
            AddForeignKey("dbo.aspnet_PersonalizationPerUser", "PathId", "dbo.aspnet_Paths", "PathId");
            AddForeignKey("dbo.aspnet_PersonalizationAllUsers", "PathId", "dbo.aspnet_Paths", "PathId");
            AddForeignKey("dbo.aspnet_Membership", "UserId", "dbo.aspnet_Users", "UserId");
        }
    }
}
