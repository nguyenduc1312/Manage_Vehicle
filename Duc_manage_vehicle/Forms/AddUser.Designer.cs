namespace Duc_manage_vehicle.Forms
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(92, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Account";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserId.Location = new System.Drawing.Point(130, 100);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(150, 25);
            this.txtUserId.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(50, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(130, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 25);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.Location = new System.Drawing.Point(50, 140);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 20);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
            // 
            // txtIdCard
            // 
            this.txtIdCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdCard.Location = new System.Drawing.Point(130, 260);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(150, 25);
            this.txtIdCard.TabIndex = 11;
            this.txtIdCard.TextChanged += new System.EventHandler(this.txtIdCard_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID card Num";
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullname.Location = new System.Drawing.Point(130, 220);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(150, 25);
            this.txtFullname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Full Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(130, 300);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 25);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(130, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(226, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPass.Location = new System.Drawing.Point(130, 180);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(150, 25);
            this.txtConfirmPass.TabIndex = 17;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirm.Location = new System.Drawing.Point(0, 181);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(127, 20);
            this.lblConfirm.TabIndex = 16;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 418);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUserId;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPass;
        private TextBox txtIdCard;
        private Label label4;
        private TextBox txtFullname;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtConfirmPass;
        private Label lblConfirm;
    }
}