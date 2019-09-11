using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IAdditionalServiceAirline
    {
        IEnumerable<AdditionalServiceAirline> getAdditionalServiceAirline { get; }
        AdditionalServiceAirline GetAdditionalServiceAirline(Guid Id);
        void Edit(AdditionalServiceAirline _AdditionalServiceAirline);

    }
}
