using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class AirplaneRepository : IAirplane
    {
        private DBContext db;
        public AirplaneRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Airplane> getAirplane => db.Airplane;
    }
}
