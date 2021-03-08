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
                new Menu() { MenuId = 1, Name = "MAIN", Reference = "link", Blank = null },
                new Menu() { MenuId = 2, Name = "GITHUB", Reference = "link", Blank = "_blank" },
                new Menu() { MenuId = 3, Name = "SLIGHT EDGE", Reference = "link", Blank = null },
                new Menu() { MenuId = 4, Name = "ABOUT ME", Reference = "link", Blank = null },
                new Menu() { MenuId = 5, Name = "NOTES", Reference = "link", Blank = null }
            };
            Menu.ForEach(menu => context.Menus.AddOrUpdate(menu));
            context.SaveChanges();
        }
    }
}

