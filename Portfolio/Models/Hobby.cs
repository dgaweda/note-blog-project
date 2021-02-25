using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Hobby
    {
        public int HobbyID { get; set; }
        public string Name { get; set; }

        public virtual Person Person { get; set; }
    }
}