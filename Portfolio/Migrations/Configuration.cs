namespace Portfolio.Migrations
{
    using Portfolio.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<PortfolioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PortfolioContext context)
        {
            DataBaseSeedInit.SeedData(context);
        }
    }
}
