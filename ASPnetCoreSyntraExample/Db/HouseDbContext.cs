using ASPnetCoreSyntraExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPnetCoreSyntraExample.Db
{
    public class HouseDbContext : DbContext
    {
        public DbSet<House> Houses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=houses.db");
    }
}
