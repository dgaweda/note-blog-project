namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class NewModelsAndSeedDataUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Blank", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Menus", "Blank");
        }
    }
}
