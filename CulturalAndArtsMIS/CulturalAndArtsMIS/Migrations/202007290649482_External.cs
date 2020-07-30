namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class External : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExternalRequests",
                c => new
                    {
                        er_ID = c.Int(nullable: false, identity: true),
                        partyOrganization = c.String(),
                        contactPerson = c.String(),
                        contactNo = c.String(),
                        titleOfEvent = c.String(),
                        dateOfEvent = c.DateTime(),
                        timeOfEvent = c.String(),
                        venueOfEvent = c.String(),
                        pd_Solo = c.Boolean(nullable: false),
                        pd_Duet = c.Boolean(nullable: false),
                        pd_Chorale = c.Boolean(nullable: false),
                        pd_RondallaBand = c.Boolean(nullable: false),
                        pd_FolkDance = c.Boolean(nullable: false),
                        pd_HipHop = c.Boolean(nullable: false),
                        pd_Contemporary = c.Boolean(nullable: false),
                        pd_DanceSports = c.Boolean(nullable: false),
                        noOfPerformance = c.String(),
                        noOfPerformer = c.String(),
                        bitaw = c.Boolean(nullable: false),
                        specify = c.String(),
                    })
                .PrimaryKey(t => t.er_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExternalRequests");
        }
    }
}
