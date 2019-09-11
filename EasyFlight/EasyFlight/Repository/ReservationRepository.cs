using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class ReservationRepository : IReservation
    {
        private DBContext db;
        public ReservationRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Reservation> getReservations => db.Reservation;

        public void Add(Reservation _Reservation)
        {
            db.Reservation.Add(_Reservation);
            db.SaveChanges();
        }

        public void Edit(Reservation _Reservation)
        {
            db.Reservation.Update(_Reservation);
            db.SaveChanges();
        }

        public Reservation GetReservation(Guid Id)
        {
            Reservation DbReservation = db.Reservation.Find(Id);
            return DbReservation;
        }

        public void Remove(Guid Id)
        {
            Reservation DbReservation = db.Reservation.Find(Id);
            db.Reservation.Remove(DbReservation);
        }
    }
}
