using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IHotel
    {
        IEnumerable<Hotel> getHotels { get; }
        Hotel GetHotel(Guid Id);
    }
}
