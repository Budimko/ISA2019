using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IAirlineDestination
    {
        IEnumerable<AirlineDestination> getAirlineDestinations { get; }
        void Add(AirlineDestination airlineDestination);
        void Remove(Guid Id);
        AirlineDestination GetAirlineDestination(Guid Id);
    }
}
