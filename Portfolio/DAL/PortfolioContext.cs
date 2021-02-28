using Portfolio.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Portfolio.DAL
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext()
            : base("Portfolio")
        {

        }

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