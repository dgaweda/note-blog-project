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
        public string GeneralInfo { get; set; }
        public bool Logged { get; set; }

        public virtual ICollection<EducationToPerson> EducationToPeople { get; set; }
        public virtual ICollection<HobbyToPerson> Hobbies { get; set; }
        public virtual ICollection<Technology> Technologies { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}