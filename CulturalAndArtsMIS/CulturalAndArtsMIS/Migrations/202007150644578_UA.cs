namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        ua_ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ua_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAccounts");
        }
    }
}
