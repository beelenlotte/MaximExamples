using Example2.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.DataAccess
{
    public class Example2DbContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<House> Houses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=example2.db");
    }
}
