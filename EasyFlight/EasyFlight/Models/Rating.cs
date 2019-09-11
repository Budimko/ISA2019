using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class Rating
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [ForeignKey("Flight")]
        public Guid FlightId { get; set; }
        [ForeignKey("Airline")]
        public Guid AirlineId { get; set; }

        public string Mark { get; set; }
    }
}
