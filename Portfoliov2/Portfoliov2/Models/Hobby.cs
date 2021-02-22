using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfoliov2.Models
{
    public class Hobby
    {
        public int HobbyID { get; set; }
        public string Name { get; set; }

        public virtual Person Person { get; set; }
    }
}