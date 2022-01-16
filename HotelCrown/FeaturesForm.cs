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
    public partial class FeaturesForm : Form
    {
        private readonly HotelCrownDbContext db;
        Feature selectedFeature;

        public FeaturesForm(HotelCrownDbContext db)
        {
            InitializeComponent();
            this.db = db;
            GetFeatures();
        }

        private void GetFeatures()
        {
            cboFeatures.DataSource = db.Features.ToList();
            cboFeatures.DisplayMember = "FeatureName";
        }
        private void ResetForm()
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAddFeature.Visible = true;
            grbFeature.Text = "New Feature";
            txtFeatureName.Text = "";
        }
        private void NameValidation()
        {
            MessageBox.Show("Feature Name is required!");
            return;
        }
        private void btnEditFeature_Click(object sender, EventArgs e)
        {
            if (cboFeatures.SelectedIndex > -1)
            {
                selectedFeature = (Feature)cboFeatures.SelectedItem;
                txtFeatureName.Text = selectedFeature.FeatureName;
                txtFeatureName.Focus();
                grbFeature.Text = $"Editing: {selectedFeature.FeatureName}";
                btnAddFeature.Visible = false;
                btnSave.Location = new System.Drawing.Point(319, 61);
                btnCancel.Location = new System.Drawing.Point(245, 61);
                btnCancel.Visible = true;
                btnSave.Visible = true;
            }
        }
        private void btnDeleteFeature_Click(object sender, EventArgs e)
        {
            if (cboFeatures.SelectedIndex > -1)
            {
                selectedFeature = (Feature)cboFeatures.SelectedItem;
                DialogResult dr = MessageBox.Show($"Are you sure you wanted to delete {selectedFeature.FeatureName}?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    db.Features.Remove(selectedFeature);
                db.SaveChanges();
                GetFeatures();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFeatureName.Text != "")
            {
                selectedFeature.FeatureName = txtFeatureName.Text.Trim();
                MessageBox.Show($"{selectedFeature.FeatureName} edited successfully!");
                db.SaveChanges();
                ResetForm();
                GetFeatures();
                cboFeatures.SelectedItem = selectedFeature;
            }
            else
                NameValidation();
        }
        private void btnAddFeature_Click(object sender, EventArgs e)
        {
            if (txtFeatureName.Text != "")
            {
                Feature feature = new Feature() { FeatureName = txtFeatureName.Text.Trim() };
                db.Features.Add(feature);
                MessageBox.Show($"{feature.FeatureName} added successfully!");
                db.SaveChanges();
                ResetForm();
                GetFeatures();
                cboFeatures.SelectedItem = feature;
            }
            else
                NameValidation();
        }
    }
}
