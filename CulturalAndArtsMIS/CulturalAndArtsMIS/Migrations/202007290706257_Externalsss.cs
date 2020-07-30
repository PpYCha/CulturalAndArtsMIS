namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Externalsss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExternalRequests", "granted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ExternalRequests", "denied", c => c.Boolean(nullable: false));
            AddColumn("dbo.ExternalRequests", "denied_Reason", c => c.Boolean(nullable: false));
            AddColumn("dbo.ExternalRequests", "notedBy", c => c.String());
            AddColumn("dbo.ExternalRequests", "ApprovedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExternalRequests", "ApprovedBy");
            DropColumn("dbo.ExternalRequests", "notedBy");
            DropColumn("dbo.ExternalRequests", "denied_Reason");
            DropColumn("dbo.ExternalRequests", "denied");
            DropColumn("dbo.ExternalRequests", "granted");
        }
    }
}
