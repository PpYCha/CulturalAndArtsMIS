namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Fixxxxxxx : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ExternalRequests", "denied_Reason", c => c.String());
        }

        public override void Down()
        {
            AlterColumn("dbo.ExternalRequests", "denied_Reason", c => c.Boolean());
        }
    }
}
