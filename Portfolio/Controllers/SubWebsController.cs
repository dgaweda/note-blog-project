using Portfolio.DAL;
using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class SubWebsController : Controller
    {
        public PortfolioContext db = new PortfolioContext();
        // GET: SubWebs
        public ActionResult SlightEdge()
        {
            return View(Menu(db));
        }

        public ActionResult AboutMe()
        {
            return View(Menu(db));
        }
        public HomeViewModel Menu(PortfolioContext db)
        {
            var menuPositions = db.Menus.ToList();
            var VM = new HomeViewModel() { Menus = menuPositions };
            return VM;
        }
    }
}