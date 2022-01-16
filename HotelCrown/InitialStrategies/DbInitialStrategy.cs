using HotelCrown.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.InitialStrategies
{
    public class DbInitialStrategy : CreateDatabaseIfNotExists<HotelCrownDbContext>
    {
        protected override void Seed(HotelCrownDbContext context)
        {
            List<Feature> features;

            if (!context.Services.Any())
            {
                List<Service> services = new List<Service>()
                {
                   new Service()
                   {
                       ServiceName = "Room Service",
                       UnitPrice = 10
                   },
                   new Service()
                   {
                       ServiceName = "Food Service",
                       UnitPrice = 5
                   },
                   new Service()
                   {
                       ServiceName = "Spa & Massage Service",
                       UnitPrice = 50
                   },
                   new Service()
                   {
                       ServiceName = "Alcohol Service",
                       UnitPrice = 100
                   },
                   new Service()
                   {
                       ServiceName = "Newspaper Service",
                       UnitPrice = 2
                   }
                };

                foreach (Service item in services)
                    context.Services.Add(item);
            }

            if (!context.Rooms.Any())
            {
                features = new List<Feature>()
                {
                   new Feature() { FeatureName = "TV", FeatureId = 1 },
                   new Feature() { FeatureName = "Wi-Fi (Standart)", FeatureId = 2 },
                   new Feature() { FeatureName = "Bathroom", FeatureId = 3 },
                   new Feature() { FeatureName = "Mini Bar", FeatureId = 4 },
                   new Feature() { FeatureName = "Towel", FeatureId = 5 },
                   new Feature() { FeatureName = "Shampoo", FeatureId = 6 },
                   new Feature() { FeatureName = "Shower Gel", FeatureId = 7 },
                   new Feature() { FeatureName = "Slippers", FeatureId = 8 },
                   new Feature() { FeatureName = "Bed", FeatureId = 9 },
                   new Feature() { FeatureName = "Desk",FeatureId = 10 },
                   new Feature() { FeatureName = "Wi-Fi (Fiber Connection)", FeatureId = 11 },
                   new Feature() { FeatureName = "Safe", FeatureId = 12 },
                   new Feature() { FeatureName = "Balcony with a View", FeatureId = 13 },
                   new Feature() { FeatureName = "Jakuzi", FeatureId = 14 },
                   new Feature() { FeatureName = "Hammock", FeatureId = 15 },
                   new Feature() { FeatureName = "Smart Gadgets", FeatureId = 16 }
                };

                foreach (Feature item in features)
                    context.Features.Add(item);

                List<Room> rooms = new List<Room>()
                {
                   new Room()
                   {
                       RoomName = "Standart",
                       Capacity = 2,
                       Features = features.Where(x=>x.FeatureId < 11).ToList()
                   },
                   new Room()
                   {
                       RoomName = "Queen",
                       Capacity = 4,
                       Features = features.Where(x=>x.FeatureId < 14).ToList()
                   },
                   new Room()
                   {
                       RoomName = "King",
                       Capacity = 4,
                       Features = features.Where(x=>x.FeatureId < 14).ToList()
                   },
                   new Room()
                   {
                       RoomName = "Suit",
                       Capacity = 6,
                       Features = features.ToList()
                   }
                };

                foreach (Room item in rooms)
                    context.Rooms.Add(item);
            }

            if (!context.Customers.Any())
            {
                Customer customer = new Customer()
                {
                    FullName = "Ömer Eker",
                    IdentityNumber = "62977340008",
                    Gender = Enums.Gender.Male,
                    PhoneNumber = "+905397192027",
                    BirthDate = new DateTime(1996, 05, 08),
                };
                context.Customers.Add(customer);
            }
            context.SaveChanges();
        }
    }
}
