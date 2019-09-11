using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class SeatRepository : ISeat
    {
        private DBContext db;
        public SeatRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Seat> getSeats => db.Seat;

        public void Add(Seat _Seat)
        {
            db.Seat.Add(_Seat);
            db.SaveChanges();
        }

        public void Edit(Seat _Seat)
        {
            db.Seat.Update(_Seat);
            db.SaveChanges();
        }

        public Seat GetSeat(Guid Id)
        {
            Seat dbSeat = db.Seat.Find(Id);
            return dbSeat;
        }

        public void Remove(Guid Id)
        {
            Seat dbSeat = db.Seat.Find(Id);
            db.Seat.Remove(dbSeat);
        }
    }
}
