
using Portfolio.DAL;
using Portfolio.Models;
using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private PortfolioContext db = new PortfolioContext();
        
        public ActionResult Index()
        {
            var menuPositions = db.Menus.ToList();

            var ViewModelMenuPositions = new HomeViewModel()
            {
                Menus = menuPositions
            };
            return View(ViewModelMenuPositions);
        }
    }
}