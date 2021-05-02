
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Portfolio.DAL;

namespace Portfolio.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<Portfolio.DAL.PortfolioContext>
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
