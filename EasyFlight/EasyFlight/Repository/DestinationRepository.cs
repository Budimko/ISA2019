using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class DestinationRepository : IDestination
    {
        private DBContext db;
        public DestinationRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Destination> getDestinations => db.Destination;

        public void Add(Destination _Destination)
        {
            db.Destination.Add(_Destination);
            db.SaveChanges();
        }

        public Destination GetDestination(Guid Id)
        {
            Destination dbDestination = db.Destination.Find(Id);
            return dbDestination;
        }

        public void Remove(Guid Id)
        {
            Destination dbDestination = db.Destination.Find(Id);
            db.Destination.Remove(dbDestination);
        }
    }
}
