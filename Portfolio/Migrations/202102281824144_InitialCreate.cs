namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Content = c.String(),
                        MenuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        Reference = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.MenuId);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        EducationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Major = c.String(),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        Present = c.Boolean(nullable: false),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.EducationId)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.Person_PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lastname = c.String(),
                        EducationId = c.Int(nullable: false),
                        HobbyId = c.Int(nullable: false),
                        TechnologyId = c.Int(nullable: false),
                        GeneralInfo = c.String(),
                        NoteId = c.Int(nullable: false),
                        Logged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Hobbies",
                c => new
                    {
                        HobbyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.HobbyId)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.Person_PersonId);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Objectives = c.String(),
                        Date = c.DateTime(nullable: false),
                        Hidden = c.Boolean(nullable: false),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.NoteId)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.Person_PersonId);
            
            CreateTable(
                "dbo.Technologies",
                c => new
                    {
                        TechnologyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FromWhen = c.String(),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.TechnologyId)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.Person_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Technologies", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.Notes", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.Hobbies", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.Educations", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.Articles", "MenuPositionID", "dbo.Menus");
            DropIndex("dbo.Technologies", new[] { "Person_PersonId" });
            DropIndex("dbo.Notes", new[] { "Person_PersonId" });
            DropIndex("dbo.Hobbies", new[] { "Person_PersonId" });
            DropIndex("dbo.Educations", new[] { "Person_PersonId" });
            DropIndex("dbo.Articles", new[] { "MenuPositionID" });
            DropTable("dbo.Technologies");
            DropTable("dbo.Notes");
            DropTable("dbo.Hobbies");
            DropTable("dbo.People");
            DropTable("dbo.Educations");
            DropTable("dbo.Menus");
            DropTable("dbo.Articles");
        }
    }
}
