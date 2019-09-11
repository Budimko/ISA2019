using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public interface IRepoWrapper
    {
        IDestination Destination { get; }
        IAirline Airline { get; }
        IUser User { get; }
        IFlight Flight { get; }
        ITypeOfFlight TypeOfFlight { get; }
        IFriend Friend { get; }
        IAirlineDestination AirlineDestination { get; }
        IAdditionalServiceAirline AdditionalServiceAirline { get; }
        IAirplane Airplane { get; }
        IReservation Reservation { get; }
        ISeat Seat { get; }
        IDiscount Discount { get; }
        ITypeOfSeat TypeOfSeat { get; }
        ISeatInfo SeatInfo { get; }


    }
}
