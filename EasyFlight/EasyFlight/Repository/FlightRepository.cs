using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class FlightRepository : IFlight
    {
        private DBContext db;
        public FlightRepository(DBContext _db)
        {
            db = _db;
        }
  

        public void Add(Flight flight)
        {
            db.Flight.Add(flight);
            db.SaveChanges();
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return db.Flight.ToList();
        }

       

        public IEnumerable<TypeOfFlight> GetByTypeOffFlightId(Guid TypeId)
        {
            throw new NotImplementedException();
        }

        public Flight GetFlight(Guid Id)
        {
                Flight dbFlight = db.Flight.Find(Id);
                return dbFlight;
             
        }

        public void Remove(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
