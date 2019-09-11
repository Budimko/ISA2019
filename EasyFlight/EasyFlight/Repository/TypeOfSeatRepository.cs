using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class TypeOfSeatRepository : ITypeOfSeat
    {
        private DBContext db;
        public TypeOfSeatRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<TypeOfSeat> getTypeOfSeats => db.TypeOfSeat;

        public TypeOfSeat GetTypeOfSeat(Guid Id)
        {
            TypeOfSeat dbTypeOfSeat = db.TypeOfSeat.Find(Id);
            return dbTypeOfSeat;
        }
    }
}
