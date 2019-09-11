using System;

namespace EasyFlight.ViewModel
{
    public class AirlineViewModel
    {
        public Guid Id { get; set; }
        public Guid FlightId { get; set; }
        public string Name { get; set; }
        public TimeSpan? TimeOfTrevel { get; set; }
        public decimal Price { get; set; }
        
    }
}
