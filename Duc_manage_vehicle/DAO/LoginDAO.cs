using Duc_manage_vehicle.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duc_manage_vehicle.DAO
{
    internal class LoginDAO
    {
        DBConnect dbCon = new DBConnect();
        public DataTable login(string userName, string password)
        {
            DataTable da = new DataTable();
            string sql = "select * from tbl_user where user_id = '" + userName + "' and password = '" + password + "' ";
            da = dbCon.getTable(sql);
            return da;
        }
    }
}
