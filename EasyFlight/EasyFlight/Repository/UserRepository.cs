using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class UserRepository : IUser
    {
        private DBContext db;
        public UserRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<User> getUsers => db.User;

        public void Add(User _User)
        {
            db.User.Add(_User);
            db.SaveChanges();
        }

        public void Edit(User _User)
        {
            db.User.Update(_User);
            db.SaveChanges();
        }

        public User GetUser(Guid Id)
        {
            User DbUser = db.User.Find(Id);
            return DbUser;
        }
    }
}
