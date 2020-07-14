namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FIXDATE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.YearListOfEvents", "DescriptionEvent", c => c.String());
            AddColumn("dbo.YearListOfEvents", "DateEvent", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.YearListOfEvents", "DateEvent");
            DropColumn("dbo.YearListOfEvents", "DescriptionEvent");
        }
    }
}
