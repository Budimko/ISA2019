using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IFlight
    {
        IEnumerable<Flight> GetAllFlights();
        
        IEnumerable<TypeOfFlight> GetByTypeOffFlightId(Guid TypeId);
        Flight GetFlight(Guid Id);
        void Add(Flight _Flight);
        void Remove(Guid Id);
        
    }
}
