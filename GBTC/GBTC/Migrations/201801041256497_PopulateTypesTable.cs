namespace GBTC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Types(Id, Name) VALUES (1, 'Concert')");
            Sql("INSERT INTO Types(Id, Name) VALUES (2, 'Recreational')");
            Sql("INSERT INTO Types(Id, Name) VALUES (3, 'Fashion Show')");
            Sql("INSERT INTO Types(Id, Name) VALUES (4, 'Lifestyle')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Types WHERE Id IN (1, 2,  3, 4)");
        }
    }
}
