
namespace HotelCrown
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btnNewReservation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditReservation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteReservation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblClose = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRooms,
            this.tsmFeatures,
            this.tsmServices,
            this.tsmCustomers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmRooms
            // 
            this.tsmRooms.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmRooms.Name = "tsmRooms";
            this.tsmRooms.Size = new System.Drawing.Size(61, 20);
            this.tsmRooms.Text = "Rooms";
            this.tsmRooms.Click += new System.EventHandler(this.tsmRooms_Click);
            // 
            // tsmFeatures
            // 
            this.tsmFeatures.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsmFeatures.Name = "tsmFeatures";
            this.tsmFeatures.Size = new System.Drawing.Size(73, 20);
            this.tsmFeatures.Text = "Features";
            this.tsmFeatures.Click += new System.EventHandler(this.tsmFeatures_Click);
            // 
            // tsmServices
            // 
            this.tsmServices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsmServices.Name = "tsmServices";
            this.tsmServices.Size = new System.Drawing.Size(72, 20);
            this.tsmServices.Text = "Services";
            this.tsmServices.Click += new System.EventHandler(this.tsmServices_Click);
            // 
            // tsmCustomers
            // 
            this.tsmCustomers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsmCustomers.Name = "tsmCustomers";
            this.tsmCustomers.Size = new System.Drawing.Size(86, 20);
            this.tsmCustomers.Text = "Customers";
            this.tsmCustomers.Click += new System.EventHandler(this.tsmCustomers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservations";
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(21, 81);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.Size = new System.Drawing.Size(1160, 500);
            this.dgvReservations.TabIndex = 2;
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.ActiveBorderThickness = 1;
            this.btnNewReservation.ActiveCornerRadius = 20;
            this.btnNewReservation.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNewReservation.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewReservation.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewReservation.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewReservation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewReservation.BackgroundImage")));
            this.btnNewReservation.ButtonText = "NEW RESERVATION";
            this.btnNewReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReservation.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnNewReservation.IdleBorderThickness = 1;
            this.btnNewReservation.IdleCornerRadius = 20;
            this.btnNewReservation.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnNewReservation.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnNewReservation.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewReservation.Location = new System.Drawing.Point(21, 591);
            this.btnNewReservation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(241, 55);
            this.btnNewReservation.TabIndex = 3;
            this.btnNewReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewReservation.Click += new System.EventHandler(this.btnNewReservation_Click);
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.ActiveBorderThickness = 1;
            this.btnEditReservation.ActiveCornerRadius = 20;
            this.btnEditReservation.ActiveFillColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEditReservation.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditReservation.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditReservation.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditReservation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditReservation.BackgroundImage")));
            this.btnEditReservation.ButtonText = "EDIT";
            this.btnEditReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReservation.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnEditReservation.IdleBorderThickness = 1;
            this.btnEditReservation.IdleCornerRadius = 20;
            this.btnEditReservation.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnEditReservation.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnEditReservation.IdleLineColor = System.Drawing.Color.LemonChiffon;
            this.btnEditReservation.Location = new System.Drawing.Point(278, 591);
            this.btnEditReservation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.Size = new System.Drawing.Size(241, 55);
            this.btnEditReservation.TabIndex = 3;
            this.btnEditReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditReservation.Click += new System.EventHandler(this.btnEditReservation_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.ActiveBorderThickness = 1;
            this.btnDeleteReservation.ActiveCornerRadius = 20;
            this.btnDeleteReservation.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btnDeleteReservation.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteReservation.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteReservation.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteReservation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteReservation.BackgroundImage")));
            this.btnDeleteReservation.ButtonText = "DELETE";
            this.btnDeleteReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDeleteReservation.IdleBorderThickness = 1;
            this.btnDeleteReservation.IdleCornerRadius = 20;
            this.btnDeleteReservation.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnDeleteReservation.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteReservation.IdleLineColor = System.Drawing.Color.Crimson;
            this.btnDeleteReservation.Location = new System.Drawing.Point(940, 591);
            this.btnDeleteReservation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(241, 55);
            this.btnDeleteReservation.TabIndex = 3;
            this.btnDeleteReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClose.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblClose.Location = new System.Drawing.Point(1165, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 23);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1199, 658);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnEditReservation);
            this.Controls.Add(this.btnNewReservation);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Crown";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmRooms;
        private System.Windows.Forms.ToolStripMenuItem tsmFeatures;
        private System.Windows.Forms.ToolStripMenuItem tsmServices;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservations;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewReservation;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditReservation;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteReservation;
        private System.Windows.Forms.Label lblClose;
    }
}

