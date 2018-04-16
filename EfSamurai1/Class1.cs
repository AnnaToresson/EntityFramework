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
        public DbSet<Battle> Battles { get; set; } //För att skapa battle diagram
        public DbSet<BattleLog> BattleLog { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = EfSamurai; Trusted_Connection = True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//För att skapa ett nytt diagram med många till många
        {
            modelBuilder.Entity<SamuraiInBattle>()
                .HasKey(sb => new { sb.SamuraiId, sb.BattleId });
        }


    }
}
