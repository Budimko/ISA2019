using EasyFlight.Models;
using EasyFlight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Repository
{
    public class FriendRepository : IFriend
    {
        private DBContext db;
        public FriendRepository(DBContext _db)
        {
            db = _db;
        }
        public void Add(Friend _Friend)
        {
            db.Friend.Add(_Friend);
            db.SaveChanges();
        }

        public Friend GetFriend(Guid Id)
        {
            Friend dbFriend = db.Friend.Find(Id);
            return dbFriend;
        }

        public IEnumerable<Friend> getFriends() => db.Friend;


        public void Remove(Guid Id)
        {
            Friend dbFriend = db.Friend.Find(Id);
            db.Friend.Remove(dbFriend);
        }
    }
}
