using EasyFlight.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.ViewModel;

namespace EasyFlight.Repository
{
    public class DBContext : DbContext
    {
        public DBContext()
        {

        }
        public DBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Airline> Airline { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<TypeOfFlight> TypeOfFlight { get; set; }
        public DbSet<Friend> Friend { get; set; }
        public DbSet<AirlineDestination> AirlineDestination { get; set; }
        public DbSet<AdditionalServiceAirline> AdditionalServiceAirline { get; set; }
        public DbSet<Airplane> Airplane { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<TypeOfSeat> TypeOfSeat { get; set;}
        public DbSet<SeatInfo> SeatInfo { get; set; }





    }
}
