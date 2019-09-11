using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface ISeatInfo
    {
        IEnumerable<SeatInfo> getSeatInfos { get; }
        SeatInfo GetSeatInfo(Guid Id);
        void Add(SeatInfo _SeatInfo);
        void Edit(SeatInfo _SeatInfo);
        void Remove(Guid Id);
        void RemoveBySeatFlight(Guid seatId, Guid flightId);
    }
}
