using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1
{
    class ApplicationDbContext : DbContext
    {
        //this class is in all migrations
        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    optionBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=DB2;Integrated Security=True");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) =>

               optionBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=DB2;Integrated Security=True");

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
              .Property(z => z.URL)
              .IsRequired();
            modelBuilder.Entity<Host>();
            modelBuilder.Entity<Host>().ToTable("MyHost");
        }
        
        public DbSet<Blog> Blogs { get; set; }

    }
}
  