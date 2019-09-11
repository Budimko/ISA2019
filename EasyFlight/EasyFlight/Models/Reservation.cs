using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Flight")]
        public Guid FlightId { get; set; }
        
        [ForeignKey("Seat")]
        public Guid SeatId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportSerialNumber { get; set; }
    }
}
