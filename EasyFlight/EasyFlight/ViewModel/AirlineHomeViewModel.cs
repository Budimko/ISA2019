using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.ViewModel
{
    public class AirlineHomeViewModel
    {
        public Guid Id { get; set; }
        //
        public List<Destination> airlinesDestinationList;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public double? Rating { get; set; }
        //
        public string HandBaggage { get; set; }
        public string CheckedBaggage { get; set; }
        public string Drink { get; set; }
        //
        public TimeSpan Time { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime LandingTime { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Type { get; set; }
        public string Distance { get; set; }
        public string Airplain { get; set; }
        public decimal Price { get; set; }
        //
        public List<AdminSeatViewModel> seats;
        public List<Flight> flight;

    }



   
}
