
using Portfolio.DAL;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();
        public ActionResult Index()
        {
            Menu menu = new Menu() { Reference = "example", Name = "START" };
            db.Menus.Add(menu);
            db.SaveChanges();
            return View();
        }
    }
}