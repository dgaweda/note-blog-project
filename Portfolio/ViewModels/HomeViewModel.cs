using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Menu> Menus { get; set; }
    }
}