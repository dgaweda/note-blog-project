using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfoliov2.Models
{
    public class Menu
    {
        public int MenuPositionID { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public int ArticleID { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}