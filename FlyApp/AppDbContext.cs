using FlyApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyApp
{
    internal class AppDbContext : DbContext
    {
        public DbSet<AppPassengers> Passengers { get; set; }
        public DbSet<AppFlights> Flights { get; set; }
        public AppDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppPassengers>()
                .Property(x => x.FullName)
                .IsRequired()
                .HasColumnName("Фамилия Имя Отчество"); 
            modelBuilder.Entity<AppPassengers>()
                .Property(x => x.PassportId)
                .IsRequired()
                .HasColumnName("Номер Паспорта");
            modelBuilder.Entity<AppPassengers>()
                .Property(x => x.PassportSeries)
                .IsRequired()
                .HasColumnName("Серия Паспорта");      
            modelBuilder.Entity<AppPassengers>()
                .Property(x => x.Registered)
                .IsRequired()
                .HasColumnName("Пометка регистрации");

            var flight = new AppFlights()
            {
                FlightNumber = 123,
                From = "Samara",
                To = "Moscow"
            };
            modelBuilder.Entity<AppFlights>().HasData(flight);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=5432;Database=AviaDataBase;Username=postgres;Password=admin;";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}