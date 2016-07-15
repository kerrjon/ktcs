namespace Ktcs.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingLogTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Thread = c.String(nullable: false, maxLength: 255),
                        Level = c.String(nullable: false, maxLength: 50),
                        Logger = c.String(nullable: false, maxLength: 255),
                        Message = c.String(nullable: false, maxLength: 4000),
                        Exception = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => new { t.Id, t.Date, t.Thread, t.Level, t.Logger, t.Message });
            
            AlterColumn("dbo.ClassRequest", "Withdrew", c => c.String(maxLength: 3, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClassRequest", "Withdrew", c => c.String(maxLength: 3));
            DropTable("dbo.Log");
        }
    }
}
