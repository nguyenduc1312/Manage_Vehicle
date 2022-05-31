using Duc_manage_vehicle.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duc_manage_vehicle.DAO
{
    internal class VehicleDAO
    {
        DBConnect dbCon = new DBConnect();

        public DataTable getVehicleStatus()
        {
            DataTable da = new DataTable();
            string sqlStr = "SELECT minor_cd, minor_nm FROM tbl_minor WHERE major_cd = '1'";
            da = dbCon.getTable(sqlStr);
            return da;
        }

        public DataTable getTypeVehicle()
        {
            DataTable da = new DataTable();
            string sqlStr = "SELECT minor_cd, minor_nm FROM tbl_minor WHERE major_cd = '2'";
            da = dbCon.getTable(sqlStr);
            return da;
        }
    }
}
