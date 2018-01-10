namespace GBTC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForEventsAndTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Organiser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Events", "Type_Id", "dbo.Types");
            DropIndex("dbo.Events", new[] { "Organiser_Id" });
            DropIndex("dbo.Events", new[] { "Type_Id" });
            AlterColumn("dbo.Events", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Events", "Organiser_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Events", "Type_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Types", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Events", "Organiser_Id");
            CreateIndex("dbo.Events", "Type_Id");
            AddForeignKey("dbo.Events", "Organiser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Events", "Type_Id", "dbo.Types", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Events", "Organiser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Type_Id" });
            DropIndex("dbo.Events", new[] { "Organiser_Id" });
            AlterColumn("dbo.Types", "Name", c => c.String());
            AlterColumn("dbo.Events", "Type_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Events", "Organiser_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Events", "Venue", c => c.String());
            CreateIndex("dbo.Events", "Type_Id");
            CreateIndex("dbo.Events", "Organiser_Id");
            AddForeignKey("dbo.Events", "Type_Id", "dbo.Types", "Id");
            AddForeignKey("dbo.Events", "Organiser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
