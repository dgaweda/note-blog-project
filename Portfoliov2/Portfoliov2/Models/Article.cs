using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfoliov2.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int MenuPositionID { get; set; }

        public virtual Menu Menu { get; set; }
    }
}