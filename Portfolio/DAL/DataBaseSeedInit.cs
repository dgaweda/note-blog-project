using Portfolio.Models;
using Portfolio.Migrations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Portfolio.DAL
{
    public class DataBaseSeedInit : MigrateDatabaseToLatestVersion<PortfolioContext, Migrations.Configuration>
    {
        public static void SeedData(PortfolioContext context)
        {

            var Menu = new List<Menu>
            {
                new Menu() { Name = "MAIN", Reference = "link", Blank = null },
                new Menu() { Name = "GITHUB", Reference = "link", Blank = "_blank" },
                new Menu() { Name = "SLIGHT EDGE", Reference = "link", Blank = null },
                new Menu() { Name = "ABOUT ME", Reference = "link", Blank = null },
                new Menu() { Name = "NOTES", Reference = "link", Blank = null }
            };
            Menu.ForEach(menu => context.Menus.AddOrUpdate(menu));
            context.SaveChanges();
        }
    }
}

