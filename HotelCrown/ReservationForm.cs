using HotelCrown.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown
{
    public partial class ReservationForm : Form
    {
        private readonly HotelCrownDbContext db;
        private readonly Reservation selectedReservation;
        List<Customer> selectedCustomers = new List<Customer>();
        List<Room> selectedRooms = new List<Room>();
        List<Service> selectedServices = new List<Service>();

        public ReservationForm(HotelCrownDbContext db)
        {
            InitializeComponent();
            this.db = db;
            GetRoomsCustomersandServices();
        }
        public ReservationForm(HotelCrownDbContext db, Reservation selectedReservation)
        {
            this.db = db;
            this.selectedReservation = selectedReservation;
        }

        private void GetRoomsCustomersandServices()
        {
            lsbCustomers.DataSource = db.Customers.ToList();
            lsbCustomers.DisplayMember = "FullName";
            lsbRooms.DataSource = db.Rooms.ToList();
            lsbRooms.DisplayMember = "RoomName";
            lsbServices.DataSource = db.Services.ToList();
            lsbServices.DisplayMember = "ServiceName";
        }
        
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (dtpCheckInDate.Value.Date < DateTime.Now.Date || dtpCheckOutDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Reservations must be future-dated!");
                return;
            }
            else if (selectedCustomers == null || selectedRooms == null)
            {
                MessageBox.Show("At least 1 customer and 1 room required!");
            }
            else
            {
                GetSelectedCustomers_Rooms_Services();
                Reservation reservation = new Reservation()
                {
                    Customers = selectedCustomers,
                    Rooms = selectedRooms,
                    Services = selectedServices,
                    CheckInDate = dtpCheckInDate.Value,
                    CheckOutDate = dtpCheckOutDate.Value,
                };

                db.Reservations.Add(reservation);
                MessageBox.Show("Reservation created successfully!");
                db.SaveChanges();

                Close();
            }
        }

        private void GetSelectedCustomers_Rooms_Services()
        {
            foreach (Customer item in lsbCustomers.SelectedItems)
                selectedCustomers.Add(item);
            foreach (Room item in lsbRooms.SelectedItems)
                selectedRooms.Add(item);
            foreach (Service item in lsbServices.SelectedItems)
                selectedServices.Add(item);
        }
    }
}
