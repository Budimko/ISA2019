using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class Flight
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Airlin")]
        public Guid AirlineId { get; set; }
        [ForeignKey("Destination")]
        public Guid DestinationIdFrom { get; set; }
        public Guid DestinationIdTo { get; set; }
        [ForeignKey("Airplain")]
        public Guid AirplainId { get; set; }
        [ForeignKey("TypeOfFlight")]
        public Guid TypeId { get; set; }

        public string Distance { get; set; }
        public DateTime DateAndTimeOfDeparture { get; set; }
        public DateTime DateAndTimeOfLanding { get; set; }
        public TimeSpan? TimeOfTrevel { get; set; }
        public decimal Price { get; set; }
    }
}
