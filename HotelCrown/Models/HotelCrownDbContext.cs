using HotelCrown.InitialStrategies;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Models
{
    public class HotelCrownDbContext : DbContext
    {
        public HotelCrownDbContext() : base("name=HotelCrownDbContext")
        {
            Database.SetInitializer(new DbInitialStrategy());
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
