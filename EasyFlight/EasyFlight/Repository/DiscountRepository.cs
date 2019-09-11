using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class DiscountRepository : IDiscount
    {
        private DBContext db;
        public DiscountRepository(DBContext _db)
        {
            db = _db;  
        }
        public IEnumerable<Discount> getDiscounts => db.Discount;

        public void Add(Discount _Discount)
        {
            db.Discount.Add(_Discount);
            db.SaveChanges();
        }

        public void Edit(Discount _Discount)
        {
            db.Discount.Update(_Discount);
            db.SaveChanges();
        }

        public Discount GetDiscount(Guid Id)
        {
            Discount dbDiscaunt = db.Discount.Find(Id);
            return dbDiscaunt;
        }

        public void Remove(Guid Id)
        {
            Discount dbDiscaunt = db.Discount.Find(Id);
            db.Discount.Remove(dbDiscaunt);
        }
    }
}
