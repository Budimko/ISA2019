using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.ViewModel
{
    public class AirlineViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeSpan? TimeOfTrevel { get; set; }
        public decimal Price { get; set; }
        
    }
}
