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
    public partial class HomePage : Form
    {
        private Form activeForm;

        public HomePage()
        {
            InitializeComponent();
        }

        public void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelChildForm.Text = childForm.Text;
        }

        private void btnUserPage_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.UserForm(), sender);
        }
    }
}
