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
    }
}
