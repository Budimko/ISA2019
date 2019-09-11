using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IAirline
    {
        IEnumerable<Airline> getAirlines { get; }
        Airline GetAirline(Guid Id);
        void Edit(Airline _Airline);
    }
}
