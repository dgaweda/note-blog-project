namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuModelChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menu", "ControllerAction", c => c.String());
            AddColumn("dbo.Menu", "ControllerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menu", "ControllerName");
            DropColumn("dbo.Menu", "ControllerAction");
        }
    }
}
