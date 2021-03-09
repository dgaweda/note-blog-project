namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedArticlesModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Article", "MenuId", "dbo.Menu");
            DropIndex("dbo.Article", new[] { "MenuId" });
            DropTable("dbo.Article");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Content = c.String(),
                        MenuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId);
            
            CreateIndex("dbo.Article", "MenuId");
            AddForeignKey("dbo.Article", "MenuId", "dbo.Menu", "MenuId", cascadeDelete: true);
        }
    }
}
