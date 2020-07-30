namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Externalsssss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ExternalRequests", "granted", c => c.Boolean());
            AlterColumn("dbo.ExternalRequests", "denied", c => c.Boolean());
            AlterColumn("dbo.ExternalRequests", "denied_Reason", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ExternalRequests", "denied_Reason", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ExternalRequests", "denied", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ExternalRequests", "granted", c => c.Boolean(nullable: false));
        }
    }
}
