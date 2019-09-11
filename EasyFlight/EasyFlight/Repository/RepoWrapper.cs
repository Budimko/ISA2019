using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class RepoWrapper : IRepoWrapper
    {
        private DBContext _dBContext;
        private IDestination _destination;//trenutno imas samo jedan repo, dok kod zivi instanca RepoWrapera zivice i ove
        //samo dodajes, po istom sablonu
        private IAirline _airline;
        private IUser _user;
        private IFlight _flight;
        private ITypeOfFlight _typeOfFlight;
        private IFriend _friend;
        private IAirlineDestination _airlineDestination;
        private IAdditionalServiceAirline _additionalServiceAirline;
        private IAirplane _airplane;
        private IReservation _reservation;
        private ISeat _seat;
        private IDiscount _discount;
        private ITypeOfSeat _typeOfSeat;
        private ISeatInfo _seatInfo;



        public RepoWrapper(DBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public IDestination Destination //ti pozoves ovo, i on pita ako nije ziva instanca ti je kreiraj i vrati novi, u protivnom koristi postojeci
        {
            get
            {
                if (_destination == null)
                {
                    _destination = new DestinationRepository(_dBContext);
                }
                return _destination;
            }

        }
        public ISeatInfo SeatInfo
        {
            get
            {
                if (_seatInfo == null)
                {
                    _seatInfo = new SeatInfoRepository(_dBContext);
                }
                return _seatInfo;
            }
        }

        public IAirline Airline
        {
            get
            {
                if (_airline == null)
                {
                    _airline = new AirlineRepository(_dBContext);
                }
                return _airline;
            }
        }

        public IUser User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_dBContext);
                }
                return _user;
            }
        }
        public IFlight Flight
        {
            get
            {
                if (_flight == null)
                {
                    _flight = new FlightRepository(_dBContext);
                }
                return _flight;
            }
        }
        public ITypeOfFlight TypeOfFlight
        {
            get
            {
                if (_typeOfFlight == null)
                {
                    _typeOfFlight = new TypeOfFlightRepository(_dBContext);
                }
                return _typeOfFlight;
            }
        }
        public IFriend Friend
        {
            get
            {
                if (_friend == null)
                {
                    _friend = new FriendRepository(_dBContext);
                }
                return _friend;
            }
        }

        public IAirlineDestination AirlineDestination
        {
            get
            {
                if (_airlineDestination == null)
                {
                    _airlineDestination = new AirlineDestinationRepository(_dBContext);
                }
                return _airlineDestination;
            }
        }
        public IAdditionalServiceAirline AdditionalServiceAirline
        {
            get
            {
                if (_additionalServiceAirline == null)
                {
                    _additionalServiceAirline = new AdditionalServiceAirlineRepository(_dBContext);
                }
                return _additionalServiceAirline;
            }
        }

        public IAirplane Airplane
        {
            get
            {
                if (_airplane == null)
                {
                    _airplane = new AirplaneRepository(_dBContext);
                }
                return _airplane;
            }
        }

        public IReservation Reservation
        {
            get
            {
                if (_reservation == null)
                {
                    _reservation = new ReservationRepository(_dBContext);
                }
                return _reservation;
            }
        }
        public ISeat Seat
        {
            get
            {
                if (_seat == null)
                {
                    _seat = new SeatRepository(_dBContext);
                }
                return _seat;
            }
        }
        public IDiscount Discount
        {
            get
            {
                if (_discount == null)
                {
                    _discount = new DiscountRepository(_dBContext);
                }
                return _discount;
            }
        }
        public ITypeOfSeat TypeOfSeat
        {
            get
            {
                if (_typeOfSeat == null)
                {
                    _typeOfSeat = new TypeOfSeatRepository(_dBContext);
                }
                return _typeOfSeat;
            }
        }

        
    }
}
