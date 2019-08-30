using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class AirlineDestination
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Destination")]
        public Guid DestinationId { get; set; }
        [ForeignKey("Airlin")]
        public Guid AirlineId { get; set; }
    }
}
