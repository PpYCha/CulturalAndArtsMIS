namespace CulturalAndArtsMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStudentProfile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentProfiles",
                c => new
                    {
                        studentProfile_ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NickName = c.String(),
                        Course = c.String(),
                        Year = c.String(),
                        CellphoneNo = c.String(),
                        EmailAddress = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        HomeAddress = c.String(),
                        CampusAddress = c.String(),
                        HavePerformed = c.Boolean(nullable: false),
                        HaveTrainings = c.Boolean(nullable: false),
                        HaveExperience = c.Boolean(nullable: false),
                        CanAttend = c.Boolean(nullable: false),
                        Commuter = c.Boolean(nullable: false),
                        Skills = c.String(),
                        Finance = c.String(),
                        FolkDance = c.Boolean(nullable: false),
                        HipHop = c.Boolean(nullable: false),
                        Contemporary = c.Boolean(nullable: false),
                        Theater = c.Boolean(nullable: false),
                        LiteraryArts = c.Boolean(nullable: false),
                        RadioTalents = c.Boolean(nullable: false),
                        ManagementTechnical = c.Boolean(nullable: false),
                        Chorale = c.Boolean(nullable: false),
                        LiveBand = c.Boolean(nullable: false),
                        RondallaBand = c.Boolean(nullable: false),
                        PaintingDrawing = c.Boolean(nullable: false),
                        MakeUp = c.Boolean(nullable: false),
                        Photography = c.Boolean(nullable: false),
                        Multimedia = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.studentProfile_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentProfiles");
        }
    }
}
