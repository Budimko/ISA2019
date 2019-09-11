using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IDiscount
    {
        IEnumerable<Discount> getDiscounts { get; }
        Discount GetDiscount(Guid Id);
        void Add(Discount _Discount);
        void Edit(Discount _Discount);
        void Remove(Guid Id);
    }
}
