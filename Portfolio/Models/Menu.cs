using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string ControllerAction { get; set; }
        public string ControllerName { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public string Blank { get; set; }
    }
}