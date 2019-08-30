using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class AdditionalServiceAirline
    {
        public Guid Id { get; set; }
        public Guid AirlineId { get; set; }
        public string HandBaggage { get; set; }
        public string CheckedBaggage { get; set; }
        public string Drink { get; set; }
    }
}
