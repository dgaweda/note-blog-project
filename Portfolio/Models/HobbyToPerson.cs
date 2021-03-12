using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class HobbyToPerson
    {
        [Key, Column(Order = 0)]
        public int HobbyId { get; set; }
        [Key, Column(Order = 1)]
        public int PersonId { get; set; }
    }
}