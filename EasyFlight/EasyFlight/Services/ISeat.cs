using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface ISeat
    {
        IEnumerable<Seat> getSeats { get; }
        Seat GetSeat(Guid Id);
        void Add(Seat _Seat);
        void Edit(Seat _Seat);
        void Remove(Guid Id);
    }
}
