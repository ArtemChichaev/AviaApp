using FlyApp.Entity;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FlyApp
{
    internal class Program
    {
        static void Main()
        {
            using var db = new AppDbContext();

            var passenger = new AppPassengers()
            {
                FullName = "Иванов Иван Иванович",
                PassportSeries = 1122,
                PassportId = 334455,
            };
            db.Passengers.Add(passenger);
            db.SaveChanges();
            Console.WriteLine('w');
        }
    }
}