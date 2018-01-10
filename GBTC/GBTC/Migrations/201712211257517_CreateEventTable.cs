namespace GBTC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEventTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Organiser_Id = c.String(maxLength: 128),
                        Type_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Organiser_Id)
                .ForeignKey("dbo.Types", t => t.Type_Id)
                .Index(t => t.Organiser_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Events", "Organiser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Type_Id" });
            DropIndex("dbo.Events", new[] { "Organiser_Id" });
            DropTable("dbo.Types");
            DropTable("dbo.Events");
        }
    }
}
