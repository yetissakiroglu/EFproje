using Microsoft.EntityFrameworkCore;
using proje.ENTITES;
using System;
using System.Collections.Generic;
using System.Text;

namespace proje.DATAACCESS.Concrete.EntityFrameworkCore.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=GenericEFCore;Trusted_Connection=True;");
        }
    }
}
