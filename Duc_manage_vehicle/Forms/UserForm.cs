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
        string globalUserId = null;

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

            da = userDAO.queryUsers(account);
            grdvUser.DataSource = da;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> listId = new List<string>();
            foreach(DataGridViewRow row in grdvUser.Rows)
            {
                DataGridViewCheckBoxCell checking = row.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checking.Value) == true)
                {
                    listId.Add(row.Cells["user_id"].Value + "");
                }
            }
            if(listId.Count > 0)
            {
                foreach(string id in listId)
                {
                    userDAO.deleteUser(id);
                }
                MessageBox.Show("Delete Successed!");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show("You didn't choose any row!");
            }
        }

        private void grdvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                DataGridViewRow row = this.grdvUser.Rows[e.RowIndex];
                if (row != null)
                    globalUserId = row.Cells["user_id"].Value + "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (globalUserId != null)
            {
                AddUser editUser = new AddUser(globalUserId);
                editUser.Show();
            }
        }
    }
}
