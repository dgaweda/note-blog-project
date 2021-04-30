using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class EducationToPerson
    {
        [Key, Column(Order = 0)]
        public int EducationId { get; set; }
        [Key, Column(Order = 1)]
        public int PersonId { get; set; }
    }
}