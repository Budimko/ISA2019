using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class AdditionalServiceAirlineRepository : IAdditionalServiceAirline
    {
        private DBContext db;
        public AdditionalServiceAirlineRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<AdditionalServiceAirline> getAdditionalServiceAirline => db.AdditionalServiceAirline;
        
        public AdditionalServiceAirline GetAdditionalServiceAirline(Guid Id)
        {
            AdditionalServiceAirline dbAdditionalServiceAirline = db.AdditionalServiceAirline.Find(Id);
            return dbAdditionalServiceAirline;
        }

        
    }
}
