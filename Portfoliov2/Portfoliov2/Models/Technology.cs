using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfoliov2.Models
{
    public class Technology
    {
        public int TechnologyID { get; set; }
        public string Name { get; set; }
        public string FromWhen { get; set; }

        public virtual Person Person { get; set; }
    }
}