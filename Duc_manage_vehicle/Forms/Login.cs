using Duc_manage_vehicle.DAO;
using Duc_manage_vehicle.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duc_manage_vehicle.Forms
{
    public partial class Login : Form
    {
        LoginDAO loginDAO = new LoginDAO();
        CommonThings common = new CommonThings();
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text + "";
            string password = txtPassword.Text + "";
            string passwordMD5 = common.CreateMD5Hash(password);

            DataTable dt = new DataTable();
            try
            {
                dt = loginDAO.login(userName, passwordMD5);
                if(dt.Rows.Count > 0)
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
