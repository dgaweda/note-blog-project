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
                new Menu() { MenuId = 1, Name = "MAIN", ControllerAction = "Index", ControllerName = "Home", Blank = null },
                new Menu() { MenuId = 2, Name = "GITHUB", Reference = "https://github.com/dgaweda", Blank = "_blank" },
                new Menu() { MenuId = 3, Name = "SLIGHT EDGE", ControllerAction = "SlightEdge", ControllerName = "SubWebs", Blank = null },
                new Menu() { MenuId = 4, Name = "ABOUT ME", ControllerAction = "AboutMe", ControllerName = "SubWebs", Blank = null },
                new Menu() { MenuId = 5, Name = "NOTES", ControllerAction = "Index", ControllerName = "Home", Blank = null }
            };
            Menu.ForEach(menu => context.Menus.AddOrUpdate(menu));
            context.SaveChanges();
        }
    }
}

