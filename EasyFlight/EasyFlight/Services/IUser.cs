using EasyFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Services
{
    public interface IUser
    {
        
        IEnumerable<User> getUsers { get; }
        User GetUser(Guid Id);
        void Add(User _User);
        void Edit(User _User);

    }
}
