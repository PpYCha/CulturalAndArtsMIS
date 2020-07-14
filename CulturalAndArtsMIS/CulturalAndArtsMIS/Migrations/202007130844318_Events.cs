namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Events : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YearListOfEvents",
                c => new
                    {
                        yearListOfEvents_ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.yearListOfEvents_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YearListOfEvents");
        }
    }
}
