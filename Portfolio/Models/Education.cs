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
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool Present{ get; set; }

        public virtual Person Person { get; set; }
    }
}