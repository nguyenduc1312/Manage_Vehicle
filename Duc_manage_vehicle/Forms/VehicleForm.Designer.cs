namespace Duc_manage_vehicle.Forms
{
    partial class VehicleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtToRent = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehicleId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFrRent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeVehicle = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtFrDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdvVehicle = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeVehicle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtToDate);
            this.panel1.Controls.Add(this.txtFrDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbTypeVehicle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtToRent);
            this.panel1.Controls.Add(this.txtLicense);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtVehicleId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtFrRent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 119);
            this.panel1.TabIndex = 1;
            // 
            // txtToRent
            // 
            this.txtToRent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToRent.Location = new System.Drawing.Point(715, 40);
            this.txtToRent.Name = "txtToRent";
            this.txtToRent.Size = new System.Drawing.Size(90, 25);
            this.txtToRent.TabIndex = 14;
            this.txtToRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToRent_KeyPress);
            // 
            // txtLicense
            // 
            this.txtLicense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLicense.Location = new System.Drawing.Point(365, 40);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(150, 25);
            this.txtLicense.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(270, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "License Plate";
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVehicleId.Location = new System.Drawing.Point(90, 40);
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.Size = new System.Drawing.Size(150, 25);
            this.txtVehicleId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vehicle Id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.Image = global::Duc_manage_vehicle.Properties.Resources.icons8_edit_16;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(170, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDelete.Image = global::Duc_manage_vehicle.Properties.Resources.icons8_trash_161;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(255, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.Image = global::Duc_manage_vehicle.Properties.Resources.icons8_document_16;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(85, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.Image = global::Duc_manage_vehicle.Properties.Resources.icons8_search_16;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFrRent
            // 
            this.txtFrRent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFrRent.Location = new System.Drawing.Point(620, 40);
            this.txtFrRent.Name = "txtFrRent";
            this.txtFrRent.Size = new System.Drawing.Size(90, 25);
            this.txtFrRent.TabIndex = 5;
            this.txtFrRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrRent_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(545, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rent Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(835, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type Vehicle";
            // 
            // cbTypeVehicle
            // 
            this.cbTypeVehicle.FormattingEnabled = true;
            this.cbTypeVehicle.Location = new System.Drawing.Point(932, 40);
            this.cbTypeVehicle.Name = "cbTypeVehicle";
            this.cbTypeVehicle.Size = new System.Drawing.Size(150, 23);
            this.cbTypeVehicle.TabIndex = 16;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(91, 80);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 23);
            this.cbStatus.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status";
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToDate.Location = new System.Drawing.Point(459, 80);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(90, 25);
            this.txtToDate.TabIndex = 21;
            // 
            // txtFrDate
            // 
            this.txtFrDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFrDate.Location = new System.Drawing.Point(364, 80);
            this.txtFrDate.Name = "txtFrDate";
            this.txtFrDate.Size = new System.Drawing.Size(90, 25);
            this.txtFrDate.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(289, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Buy date";
            // 
            // grdvVehicle
            // 
            this.grdvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.VehicleId,
            this.LicensePlates,
            this.TypeVehicle,
            this.VehicleName,
            this.Price,
            this.Status,
            this.PurchaseDate,
            this.SeatNum});
            this.grdvVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdvVehicle.Location = new System.Drawing.Point(0, 119);
            this.grdvVehicle.Name = "grdvVehicle";
            this.grdvVehicle.RowTemplate.Height = 25;
            this.grdvVehicle.Size = new System.Drawing.Size(1264, 526);
            this.grdvVehicle.TabIndex = 2;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Width = 50;
            // 
            // VehicleId
            // 
            this.VehicleId.DataPropertyName = "vehicle_id";
            this.VehicleId.HeaderText = "Vehicle Id";
            this.VehicleId.Name = "VehicleId";
            this.VehicleId.ReadOnly = true;
            this.VehicleId.Width = 150;
            // 
            // LicensePlates
            // 
            this.LicensePlates.DataPropertyName = "license_plates";
            this.LicensePlates.HeaderText = "License Plates";
            this.LicensePlates.Name = "LicensePlates";
            this.LicensePlates.Width = 150;
            // 
            // TypeVehicle
            // 
            this.TypeVehicle.DataPropertyName = "type_vehicle";
            this.TypeVehicle.HeaderText = "Type Vehicle";
            this.TypeVehicle.Name = "TypeVehicle";
            this.TypeVehicle.Width = 150;
            // 
            // VehicleName
            // 
            this.VehicleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VehicleName.DataPropertyName = "vehicle_name";
            this.VehicleName.HeaderText = "Vehicle Name";
            this.VehicleName.Name = "VehicleName";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "rent_price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "vehicle_status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 150;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "purchase_date";
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Width = 150;
            // 
            // SeatNum
            // 
            this.SeatNum.DataPropertyName = "seat_num";
            this.SeatNum.HeaderText = "Seat Number";
            this.SeatNum.Name = "SeatNum";
            this.SeatNum.Width = 70;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 645);
            this.Controls.Add(this.grdvVehicle);
            this.Controls.Add(this.panel1);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtLicense;
        private Label label2;
        private TextBox txtVehicleId;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtFrRent;
        private Label label3;
        private TextBox txtToRent;
        private TextBox txtToDate;
        private TextBox txtFrDate;
        private Label label6;
        private ComboBox cbStatus;
        private Label label5;
        private ComboBox cbTypeVehicle;
        private Label label4;
        private DataGridView grdvVehicle;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn VehicleId;
        private DataGridViewTextBoxColumn LicensePlates;
        private DataGridViewComboBoxColumn TypeVehicle;
        private DataGridViewTextBoxColumn VehicleName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn PurchaseDate;
        private DataGridViewTextBoxColumn SeatNum;
        private DataGridViewComboBoxColumn Status;
    }
}