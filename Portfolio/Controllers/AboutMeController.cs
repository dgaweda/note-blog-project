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
    public class AboutMeController : Controller
    {
        public PortfolioContext db = new PortfolioContext();

        public ActionResult Index()
        {
            return View(AboutMeVM(db));
        }

        public AboutMeViewModel AboutMeVM(PortfolioContext db)
        {
            // need to change this after doing logging authentication by adding
            // if else statement to checkl if person is logged or not if not redirect
            // to login
            var Person = db.People.FirstOrDefault();  
            var Hobbies = db.Hobbies.ToList();
            var Technologies = db.Technologies.ToList();
            var Schools = db.Educations.ToList();

            var VM = new AboutMeViewModel()
            {
                People = Person,
                Hobbies = Hobbies,
                Education = Schools,
                PersonTechnologies = Technologies
            };

            return VM;
        }
    }
}