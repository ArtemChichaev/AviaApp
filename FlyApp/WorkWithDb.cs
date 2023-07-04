using FlyApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyApp
{
    internal class WorkWithDb
    {
        AppDbContext db = new AppDbContext();

        public AppPassengers AddPassenger(string fullName, int passportSeries, int passportId, int flightsId)
        {
             return new AppPassengers()
            {
                FullName = fullName,
                PassportSeries = passportSeries,
                PassportId = passportId,
                AppFlightsId = flightsId
            };
        }
        public AppFlights AddFlight(int flightNumber, string from, string to)
        {
             return new AppFlights()
            {
                FlightNumber = flightNumber,
                From = from,
                To = to
            };
        }
        public void RegistretedPassenger(int id)
        {
            var reg = db?.Passengers.FirstOrDefault(x => x.Id == id);
            if (reg != null)
            {
                reg.Registered = true;
            }
            else
            {
                Console.WriteLine("Пассажира с таким ID нет!");
            }
        }
        public void ShowFlights()
        {
            List<AppFlights> allFligths = db.Flights.ToList();
            foreach (var flight in allFligths)
            {
                Console.WriteLine($"Номер рейса:{flight.FlightNumber}. Направление: {flight.From} - {flight.To}");
            }
        }      
        public void ShowPassangers()
        {
            List<AppPassengers> allPassengers = db.Passengers.ToList();
            foreach (var passengers in allPassengers)
            {
                Console.WriteLine($"{passengers.Id} - {passengers.FullName}. Серия и номер паспорта: {passengers.PassportSeries}{passengers.PassportId}");
            }
        }
    }
}