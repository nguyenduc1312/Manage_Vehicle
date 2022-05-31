using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Duc_manage_vehicle.DTO;
using Duc_manage_vehicle.DAO;

namespace Duc_manage_vehicle.Forms
{
    public partial class AddUser : Form
    {
        UserDAO userDAO = new UserDAO();
        public AddUser()
        {
            InitializeComponent();
        }

        public AddUser(string user_id)
        {
            InitializeComponent();
            txtUserId.ReadOnly = true;
            DataTable da = userDAO.queryUser(user_id);
            Account account = userDAO.convertToUser(da);
            txtUserId.Text = account.user_id + "";
            txtPassword.Text = account.password + "";
            txtConfirmPass.Text = account.password + "";
            txtFullname.Text = account.fullname + "";
            txtIdCard.Text = account.user_identity_card_num + "";
            txtPhone.Text = account.user_phone + "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.user_id = txtUserId.Text + "";
            account.password = txtPassword.Text + "";
            string confPass = txtConfirmPass.Text + "";
            account.fullname = txtFullname.Text + "";
            account.user_identity_card_num = txtIdCard.Text + "";
            account.user_phone = txtPhone.Text + "";

            if (txtUserId.ReadOnly != true)
            {
                if (account.user_id == "" || account.password == "" || confPass == "")
                {
                    MessageBox.Show("You have to enter required feilds!");
                    lblUsername.ForeColor = Color.Red;
                    lblPass.ForeColor = Color.Red;
                    lblConfirm.ForeColor = Color.Red;
                }
                else if (account.password != confPass)
                {
                    MessageBox.Show("Password and Confirm password must be the same!");
                }
                else
                {
                    lblUsername.ForeColor = Color.Black;
                    lblPass.ForeColor = Color.Black;
                    lblConfirm.ForeColor = Color.Black;
                    int check = userDAO.addUser(account);
                    if (check == 0)
                    {
                        MessageBox.Show("Register Failed!");
                    }
                    else
                    {
                        MessageBox.Show("Register Success!");
                        this.Close();
                    }
                }
            }
            else
            {
                if (account.password == "" || confPass == "")
                {
                    MessageBox.Show("You have to enter required feilds!");
                    lblPass.ForeColor = Color.Red;
                    lblConfirm.ForeColor = Color.Red;
                }
                else if (account.password != confPass)
                {
                    MessageBox.Show("Password and Confirm password must be the same!");
                }
                else
                {
                    lblUsername.ForeColor = Color.Black;
                    lblPass.ForeColor = Color.Black;
                    lblConfirm.ForeColor = Color.Black;
                    int check = userDAO.UpdateUser(account);
                    if (check == 0)
                    {
                        MessageBox.Show("Update Failed!");
                    }
                    else
                    {
                        MessageBox.Show("Update Success!");
                        this.Close();
                    }
                }
            }
        }

        private void txtIdCard_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIdCard.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtIdCard.Text = txtIdCard.Text.Remove(txtIdCard.Text.Length - 1);
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
