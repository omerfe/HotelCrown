using HotelCrown.Models;
using Microsoft.Build.Framework.XamlTypes;
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
    public partial class MainForm : Form
    {
        HotelCrownDbContext db = new HotelCrownDbContext();
        Reservation selectedReservation;
        public MainForm()
        {
            InitializeComponent();
            GetReservations();
        }

        private void GetReservations()
        {
            dgvReservations.DataSource = db.Reservations.Select(x => new 
            {
                ReservationId = x.ReservationId,
                RoomId = x.RoomId,
                CheckInDate = x.CheckInDate,
                CheckOutDate = x.CheckOutDate

            }).ToList();
        }

        #region ListViewItems
        private void tsmRooms_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm(db);
            roomsForm.ShowDialog();
        }
        private void tsmFeatures_Click(object sender, EventArgs e)
        {
            FeaturesForm featuresForm = new FeaturesForm(db);
            featuresForm.ShowDialog();
        }
        private void tsmServices_Click(object sender, EventArgs e)
        {
            ServicesForm servicesForm = new ServicesForm(db);
            servicesForm.ShowDialog();
        }
        private void tsmCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(db);
            customerForm.ShowDialog();
        } 
        #endregion
        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm(db);
            reservationForm.Text = "New Reservation: ";
            reservationForm.ShowDialog();
        }
        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            int selectedReservationId = (int)dgvReservations.SelectedRows[0].Cells[0].Value;
            selectedReservation = db.Reservations.FirstOrDefault(x => x.ReservationId == selectedReservationId);
            ReservationForm reservationForm = new ReservationForm(db, selectedReservation);
            reservationForm.Text = "Editing Reservation: ";
            reservationForm.ShowDialog();
        }
    }
}
