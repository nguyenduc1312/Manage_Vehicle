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
    public partial class UserForm : Form
    {
        UserDAO userDAO = new UserDAO();
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable da = new DataTable();

            Account account = new Account();
            account.user_id = txtUsername.Text + "";
            account.fullname = txtFullName.Text + "";
            account.user_phone = txtPhone.Text + "";

            da = userDAO.queryUser(account);
            grdvUser.DataSource = da;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }
    }
}
