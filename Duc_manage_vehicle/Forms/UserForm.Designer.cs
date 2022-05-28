namespace Duc_manage_vehicle.Forms
{
    partial class UserForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdvUser = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIdCardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 90);
            this.panel1.TabIndex = 0;
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(643, 50);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 25);
            this.txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(530, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.Location = new System.Drawing.Point(350, 50);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(150, 25);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(270, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(90, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdvUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 380);
            this.panel2.TabIndex = 1;
            // 
            // grdvUser
            // 
            this.grdvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.Username,
            this.Password,
            this.FullName,
            this.Phone,
            this.UserIdCardNum});
            this.grdvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdvUser.Location = new System.Drawing.Point(0, 0);
            this.grdvUser.Name = "grdvUser";
            this.grdvUser.RowTemplate.Height = 25;
            this.grdvUser.Size = new System.Drawing.Size(832, 380);
            this.grdvUser.TabIndex = 0;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Width = 50;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "user_id";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Visible = false;
            this.Password.Width = 200;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "fullname";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.Width = 239;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "user_phone_number";
            this.Phone.HeaderText = "PhoneNumber";
            this.Phone.Name = "Phone";
            this.Phone.Width = 200;
            // 
            // UserIdCardNum
            // 
            this.UserIdCardNum.DataPropertyName = "user_identity_card_num";
            this.UserIdCardNum.HeaderText = "Id Card Number";
            this.UserIdCardNum.Name = "UserIdCardNum";
            this.UserIdCardNum.Width = 200;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private Panel panel2;
        private DataGridView grdvUser;
        private Button btnSearch;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn UserIdCardNum;
        private Button btnAdd;
    }
}