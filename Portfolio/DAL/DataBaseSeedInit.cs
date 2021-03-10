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
            var Technologies = new List<Technology>()
            {
                new Technology() { TechnologyId = 1, Name = "MVC Pattern - General" },
                new Technology() { TechnologyId = 2, Name = "Entity Framework - Backend (Database)"},
                new Technology() { TechnologyId = 3, Name = ".NET Framework - Backend"},
                new Technology() { TechnologyId = 4, Name = "Razor - Frontend"},
                new Technology() { TechnologyId = 5, Name = "MS SQL Server - Database Server"},
                new Technology() { TechnologyId = 6, Name = "CSS + HTML5 - Frontend"},
                new Technology() { TechnologyId = 7, Name = "NUnit - Testing"},
                new Technology() { TechnologyId = 8, Name = "IdentityUser - For Logging"}
            };

            var SchoolList = new List<Education>()
            { 
                new Education() { EducationId = 1, Name = "University of Gdansk", Major = "Computer Science", From = "2017", To = "Present" },
                new Education() { EducationId = 2, Name = "Technical college in Działdowo", Major = "IT Technician", From = "2013", To = "2017"}
            };

            var HobbyList = new List<Hobby>()
            {
                new Hobby() { HobbyId = 1, Name = "Computer/board games - particularly the newest titles"},
                new Hobby() { HobbyId = 2, Name = "Volleyball"},
                new Hobby() { HobbyId = 3, Name = "Manual works with computer"},
                new Hobby() { HobbyId = 4, Name = "And recently programming in C#"}
            };
        }
    }
}

