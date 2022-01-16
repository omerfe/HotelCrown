namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        IdentityNumber = c.String(),
                        PhoneNumber = c.String(),
                        BirthDate = c.DateTime(),
                        Gender = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        CheckedInTime = c.DateTime(nullable: false),
                        CheckedOutTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomName = c.String(),
                        Capacity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reservation_ReservationId = c.Int(),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.Reservations", t => t.Reservation_ReservationId)
                .Index(t => t.Reservation_ReservationId);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureId = c.Int(nullable: false, identity: true),
                        FeatureName = c.String(),
                    })
                .PrimaryKey(t => t.FeatureId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.ReservationCustomers",
                c => new
                    {
                        Reservation_ReservationId = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_ReservationId, t.Customer_Id })
                .ForeignKey("dbo.Reservations", t => t.Reservation_ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Reservation_ReservationId)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.FeatureRooms",
                c => new
                    {
                        Feature_FeatureId = c.Int(nullable: false),
                        Room_RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Feature_FeatureId, t.Room_RoomId })
                .ForeignKey("dbo.Features", t => t.Feature_FeatureId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_RoomId, cascadeDelete: true)
                .Index(t => t.Feature_FeatureId)
                .Index(t => t.Room_RoomId);
            
            CreateTable(
                "dbo.ServiceReservations",
                c => new
                    {
                        Service_ServiceId = c.Int(nullable: false),
                        Reservation_ReservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_ServiceId, t.Reservation_ReservationId })
                .ForeignKey("dbo.Services", t => t.Service_ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.Reservation_ReservationId, cascadeDelete: true)
                .Index(t => t.Service_ServiceId)
                .Index(t => t.Reservation_ReservationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceReservations", "Reservation_ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.ServiceReservations", "Service_ServiceId", "dbo.Services");
            DropForeignKey("dbo.Rooms", "Reservation_ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.FeatureRooms", "Room_RoomId", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "Feature_FeatureId", "dbo.Features");
            DropForeignKey("dbo.ReservationCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.ReservationCustomers", "Reservation_ReservationId", "dbo.Reservations");
            DropIndex("dbo.ServiceReservations", new[] { "Reservation_ReservationId" });
            DropIndex("dbo.ServiceReservations", new[] { "Service_ServiceId" });
            DropIndex("dbo.FeatureRooms", new[] { "Room_RoomId" });
            DropIndex("dbo.FeatureRooms", new[] { "Feature_FeatureId" });
            DropIndex("dbo.ReservationCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.ReservationCustomers", new[] { "Reservation_ReservationId" });
            DropIndex("dbo.Rooms", new[] { "Reservation_ReservationId" });
            DropTable("dbo.ServiceReservations");
            DropTable("dbo.FeatureRooms");
            DropTable("dbo.ReservationCustomers");
            DropTable("dbo.Services");
            DropTable("dbo.Features");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
        }
    }
}
