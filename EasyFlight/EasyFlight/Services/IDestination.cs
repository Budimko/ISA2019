using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IDestination
    {
        IEnumerable<Destination> getDestinations { get; }
        Destination GetDestination(Guid Id);
        void Add(Destination _Destination);
        void Remove(Guid Id);
    }
}
