using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyApp.Entity
{
    internal class AppPassengers : BaseEntity
    {
        public string FullName { get; set; }
        public int PassportSeries { get; set; }
        public int PassportId { get; set; }
        public bool Registered { get; set; } = false;
        public AppFlights AppFlights { get; set; }
        public int AppFlightsId { get; set; }
    }

}
