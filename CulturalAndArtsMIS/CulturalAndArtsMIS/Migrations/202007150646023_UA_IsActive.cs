namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UA_IsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccounts", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserAccounts", "IsActive");
        }
    }
}
