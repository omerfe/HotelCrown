
namespace HotelCrown
{
    partial class RoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbRoom = new System.Windows.Forms.GroupBox();
            this.lsbFeatures = new System.Windows.Forms.ListBox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nudRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnAddNewRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.grbRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Available Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Room Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(407, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Features";
            // 
            // grbRoom
            // 
            this.grbRoom.Controls.Add(this.lsbFeatures);
            this.grbRoom.Controls.Add(this.btnCancel);
            this.grbRoom.Controls.Add(this.nudRoomNumber);
            this.grbRoom.Controls.Add(this.btnSave);
            this.grbRoom.Controls.Add(this.btnAddRoom);
            this.grbRoom.Controls.Add(this.label1);
            this.grbRoom.Controls.Add(this.nudPrice);
            this.grbRoom.Controls.Add(this.nudCapacity);
            this.grbRoom.Controls.Add(this.txtRoomName);
            this.grbRoom.Controls.Add(this.label3);
            this.grbRoom.Controls.Add(this.label6);
            this.grbRoom.Controls.Add(this.label4);
            this.grbRoom.Controls.Add(this.label5);
            this.grbRoom.ForeColor = System.Drawing.Color.White;
            this.grbRoom.Location = new System.Drawing.Point(17, 468);
            this.grbRoom.Name = "grbRoom";
            this.grbRoom.Size = new System.Drawing.Size(728, 348);
            this.grbRoom.TabIndex = 34;
            this.grbRoom.TabStop = false;
            this.grbRoom.Text = "New Room";
            // 
            // lsbFeatures
            // 
            this.lsbFeatures.FormattingEnabled = true;
            this.lsbFeatures.ItemHeight = 19;
            this.lsbFeatures.Location = new System.Drawing.Point(411, 62);
            this.lsbFeatures.Name = "lsbFeatures";
            this.lsbFeatures.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbFeatures.Size = new System.Drawing.Size(298, 270);
            this.lsbFeatures.TabIndex = 72;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnCancel.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(155, 267);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 65);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudRoomNumber
            // 
            this.nudRoomNumber.Location = new System.Drawing.Point(156, 63);
            this.nudRoomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoomNumber.Name = "nudRoomNumber";
            this.nudRoomNumber.Size = new System.Drawing.Size(198, 27);
            this.nudRoomNumber.TabIndex = 44;
            this.nudRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRoomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(228, 267);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 65);
            this.btnSave.TabIndex = 70;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.ActiveBorderThickness = 1;
            this.btnAddRoom.ActiveCornerRadius = 20;
            this.btnAddRoom.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddRoom.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.BackgroundImage")));
            this.btnAddRoom.ButtonText = "Add";
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnAddRoom.IdleBorderThickness = 1;
            this.btnAddRoom.IdleCornerRadius = 20;
            this.btnAddRoom.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnAddRoom.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnAddRoom.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.Location = new System.Drawing.Point(294, 268);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(59, 64);
            this.btnAddRoom.TabIndex = 69;
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Room Number";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(156, 199);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(198, 27);
            this.nudPrice.TabIndex = 41;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(156, 153);
            this.nudCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(198, 27);
            this.nudCapacity.TabIndex = 40;
            this.nudCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(156, 107);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(198, 27);
            this.txtRoomName.TabIndex = 39;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(17, 48);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(733, 341);
            this.dgvRooms.TabIndex = 65;
            // 
            // btnAddNewRoom
            // 
            this.btnAddNewRoom.ActiveBorderThickness = 1;
            this.btnAddNewRoom.ActiveCornerRadius = 20;
            this.btnAddNewRoom.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddNewRoom.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddNewRoom.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddNewRoom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNewRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewRoom.BackgroundImage")));
            this.btnAddNewRoom.ButtonText = "Add New Room";
            this.btnAddNewRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewRoom.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnAddNewRoom.IdleBorderThickness = 1;
            this.btnAddNewRoom.IdleCornerRadius = 20;
            this.btnAddNewRoom.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnAddNewRoom.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNewRoom.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddNewRoom.Location = new System.Drawing.Point(17, 398);
            this.btnAddNewRoom.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.Size = new System.Drawing.Size(161, 65);
            this.btnAddNewRoom.TabIndex = 68;
            this.btnAddNewRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewRoom.Click += new System.EventHandler(this.btnAddNewRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.ActiveBorderThickness = 1;
            this.btnEditRoom.ActiveCornerRadius = 20;
            this.btnEditRoom.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEditRoom.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditRoom.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditRoom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditRoom.BackgroundImage")));
            this.btnEditRoom.ButtonText = "Edit";
            this.btnEditRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditRoom.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnEditRoom.IdleBorderThickness = 1;
            this.btnEditRoom.IdleCornerRadius = 20;
            this.btnEditRoom.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnEditRoom.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnEditRoom.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditRoom.Location = new System.Drawing.Point(618, 398);
            this.btnEditRoom.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(58, 65);
            this.btnEditRoom.TabIndex = 67;
            this.btnEditRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.ActiveBorderThickness = 1;
            this.btnDeleteRoom.ActiveCornerRadius = 20;
            this.btnDeleteRoom.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteRoom.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteRoom.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteRoom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoom.BackgroundImage")));
            this.btnDeleteRoom.ButtonText = "Delete";
            this.btnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDeleteRoom.IdleBorderThickness = 1;
            this.btnDeleteRoom.IdleCornerRadius = 20;
            this.btnDeleteRoom.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnDeleteRoom.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteRoom.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteRoom.Location = new System.Drawing.Point(690, 398);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(7);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(60, 65);
            this.btnDeleteRoom.TabIndex = 66;
            this.btnDeleteRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(757, 466);
            this.Controls.Add(this.btnAddNewRoom);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.grbRoom);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.grbRoom.ResumeLayout(false);
            this.grbRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbRoom;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRooms;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddNewRoom;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditRoom;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteRoom;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddRoom;
        private System.Windows.Forms.ListBox lsbFeatures;
    }
}