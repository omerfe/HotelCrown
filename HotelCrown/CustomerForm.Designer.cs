
namespace HotelCrown
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.grbCustomer = new System.Windows.Forms.GroupBox();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.rbUnspecified = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnAddCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvRegisteredCustomers = new System.Windows.Forms.DataGridView();
            this.btnAddNewCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.grbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCustomer
            // 
            this.grbCustomer.Controls.Add(this.mtxtPhoneNumber);
            this.grbCustomer.Controls.Add(this.rbUnspecified);
            this.grbCustomer.Controls.Add(this.txtDescription);
            this.grbCustomer.Controls.Add(this.label7);
            this.grbCustomer.Controls.Add(this.btnCancel);
            this.grbCustomer.Controls.Add(this.btnSave);
            this.grbCustomer.Controls.Add(this.rbFemale);
            this.grbCustomer.Controls.Add(this.btnAddCustomer);
            this.grbCustomer.Controls.Add(this.rbMale);
            this.grbCustomer.Controls.Add(this.label1);
            this.grbCustomer.Controls.Add(this.dtpBirthDate);
            this.grbCustomer.Controls.Add(this.txtIdentityNumber);
            this.grbCustomer.Controls.Add(this.txtCustomerName);
            this.grbCustomer.Controls.Add(this.label3);
            this.grbCustomer.Controls.Add(this.label6);
            this.grbCustomer.Controls.Add(this.label4);
            this.grbCustomer.Controls.Add(this.label5);
            this.grbCustomer.ForeColor = System.Drawing.Color.White;
            this.grbCustomer.Location = new System.Drawing.Point(17, 483);
            this.grbCustomer.Name = "grbCustomer";
            this.grbCustomer.Size = new System.Drawing.Size(464, 339);
            this.grbCustomer.TabIndex = 42;
            this.grbCustomer.TabStop = false;
            this.grbCustomer.Text = "New Customer";
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(167, 108);
            this.mtxtPhoneNumber.Mask = "(999) 000-0000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(281, 27);
            this.mtxtPhoneNumber.TabIndex = 64;
            // 
            // rbUnspecified
            // 
            this.rbUnspecified.AutoSize = true;
            this.rbUnspecified.Location = new System.Drawing.Point(331, 190);
            this.rbUnspecified.Name = "rbUnspecified";
            this.rbUnspecified.Size = new System.Drawing.Size(117, 23);
            this.rbUnspecified.TabIndex = 66;
            this.rbUnspecified.TabStop = true;
            this.rbUnspecified.Text = "Unspecified";
            this.rbUnspecified.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(167, 223);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(281, 27);
            this.txtDescription.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 49;
            this.label7.Text = "Description";
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
            this.btnCancel.Location = new System.Drawing.Point(250, 258);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 65);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(323, 258);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 65);
            this.btnSave.TabIndex = 64;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(239, 190);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(86, 23);
            this.rbFemale.TabIndex = 48;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ActiveBorderThickness = 1;
            this.btnAddCustomer.ActiveCornerRadius = 20;
            this.btnAddCustomer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCustomer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
            this.btnAddCustomer.ButtonText = "Add";
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnAddCustomer.IdleBorderThickness = 1;
            this.btnAddCustomer.IdleCornerRadius = 20;
            this.btnAddCustomer.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnAddCustomer.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnAddCustomer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.Location = new System.Drawing.Point(389, 259);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(59, 64);
            this.btnAddCustomer.TabIndex = 61;
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(167, 191);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 23);
            this.rbMale.TabIndex = 47;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Gender";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBirthDate.Location = new System.Drawing.Point(167, 150);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(281, 23);
            this.dtpBirthDate.TabIndex = 45;
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Location = new System.Drawing.Point(167, 67);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(281, 27);
            this.txtIdentityNumber.TabIndex = 43;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(167, 26);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(281, 27);
            this.txtCustomerName.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Identity Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Registered Customers";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.ActiveBorderThickness = 1;
            this.btnEditCustomer.ActiveCornerRadius = 20;
            this.btnEditCustomer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEditCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditCustomer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditCustomer.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.BackgroundImage")));
            this.btnEditCustomer.ButtonText = "Edit";
            this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnEditCustomer.IdleBorderThickness = 1;
            this.btnEditCustomer.IdleCornerRadius = 20;
            this.btnEditCustomer.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnEditCustomer.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnEditCustomer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditCustomer.Location = new System.Drawing.Point(618, 395);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(58, 65);
            this.btnEditCustomer.TabIndex = 63;
            this.btnEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.ActiveBorderThickness = 1;
            this.btnDeleteCustomer.ActiveCornerRadius = 20;
            this.btnDeleteCustomer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteCustomer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.BackgroundImage")));
            this.btnDeleteCustomer.ButtonText = "Delete";
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDeleteCustomer.IdleBorderThickness = 1;
            this.btnDeleteCustomer.IdleCornerRadius = 20;
            this.btnDeleteCustomer.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnDeleteCustomer.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteCustomer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(690, 395);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(7);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(60, 65);
            this.btnDeleteCustomer.TabIndex = 62;
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // dgvRegisteredCustomers
            // 
            this.dgvRegisteredCustomers.AllowUserToAddRows = false;
            this.dgvRegisteredCustomers.AllowUserToDeleteRows = false;
            this.dgvRegisteredCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisteredCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRegisteredCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisteredCustomers.Location = new System.Drawing.Point(17, 44);
            this.dgvRegisteredCustomers.MultiSelect = false;
            this.dgvRegisteredCustomers.Name = "dgvRegisteredCustomers";
            this.dgvRegisteredCustomers.ReadOnly = true;
            this.dgvRegisteredCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisteredCustomers.Size = new System.Drawing.Size(733, 341);
            this.dgvRegisteredCustomers.TabIndex = 64;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.ActiveBorderThickness = 1;
            this.btnAddNewCustomer.ActiveCornerRadius = 20;
            this.btnAddNewCustomer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddNewCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddNewCustomer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNewCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewCustomer.BackgroundImage")));
            this.btnAddNewCustomer.ButtonText = "Add New Customer";
            this.btnAddNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnAddNewCustomer.IdleBorderThickness = 1;
            this.btnAddNewCustomer.IdleCornerRadius = 20;
            this.btnAddNewCustomer.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnAddNewCustomer.IdleForecolor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNewCustomer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(17, 395);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(161, 65);
            this.btnAddNewCustomer.TabIndex = 65;
            this.btnAddNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(759, 466);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.dgvRegisteredCustomers);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.grbCustomer);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.grbCustomer.ResumeLayout(false);
            this.grbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.RadioButton rbUnspecified;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteCustomer;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneNumber;
        private System.Windows.Forms.DataGridView dgvRegisteredCustomers;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddNewCustomer;
    }
}