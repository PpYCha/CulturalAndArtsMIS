namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Settingsss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        setting_ID = c.Int(nullable: false, identity: true),
                        ApproveBy = c.String(),
                        NotedBy = c.String(),
                    })
                .PrimaryKey(t => t.setting_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Settings");
        }
    }
}
