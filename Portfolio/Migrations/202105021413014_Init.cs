namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Education",
                c => new
                    {
                        EducationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Major = c.String(),
                        From = c.String(),
                        To = c.String(),
                        Present = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EducationId);
            
            CreateTable(
                "dbo.EducationToPerson",
                c => new
                    {
                        EducationId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EducationId, t.PersonId })
                .ForeignKey("dbo.Education", t => t.EducationId, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.EducationId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Hobby",
                c => new
                    {
                        HobbyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.HobbyId);
            
            CreateTable(
                "dbo.HobbyToPerson",
                c => new
                    {
                        HobbyId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HobbyId, t.PersonId })
                .ForeignKey("dbo.Hobby", t => t.HobbyId, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.HobbyId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        ControllerAction = c.String(),
                        ControllerName = c.String(),
                        Reference = c.String(),
                        Name = c.String(),
                        Blank = c.String(),
                    })
                .PrimaryKey(t => t.MenuId);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Objectives = c.String(),
                        Date = c.DateTime(nullable: false),
                        Hidden = c.Boolean(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NoteId)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lastname = c.String(),
                        GeneralInfo = c.String(),
                        Picture = c.String(),
                        Logged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Technology",
                c => new
                    {
                        TechnologyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Purpose = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TechnologyId)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Technology", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Note", "PersonId", "dbo.Person");
            DropForeignKey("dbo.HobbyToPerson", "PersonId", "dbo.Person");
            DropForeignKey("dbo.EducationToPerson", "PersonId", "dbo.Person");
            DropForeignKey("dbo.HobbyToPerson", "HobbyId", "dbo.Hobby");
            DropForeignKey("dbo.EducationToPerson", "EducationId", "dbo.Education");
            DropIndex("dbo.Technology", new[] { "PersonId" });
            DropIndex("dbo.Note", new[] { "PersonId" });
            DropIndex("dbo.HobbyToPerson", new[] { "PersonId" });
            DropIndex("dbo.HobbyToPerson", new[] { "HobbyId" });
            DropIndex("dbo.EducationToPerson", new[] { "PersonId" });
            DropIndex("dbo.EducationToPerson", new[] { "EducationId" });
            DropTable("dbo.Technology");
            DropTable("dbo.Person");
            DropTable("dbo.Note");
            DropTable("dbo.Menu");
            DropTable("dbo.HobbyToPerson");
            DropTable("dbo.Hobby");
            DropTable("dbo.EducationToPerson");
            DropTable("dbo.Education");
        }
    }
}
