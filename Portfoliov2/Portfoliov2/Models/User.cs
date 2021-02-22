using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfoliov2.Models
{
    public class User
    {
        public int UserID { get; set; }

        public int PersonID { get; set; }
        public string Password { get; set; }
        public DateTime JoinData { get; set; }
        public bool IsAdmin { get; set; }

        public virtual Person Person { get; set; }
    }
}