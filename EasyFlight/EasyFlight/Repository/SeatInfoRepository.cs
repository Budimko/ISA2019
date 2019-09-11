using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class SeatInfoRepository : ISeatInfo
    {
        private DBContext db;
        public SeatInfoRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<SeatInfo> getSeatInfos => db.SeatInfo;

        public void Add(SeatInfo _SeatInfo)
        {
            db.SeatInfo.Add(_SeatInfo);
            db.SaveChanges();
        }

        public void Edit(SeatInfo _SeatInfo)
        {
            db.SeatInfo.Update(_SeatInfo);
            db.SaveChanges();
        }

        public SeatInfo GetSeatInfo(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid Id)
        {
            SeatInfo dbSeatInfo = db.SeatInfo.Find(Id);
            db.SeatInfo.Remove(dbSeatInfo);
        }

        public void RemoveBySeatFlight(Guid seatId, Guid flightId)
        {
            SeatInfo seatInfo = db.SeatInfo.Where(si => si.SeatId == seatId && si.FlightId == flightId).FirstOrDefault();
            db.SeatInfo.Remove(seatInfo);
            db.SaveChanges();
            //db.SeatInfo.Remove(dbSeatInfo);
        }
    }
}
