using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int EducationId { get; set; }
        public int HobbyId { get; set; }
        public int TechnologyId { get; set; }
        public string GeneralInfo { get; set; }
        public int NoteId { get; set; }
        public bool Logged { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Hobby> Hobbies { get; set; }
        public virtual ICollection<Technology> Technologies { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}