namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HobbyChanges1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HobbyPerson",
                c => new
                    {
                        Hobby_HobbyId = c.Int(nullable: false),
                        Person_PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hobby_HobbyId, t.Person_PersonId })
                .ForeignKey("dbo.Hobby", t => t.Hobby_HobbyId, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.Person_PersonId, cascadeDelete: true)
                .Index(t => t.Hobby_HobbyId)
                .Index(t => t.Person_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HobbyPerson", "Person_PersonId", "dbo.Person");
            DropForeignKey("dbo.HobbyPerson", "Hobby_HobbyId", "dbo.Hobby");
            DropIndex("dbo.HobbyPerson", new[] { "Person_PersonId" });
            DropIndex("dbo.HobbyPerson", new[] { "Hobby_HobbyId" });
            DropTable("dbo.HobbyPerson");
        }
    }
}
