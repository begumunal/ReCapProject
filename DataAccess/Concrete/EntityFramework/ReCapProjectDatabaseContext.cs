using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context: db tabloları ile proje classlarını birbirine bağlar
    public class ReCapProjectDatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReCapProjectDatabase;Trusted_Connection=true");
        }

        //db tabloları ile proje classlarını bağladık beki hangi nesnem db deki hangi nesneye karşılık gelir?
        //bunu da aşağıda göstermiş olduk
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
