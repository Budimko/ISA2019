using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface ITypeOfFlight
    {
        
         IEnumerable<TypeOfFlight> getTypeOfFlights { get; }
         TypeOfFlight GetTypeOfFlight(Guid Id); 
        
    }
}
