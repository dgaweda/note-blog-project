﻿using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.ViewModels
{
    public class AboutMeViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<Hobby> Hobbies { get; set; }
        public IEnumerable<HobbyToPerson> PersonHobbies { get; set; }
        public IEnumerable<Education> Education { get; set; }
        public IEnumerable<EducationToPerson> PersonSchools { get; set; }
        public IEnumerable<Technology> PersonTechnologies { get; set; }
    }
}