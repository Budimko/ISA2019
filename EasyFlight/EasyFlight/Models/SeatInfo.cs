using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class SeatInfo
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Seat")]
        public Guid SeatId { get; set; }
        [ForeignKey("Flight")]
        public Guid FlightId { get; set; }
        public decimal? DiscountPrice { get; set; }
    }
}
