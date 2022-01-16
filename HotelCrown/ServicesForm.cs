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
    public partial class ServicesForm : Form
    {
        private readonly HotelCrownDbContext db;
        Service selectedService;

        public ServicesForm(HotelCrownDbContext db)
        {
            InitializeComponent();
            this.db = db;
            GetServices();
        }

        private void GetServices()
        {
            cboServices.DataSource = db.Services.ToList();
            cboServices.DisplayMember = "ServiceName";
        }
        private void ResetForm()
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAddService.Visible = true;
            grbFeature.Text = "New Service";
            txtServiceName.Text = "";
            nudPrice.Value = 0;
        }
        private void NameValidation()
        {
            MessageBox.Show("Service Name is required!");
            return;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cboServices.SelectedIndex > -1)
            {
                selectedService = (Service)cboServices.SelectedItem;
                txtServiceName.Text = selectedService.ServiceName;
                txtServiceName.Focus();
                nudPrice.Value = selectedService.UnitPrice;
                grbFeature.Text = $"Editing: {selectedService.ServiceName}";
                btnAddService.Visible = false;
                btnSave.Location = new System.Drawing.Point(319, 114);
                btnCancel.Location = new System.Drawing.Point(245, 114);
                btnCancel.Visible = true;
                btnSave.Visible = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboServices.SelectedIndex > -1)
            {
                selectedService = (Service)cboServices.SelectedItem;
                DialogResult dr = MessageBox.Show($"Are you sure you wanted to delete {selectedService.ServiceName}?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    db.Services.Remove(selectedService);
                db.SaveChanges();
                GetServices();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text != "")
            {
                selectedService.ServiceName = txtServiceName.Text.Trim();
                selectedService.UnitPrice = nudPrice.Value;
                MessageBox.Show($"{selectedService.ServiceName} edited successfully!");
                db.SaveChanges();
                ResetForm();
                GetServices();
                cboServices.SelectedItem = selectedService;
            }
            else
                NameValidation();
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text != "")
            {
                Service service = new Service() 
                { 
                    ServiceName = txtServiceName.Text.Trim(),
                    UnitPrice = nudPrice.Value
                };
                db.Services.Add(service);
                MessageBox.Show($"{service.ServiceName} added successfully!");
                db.SaveChanges();
                ResetForm();
                GetServices();
                cboServices.SelectedItem = service;
            }
            else
                NameValidation();
        }
        private void GetUnitPrice()
        {
            selectedService = (Service)cboServices.SelectedItem;
            lblServicePrice.Text = $"Service Price: ${selectedService.UnitPrice}";
        }
        private void cboServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUnitPrice();
        }
    }
}
