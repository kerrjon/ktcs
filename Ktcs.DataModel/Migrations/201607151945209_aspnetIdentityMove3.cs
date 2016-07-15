namespace Ktcs.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aspnetIdentityMove3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.IdentityUsers", newName: "ApplicationUsers");
            RenameColumn(table: "dbo.IdentityUserClaims", name: "IdentityUser_Id", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.IdentityUserLogins", name: "IdentityUser_Id", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.IdentityUserRoles", name: "IdentityUser_Id", newName: "ApplicationUser_Id");
            RenameIndex(table: "dbo.IdentityUserRoles", name: "IX_IdentityUser_Id", newName: "IX_ApplicationUser_Id");
            RenameIndex(table: "dbo.IdentityUserClaims", name: "IX_IdentityUser_Id", newName: "IX_ApplicationUser_Id");
            RenameIndex(table: "dbo.IdentityUserLogins", name: "IX_IdentityUser_Id", newName: "IX_ApplicationUser_Id");
            DropColumn("dbo.ApplicationUsers", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApplicationUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            RenameIndex(table: "dbo.IdentityUserLogins", name: "IX_ApplicationUser_Id", newName: "IX_IdentityUser_Id");
            RenameIndex(table: "dbo.IdentityUserClaims", name: "IX_ApplicationUser_Id", newName: "IX_IdentityUser_Id");
            RenameIndex(table: "dbo.IdentityUserRoles", name: "IX_ApplicationUser_Id", newName: "IX_IdentityUser_Id");
            RenameColumn(table: "dbo.IdentityUserRoles", name: "ApplicationUser_Id", newName: "IdentityUser_Id");
            RenameColumn(table: "dbo.IdentityUserLogins", name: "ApplicationUser_Id", newName: "IdentityUser_Id");
            RenameColumn(table: "dbo.IdentityUserClaims", name: "ApplicationUser_Id", newName: "IdentityUser_Id");
            RenameTable(name: "dbo.ApplicationUsers", newName: "IdentityUsers");
        }
    }
}
