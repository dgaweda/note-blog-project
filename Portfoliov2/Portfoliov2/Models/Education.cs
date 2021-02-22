using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfoliov2.Models
{
    public class Education
    {
        public int EducationID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool Present{ get; set; }

        public virtual Person Person { get; set; }
    }
}