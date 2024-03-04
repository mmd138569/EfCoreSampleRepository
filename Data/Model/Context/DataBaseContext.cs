using Data.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Context
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext() { }
        public DbSet<Customer>customers { get; set; }
        public DbSet<Employee> employees { get; set; }  
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=myDB; Integrated Security=True; Encrypt=False");
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(e=>e.Id);
            modelBuilder.Entity<Employee>().HasKey(e=>e.Id);
            modelBuilder.Entity<Product>().HasKey(e => e.Id);
        }
    }
}
