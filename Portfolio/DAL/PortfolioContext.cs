using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Portfolio.DAL
{
    public class PortfolioContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Technology> Technologies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}