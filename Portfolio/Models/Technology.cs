using Portfolio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Technology
    {
        public int TechnologyId { get; set; }
        public string Name { get; set; }
        public Purpose Purpose { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}