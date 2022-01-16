
namespace HotelCrown
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddReservation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lsbCustomers = new System.Windows.Forms.ListBox();
            this.lsbRooms = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbServices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rooms";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCheckInDate.Location = new System.Drawing.Point(214, 336);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(255, 27);
            this.dtpCheckInDate.TabIndex = 5;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.CalendarForeColor = System.Drawing.Color.PaleVioletRed;
            this.dtpCheckOutDate.CalendarTitleForeColor = System.Drawing.Color.PaleVioletRed;
            this.dtpCheckOutDate.CalendarTrailingForeColor = System.Drawing.Color.PaleVioletRed;
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCheckOutDate.Location = new System.Drawing.Point(214, 385);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(255, 27);
            this.dtpCheckOutDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "CheckIn Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 387);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "CheckOut Date:";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.ActiveBorderThickness = 1;
            this.btnAddReservation.ActiveCornerRadius = 20;
            this.btnAddReservation.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddReservation.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddReservation.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddReservation.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddReservation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddReservation.BackgroundImage")));
            this.btnAddReservation.ButtonText = "Add New Reservation";
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddReservation.IdleBorderThickness = 1;
            this.btnAddReservation.IdleCornerRadius = 20;
            this.btnAddReservation.IdleFillColor = System.Drawing.Color.White;
            this.btnAddReservation.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnAddReservation.IdleLineColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddReservation.Location = new System.Drawing.Point(16, 426);
            this.btnAddReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(453, 47);
            this.btnAddReservation.TabIndex = 11;
            this.btnAddReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // lsbCustomers
            // 
            this.lsbCustomers.FormattingEnabled = true;
            this.lsbCustomers.ItemHeight = 19;
            this.lsbCustomers.Location = new System.Drawing.Point(16, 35);
            this.lsbCustomers.Name = "lsbCustomers";
            this.lsbCustomers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbCustomers.Size = new System.Drawing.Size(138, 270);
            this.lsbCustomers.TabIndex = 73;
            // 
            // lsbRooms
            // 
            this.lsbRooms.FormattingEnabled = true;
            this.lsbRooms.ItemHeight = 19;
            this.lsbRooms.Location = new System.Drawing.Point(170, 35);
            this.lsbRooms.Name = "lsbRooms";
            this.lsbRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbRooms.Size = new System.Drawing.Size(143, 270);
            this.lsbRooms.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(320, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "Services";
            // 
            // lsbServices
            // 
            this.lsbServices.FormattingEnabled = true;
            this.lsbServices.ItemHeight = 19;
            this.lsbServices.Location = new System.Drawing.Point(326, 35);
            this.lsbServices.Name = "lsbServices";
            this.lsbServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbServices.Size = new System.Drawing.Size(143, 270);
            this.lsbServices.TabIndex = 76;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(486, 481);
            this.Controls.Add(this.lsbServices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbRooms);
            this.Controls.Add(this.lsbCustomers);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.dtpCheckInDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddReservation;
        private System.Windows.Forms.ListBox lsbCustomers;
        private System.Windows.Forms.ListBox lsbRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbServices;
    }
}