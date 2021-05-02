using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.ViewModels
{
    public class NoteViewModel
    {
        public IEnumerable<Note> Notes { get; set; }
        public Note Note { get; set; }
    }
}