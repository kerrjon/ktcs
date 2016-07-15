namespace Ktcs.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aspnetIdentityMove2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserRole", newName: "AspNetRoles");
            RenameTable(name: "dbo.User", newName: "AspNetUsers");
            RenameTable(name: "dbo.UserClaim", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.UserLogin", newName: "AspNetUserLogins");
            AlterColumn("dbo.AspNetUsers", "PasswordHash", c => c.String());
            AlterColumn("dbo.AspNetUsers", "SecurityStamp", c => c.String());
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String());
            AlterColumn("dbo.AspNetUserClaims", "ClaimType", c => c.String());
            AlterColumn("dbo.AspNetUserClaims", "ClaimValue", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUserClaims", "ClaimValue", c => c.String(maxLength: 500));
            AlterColumn("dbo.AspNetUserClaims", "ClaimType", c => c.String(maxLength: 150));
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(maxLength: 50));
            AlterColumn("dbo.AspNetUsers", "SecurityStamp", c => c.String(maxLength: 500));
            AlterColumn("dbo.AspNetUsers", "PasswordHash", c => c.String(maxLength: 500));
            RenameTable(name: "dbo.AspNetUserLogins", newName: "UserLogin");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "UserClaim");
            RenameTable(name: "dbo.AspNetUsers", newName: "User");
            RenameTable(name: "dbo.AspNetRoles", newName: "UserRole");
        }
    }
}
