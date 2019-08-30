using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class AirlineDestinationRepository : IAirlineDestination
    {

        private DBContext db;
        public AirlineDestinationRepository(DBContext _db)
        {
            db = _db;
        }


        public void Add(AirlineDestination airlineDestination)
        {
            db.AirlineDestination.Add(airlineDestination);
            db.SaveChanges();
        }

        public AirlineDestination GetAirlineDestination(Guid Id)
        {
            AirlineDestination dbAirlineDestination = db.AirlineDestination.Find(Id);
            return dbAirlineDestination;
        }

        public IEnumerable<AirlineDestination> getAirlineDestinations => db.AirlineDestination;


        public void Remove(Guid Id)
        {
            AirlineDestination airlineDestination = db.AirlineDestination.Find(Id);
            db.AirlineDestination.Remove(airlineDestination);
        }
    }
}
