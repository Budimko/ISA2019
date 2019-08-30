using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IFriend
    {
        IEnumerable<Friend> getFriends();
        Friend GetFriend(Guid Id);
        void Add(Friend _Friend);
        void Remove(Guid Id);
    }
}
