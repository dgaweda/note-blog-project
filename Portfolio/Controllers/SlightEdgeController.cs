using Portfolio.DAL;
using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class SlightEdgeController : Controller
    {
        PortfolioContext db = new PortfolioContext();
        // GET: SlightEdge
        public ActionResult SlightEdge()
        {
            var menu = db.Menus.ToList();
            return View(menu);
        }
    }
}