using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyApp.Entity
{
    internal class AppFlights
    {
        [Key]
        public int FlightNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public ICollection<AppPassengers> AppPassengers { get; set; }
    }
}
