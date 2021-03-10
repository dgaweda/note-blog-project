using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Education
    {
        public int EducationId { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public bool Present{ get; set; }

        public virtual Person Person { get; set; }
    }
}