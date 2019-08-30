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



    }
}
