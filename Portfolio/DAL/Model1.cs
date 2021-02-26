using Portfolio.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Portfolio.DAL
{
    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Hobby> Hobbies { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }

    }
}