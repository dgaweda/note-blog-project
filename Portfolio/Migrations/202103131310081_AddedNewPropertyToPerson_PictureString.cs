namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewPropertyToPerson_PictureString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Picture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Picture");
        }
    }
}
