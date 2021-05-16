using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
      


namespace Kontrahenci.Entities
{
    public class MyContext : DbContext
    {
        string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=TransportDB;Trusted_Connection=True;";

        public DbSet<Kontrahenci> DBKontrahenci { get; set; }
        public DbSet<Kraje> DBKraje { get; set; }
        public DbSet<KontrahentKonta> DBKontrahentKonta { get; set; }
        public DbSet<Waluty> DBWaluty { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          /*  modelBuilder.Entity<MeetMy>()
                .HasOne(m => m.Location)
                .WithOne(l => l.MeetMy)
                .HasForeignKey<Location>(l => l.MeetmyID);
            modelBuilder.Entity<MeetMy>()
                .HasMany(m => m.Lectures)
                .WithOne(l => l.MeetMy); */
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
