namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixxxssssxsx : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InternalRequests",
                c => new
                    {
                        ir_ID = c.Int(nullable: false, identity: true),
                        date_Internal = c.DateTime(),
                        pary = c.String(),
                        officeCollegeOrganization = c.String(),
                        titleOfTheActivity = c.String(),
                        conferenceSeminar = c.Boolean(),
                        recognitionRites = c.Boolean(),
                        generalAssembly = c.Boolean(),
                        program = c.Boolean(),
                        others = c.Boolean(),
                        specify = c.String(),
                        pd_SoloDuet = c.Boolean(),
                        pd_LiveBand = c.Boolean(),
                        pd_Chorale = c.Boolean(),
                        pd_Rondalla = c.Boolean(),
                        pd_FolkDance = c.Boolean(),
                        pd_HipHop = c.Boolean(),
                        pd_DanceSports = c.Boolean(),
                        pd_Contemporary = c.Boolean(),
                        numberOfPerformance = c.String(),
                        numberOfPerformer = c.String(),
                        venueOfTheActivity = c.String(),
                        dateOfTheActivity = c.DateTime(),
                        timeOfTheActivity = c.String(),
                    })
                .PrimaryKey(t => t.ir_ID);
            
            AddColumn("dbo.ExternalRequests", "ExternalInternal", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExternalRequests", "ExternalInternal");
            DropTable("dbo.InternalRequests");
        }
    }
}
