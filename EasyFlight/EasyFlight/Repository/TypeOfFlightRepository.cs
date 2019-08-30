using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class TypeOfFlightRepository : ITypeOfFlight
    {
        private DBContext db;
        public TypeOfFlightRepository(DBContext _db)
        {
            db = _db;  
        }
        public IEnumerable<TypeOfFlight> getTypeOfFlights => db.TypeOfFlight;

        public TypeOfFlight GetTypeOfFlight(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
