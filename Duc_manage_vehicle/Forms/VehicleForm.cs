using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Duc_manage_vehicle.Common;
using Duc_manage_vehicle.DAO;

namespace Duc_manage_vehicle.Forms
{
    public partial class VehicleForm : Form
    {
        CommonThings common = new CommonThings();
        VehicleDAO vehicleDAO = new VehicleDAO();
        public VehicleForm()
        {
            InitializeComponent();
            CBDataStatus();
            CBDataVehicleType();
        }

        public void CBDataStatus()
        {
            DataTable daStatus = vehicleDAO.getVehicleStatus();
            daStatus.Rows.Add("", "");
            cbStatus.DataSource = daStatus;
            cbStatus.DisplayMember = "minor_nm";
            cbStatus.ValueMember = "minor_cd";
            cbStatus.SelectedValue = "";
        }

        public void CBDataVehicleType()
        {
            DataTable daType = vehicleDAO.getTypeVehicle();
            daType.Rows.Add("", "");
            cbTypeVehicle.DataSource = daType;
            cbTypeVehicle.DisplayMember = "minor_nm";
            cbTypeVehicle.ValueMember = "minor_cd";
            cbTypeVehicle.SelectedValue = "";
        }

        private void txtFrRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            common.charIsDigit(txtFrRent.Text, e);
        }

        private void txtToRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            common.charIsDigit(txtToRent.Text, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
