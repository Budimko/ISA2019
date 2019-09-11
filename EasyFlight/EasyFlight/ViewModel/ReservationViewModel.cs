using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.ViewModel
{
    public class ReservationViewModel
    {
        public List<SeatViewModel> seats { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Passport { get; set; }

    }
    public class SeatViewModel
    {
        public Guid SeatId { get; set; }
        public string ColumnNumber { get; set; }
        public string RowNumber { get; set; }
        public bool Occupide { get; set; } 
    }

    public class AdminSeatViewModel
    {
        public Guid FlightId { get; set; }
        public Guid SeatId { get; set; }
        public string ColumnNumber { get; set; }
        public string RowNumber { get; set; }
        public bool Occupide { get; set; }
        public bool Disabled { get; set; }
        public double? Discount { get; set; }
        
}
}
