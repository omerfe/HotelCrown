using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CheckedInTime { get; set; } = DateTime.Now;
        public DateTime CheckedOutTime { get; set; } = DateTime.Now;
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
