namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HobbyPerson", "Hobby_HobbyId", "dbo.Hobby");
            DropForeignKey("dbo.HobbyPerson", "Person_PersonId", "dbo.Person");
            DropIndex("dbo.HobbyPerson", new[] { "Hobby_HobbyId" });
            DropIndex("dbo.HobbyPerson", new[] { "Person_PersonId" });
            RenameColumn(table: "dbo.EducationToPerson", name: "School_EducationId", newName: "Education_EducationId");
            RenameIndex(table: "dbo.EducationToPerson", name: "IX_School_EducationId", newName: "IX_Education_EducationId");
            DropTable("dbo.HobbyPerson");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.HobbyPerson",
                c => new
                    {
                        Hobby_HobbyId = c.Int(nullable: false),
                        Person_PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hobby_HobbyId, t.Person_PersonId });
            
            RenameIndex(table: "dbo.EducationToPerson", name: "IX_Education_EducationId", newName: "IX_School_EducationId");
            RenameColumn(table: "dbo.EducationToPerson", name: "Education_EducationId", newName: "School_EducationId");
            CreateIndex("dbo.HobbyPerson", "Person_PersonId");
            CreateIndex("dbo.HobbyPerson", "Hobby_HobbyId");
            AddForeignKey("dbo.HobbyPerson", "Person_PersonId", "dbo.Person", "PersonId", cascadeDelete: true);
            AddForeignKey("dbo.HobbyPerson", "Hobby_HobbyId", "dbo.Hobby", "HobbyId", cascadeDelete: true);
        }
    }
}
