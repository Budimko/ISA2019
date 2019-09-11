using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface ITypeOfSeat
    {
        IEnumerable<TypeOfSeat> getTypeOfSeats { get; }
        TypeOfSeat GetTypeOfSeat(Guid Id);
    }
}
