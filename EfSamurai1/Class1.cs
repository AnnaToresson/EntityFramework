using EfSamurai.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfSamurai1
{
    public class Class1
    {
    }

    public class SamuraiContext : DbContext
    {
        
            public DbSet<Samurai> Samurais { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                  "Server = (localdb)\\mssqllocaldb; Database = EfSamurai; Trusted_Connection = True; ");
            }
        

    }
}
