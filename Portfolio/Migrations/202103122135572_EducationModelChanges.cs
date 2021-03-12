namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EducationModelChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EducationToPerson", "Education_EducationId", "dbo.Education");
            DropIndex("dbo.EducationToPerson", new[] { "Education_EducationId" });
            RenameColumn(table: "dbo.EducationToPerson", name: "Education_EducationId", newName: "EducationId");
            DropPrimaryKey("dbo.EducationToPerson");
            AlterColumn("dbo.EducationToPerson", "EducationId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.EducationToPerson", new[] { "EducationId", "PersonId" });
            CreateIndex("dbo.EducationToPerson", "EducationId");
            AddForeignKey("dbo.EducationToPerson", "EducationId", "dbo.Education", "EducationId", cascadeDelete: true);
            DropColumn("dbo.EducationToPerson", "SchoolId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EducationToPerson", "SchoolId", c => c.Int(nullable: false));
            DropForeignKey("dbo.EducationToPerson", "EducationId", "dbo.Education");
            DropIndex("dbo.EducationToPerson", new[] { "EducationId" });
            DropPrimaryKey("dbo.EducationToPerson");
            AlterColumn("dbo.EducationToPerson", "EducationId", c => c.Int());
            AddPrimaryKey("dbo.EducationToPerson", new[] { "SchoolId", "PersonId" });
            RenameColumn(table: "dbo.EducationToPerson", name: "EducationId", newName: "Education_EducationId");
            CreateIndex("dbo.EducationToPerson", "Education_EducationId");
            AddForeignKey("dbo.EducationToPerson", "Education_EducationId", "dbo.Education", "EducationId");
        }
    }
}
