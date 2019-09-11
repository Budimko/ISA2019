using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IReservation
    {
        IEnumerable<Reservation> getReservations { get; }
        Reservation GetReservation(Guid Id);
        void Add(Reservation _Reservation);
        void Edit(Reservation _Reservation);
        void Remove(Guid Id);
    }
}
