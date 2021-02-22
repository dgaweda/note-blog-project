using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfoliov2.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int EducationID { get; set; }
        public int HobbyID { get; set; }
        public int TechnologyID { get; set; }
        public string GeneralInfo { get; set; }
        public int NoteID { get; set; }
        public bool Logged { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Hobby> Hobbies { get; set; }
        public virtual ICollection<Technology> Technologies { get; set; }
        public virtual ICollection<Note> Notes { get; set; }

        public virtual User User { get; set; }
    }
}