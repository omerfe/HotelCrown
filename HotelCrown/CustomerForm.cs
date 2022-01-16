using HotelCrown.Enums;
using HotelCrown.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown
{
    public partial class CustomerForm : Form
    {
        private readonly HotelCrownDbContext db;
        Gender selectedGender;
        Customer selectedCustomer;

        public CustomerForm(HotelCrownDbContext db)
        {
            InitializeComponent();
            this.db = db;
            GetCustomers();
        }

        private void GetCustomers()
        {
            dgvRegisteredCustomers.DataSource = db.Customers.Select(x => new
            {
                Name = x.FullName,
                ID = x.IdentityNumber,
                PhoneNumber = x.PhoneNumber,
                BirthDate = DbFunctions.TruncateTime(x.BirthDate.Value),
                Gender = x.Gender,
                Description = x.Description
            }).ToList();
        }
        private void ResetForm()
        {
            txtCustomerName.Text = "";
            txtIdentityNumber.Text = "";
            mtxtPhoneNumber.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            rbFemale.Checked = false;
            rbMale.Checked = false;
            rbUnspecified.Checked = false;
            txtDescription.Text = "";
            Size = new Size(775, 502);
        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvRegisteredCustomers.SelectedRows.Count > 0)
            {
                GetSelectedCustomer();
                txtCustomerName.Text = selectedCustomer.FullName;
                txtIdentityNumber.Text = selectedCustomer.IdentityNumber;
                mtxtPhoneNumber.Text = selectedCustomer.PhoneNumber;
                dtpBirthDate.Value = selectedCustomer.BirthDate.Value;
                selectedGender = selectedCustomer.Gender;
                if (selectedGender == Gender.Male)
                    rbMale.Checked = true;
                else if (selectedGender == Gender.Female)
                    rbFemale.Checked = true;
                else
                    rbUnspecified.Checked = true;
                txtDescription.Text = selectedCustomer.Description;
                Size = new Size(775, 874);
                grbCustomer.Text = $"Editing: {selectedCustomer.FullName}";
                btnAddCustomer.Visible = false;
                btnSave.Location = new System.Drawing.Point(389, 259);
                btnCancel.Location = new System.Drawing.Point(323, 259);
                btnCancel.Visible = true;
                btnSave.Visible = true;
            }
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvRegisteredCustomers.SelectedRows.Count > 0)
            {
                GetSelectedCustomer();
                DialogResult dr = MessageBox.Show($"Are you sure you wanted to delete {selectedCustomer.FullName}?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    db.Customers.Remove(selectedCustomer);
                db.SaveChanges();
                GetCustomers();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isIdNumeric = double.TryParse(txtIdentityNumber.Text.Trim(), out _);

            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("Customer Name is required!");
                return;
            }
            else if (txtIdentityNumber.Text.Length != 11)
            {
                MessageBox.Show("The Identity Number must be 11 characters long!");
                return;
            }
            else if (!isIdNumeric)
            {
                MessageBox.Show("Please input numbers only!");
                return;
            }
            else if (rbFemale.Checked == false && rbMale.Checked == false && rbUnspecified.Checked == false)
            {
                MessageBox.Show("Please select a Gender.(You can select Unspecified if not specified.)");
                return;
            }
            else
            {
                selectedCustomer.FullName = txtCustomerName.Text.Trim();
                selectedCustomer.IdentityNumber = txtIdentityNumber.Text.Trim();
                selectedCustomer.PhoneNumber = mtxtPhoneNumber.Text.Trim();
                selectedCustomer.BirthDate = dtpBirthDate.Value;
                GetGender();
                selectedCustomer.Gender = selectedGender;
                selectedCustomer.Description = txtDescription.Text.Trim();
                MessageBox.Show($"{selectedCustomer.FullName} edited successfully!");
                db.SaveChanges();
                ResetForm();
                GetCustomers();
            }

        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            bool isIdNumeric = double.TryParse(txtIdentityNumber.Text.Trim(), out _);

            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("Customer Name is required!");
                return;
            }
            else if (txtIdentityNumber.Text.Length != 11)
            {
                MessageBox.Show("The Identity Number must be 11 characters long!");
                return;
            }
            else if (!isIdNumeric)
            {
                MessageBox.Show("Please input numbers only!");
                return;
            }
            else if (rbFemale.Checked == false && rbMale.Checked == false && rbUnspecified.Checked == false)
            {
                MessageBox.Show("Please select a Gender.(You can select Unspecified if not specified.)");
                return;
            }
            else
            {
                GetGender();

                Customer customer = new Customer()
                {
                    FullName = txtCustomerName.Text.Trim(),
                    IdentityNumber = txtIdentityNumber.Text.Trim(),
                    PhoneNumber = mtxtPhoneNumber.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Gender = selectedGender,
                    Description = txtDescription.Text.Trim()
                };

                db.Customers.Add(customer);
                MessageBox.Show($"{customer.FullName} added successfully!");
                db.SaveChanges();
                ResetForm();
                GetCustomers();
            }

        }
        private void GetGender()
        {
            if (rbFemale.Checked)
                selectedGender = Gender.Female;
            else if (rbMale.Checked)
                selectedGender = Gender.Male;
            else
                selectedGender = Gender.NotSpecified;
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            Size = new Size(775, 874);
            grbCustomer.Text = "New Customer";
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAddCustomer.Visible = true;
        }
        private void GetSelectedCustomer()
        {
            string selectedCustomerName = dgvRegisteredCustomers.SelectedRows[0].Cells[0].Value.ToString();
            selectedCustomer = db.Customers.FirstOrDefault(x => x.FullName == selectedCustomerName);
        }
    }
}
