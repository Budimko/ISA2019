using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.ViewModel
{
    public class FlightsViewModel
    {
        public DateTime DepartureTime { get; set; }
        public DateTime LandingTime { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string NumberOfPassangers { get; set; }

        public IEnumerable<AirlineViewModel> airlines;

    }
}
