using Portfolio.DAL;
using Portfolio.Models;
using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class NotesController : Controller
    {
        PortfolioContext db = new PortfolioContext();
        // GET: Notes
        public ActionResult Notes()
        {
            return View(NoteVM(db));
        }

        public NoteViewModel NoteVM(PortfolioContext db)
        {
            var VM = new NoteViewModel
            {
                Notes = db.Notes.ToList(),
                Note = db.Notes.FirstOrDefault()
            };
            return VM;
        }

        public ActionResult AddNote(Note note)
        {
            note.Date = DateTime.Now;
            note.PersonId = 1;
            note.Hidden = false;
            db.Notes.Add(note);
            db.SaveChanges();
            return RedirectToAction("Notes", "Notes");
        }
    }
}