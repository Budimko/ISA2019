using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class AirlineRepository : IAirline
    {
        private DBContext db;

        public AirlineRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Airline> getAirlines => db.Airline;

        public Airline GetAirline(Guid Id)
        {
            
            Airline dbAirline = db.Airline.Find(Id);
            return dbAirline;
        }
    }
}
