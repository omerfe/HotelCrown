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
    public partial class RoomsForm : Form
    {
        private readonly HotelCrownDbContext db;
        Room selectedRoom;
        List<Feature> selectedFeatures = new List<Feature>();

        public RoomsForm(HotelCrownDbContext db)
        {
            InitializeComponent();
            this.db = db;
            GetRooms();
            GetFeatures();
        }

        private void GetFeatures()
        {
            lsbFeatures.DataSource = db.Features.ToList();
            lsbFeatures.DisplayMember = "FeatureName";
        }
        private void GetRooms()
        {
            dgvRooms.DataSource = db.Rooms.Select(x => new
            {
                RoomId = x.RoomId,
                Name = x.RoomName,
                Capacity = x.Capacity,
                Price = x.Price
            }).ToList();
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            GetSelectedFeatures();
            if (String.IsNullOrEmpty(txtRoomName.Text.Trim()))
            {
                MessageBox.Show("Room Name is required!");
                return;
            }
            else if (selectedFeatures == null)
            {
                MessageBox.Show("At least 1 feature is required!");
                return;
            }
            else
            {
                Room room = new Room()
                {
                    RoomId = (int)nudRoomNumber.Value,
                    RoomName = txtRoomName.Text.Trim(),
                    Capacity = (int)nudCapacity.Value,
                    Price = nudPrice.Value,
                    Features = selectedFeatures
                };
                db.Rooms.Add(room);
                MessageBox.Show($"Room Number {room.RoomId} added successfully!");
                db.SaveChanges();
                ResetForm();
                GetRooms();
            }
        }
        private void GetSelectedFeatures()
        {
            foreach (Feature item in lsbFeatures.SelectedItems)
                selectedFeatures.Add(item);
        }
        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            Size = new Size(773, 867);
            grbRoom.Text = "New Room";
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAddRoom.Visible = true;
        }
        private void ResetForm()
        {
            nudRoomNumber.Value = 1;
            txtRoomName.Text = "";
            nudCapacity.Value = 1;
            nudPrice.Value = 0;
            Size = new Size(773, 506);
        }
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                GetSelectedRoom();
                DialogResult dr = MessageBox.Show($"Are you sure you wanted to delete Room number {selectedRoom.RoomId}?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    db.Rooms.Remove(selectedRoom);
                db.SaveChanges();
                GetRooms();
            }
        }
        private void GetSelectedRoom()
        {
            int selectedRoomNumber = (int)dgvRooms.SelectedRows[0].Cells[0].Value;
            selectedRoom = db.Rooms.FirstOrDefault(x => x.RoomId == selectedRoomNumber);
        }
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                GetSelectedRoom();
                nudRoomNumber.Enabled = false;
                nudCapacity.Enabled = false;
                txtRoomName.Text = selectedRoom.RoomName;
                nudPrice.Value = selectedRoom.Price;
                Size = new Size(775, 874);
                grbRoom.Text = $"Editing Room Number: {selectedRoom.RoomId}";
                btnAddRoom.Visible = false;
                btnSave.Location = new System.Drawing.Point(294, 268);
                btnCancel.Location = new System.Drawing.Point(228, 268);
                btnCancel.Visible = true;
                btnSave.Visible = true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            GetSelectedFeatures();
            if (String.IsNullOrEmpty(txtRoomName.Text.Trim()))
            {
                MessageBox.Show("Room Name is required!");
                return;
            }
            else if (selectedFeatures == null)
            {
                MessageBox.Show("At least 1 feature is required!");
                return;
            }
            else
            {
                selectedRoom.RoomName = txtRoomName.Text.Trim();
                selectedRoom.Price = nudPrice.Value;
                selectedRoom.Features = selectedFeatures;

                MessageBox.Show($"Room Number: {selectedRoom.RoomId} edited successfully!");
                db.SaveChanges();
                ResetForm();
                GetRooms();
            }
        }
    }
}
