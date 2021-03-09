namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSeedDataInitilizer : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Articles", newName: "Article");
            RenameTable(name: "dbo.Menus", newName: "Menu");
            RenameTable(name: "dbo.Educations", newName: "Education");
            RenameTable(name: "dbo.People", newName: "Person");
            RenameTable(name: "dbo.Hobbies", newName: "Hobby");
            RenameTable(name: "dbo.Notes", newName: "Note");
            RenameTable(name: "dbo.Technologies", newName: "Technology");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Technology", newName: "Technologies");
            RenameTable(name: "dbo.Note", newName: "Notes");
            RenameTable(name: "dbo.Hobby", newName: "Hobbies");
            RenameTable(name: "dbo.Person", newName: "People");
            RenameTable(name: "dbo.Education", newName: "Educations");
            RenameTable(name: "dbo.Menu", newName: "Menus");
            RenameTable(name: "dbo.Article", newName: "Articles");
        }
    }
}
