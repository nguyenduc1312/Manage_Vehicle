using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Duc_manage_vehicle.DTO;
using Duc_manage_vehicle.Common;
namespace Duc_manage_vehicle.DAO
{
    internal class UserDAO
    {
        DBConnect dbCon = new DBConnect();
        public DataTable queryUser(Account account)
        {
            DataTable da = new DataTable();

            string user_id = account.user_id;
            string fullname = account.fullname;
            string phone = account.user_phone;
            string sqlString = "select * from tbl_user where ('' = '" + user_id + "' or user_id like '" + user_id + "') " +
                                                             "and ('' = '" + fullname + "' or fullname like '" + fullname + "') " +
                                                             "and ('' = '" + phone + "' or user_phone_number like '" + phone + "')";
            da = dbCon.getTable(sqlString);
            return da;
        }

        public int addUser(Account account)
        {
            int check = 0;
            string user_id = account.user_id;
            string password = account.password;
            string fullname = account.fullname;
            string idcard = account.user_identity_card_num;
            string phone = account.user_phone;
            string sqlString = "INSERT INTO tbl_user values('" + user_id + "', '" + password + "', '" + fullname + "', '" + idcard + "' ,'" + phone + "')";
            check = dbCon.ExcuteNonQuery(sqlString);
            return check;
        }
    }
}
