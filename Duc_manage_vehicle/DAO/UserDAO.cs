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
        public DataTable queryUsers(Account account)
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

        public int deleteUser(string user_id)
        {
            int check = 0;
            string sqlString = "DELETE FROM tbl_user WHERE user_id = '" + user_id + "'";
            check = dbCon.ExcuteNonQuery(sqlString);
            return check;
        }

        public DataTable queryUser(string user_id)
        {
            DataTable da = new DataTable();
            string sqlString = "SELECT * FROM tbl_user WHERE user_id = '" + user_id + "'";
            da = dbCon.getTable(sqlString);
            return da;
        }

        public int UpdateUser(Account account)
        {
            int check = 0;
            string user_id = account.user_id;
            string password = account.password;
            string fullname = account.fullname;
            string idNum = account.user_identity_card_num;
            string phoneNum = account.user_phone;

            string sqlString = "UPDATE [tbl_user] " +
                               "SET [password] = '" + password + "', [fullname] = '" + fullname + "', [user_identity_card_num] = '" + idNum + "', [user_phone_number] = '" + phoneNum + "' " +
                               "WHERE [user_id] = '" + user_id + "'";
            check = dbCon.ExcuteNonQuery(sqlString);
            return check;
        }

        public List<Account> convertToListUser(DataTable dt)
        {
            var convertedList = (from rw in dt.AsEnumerable()
                                 select new Account()
                                 {
                                     user_id = Convert.ToString(rw["user_id"]),
                                     password = Convert.ToString(rw["password"]),
                                     fullname = Convert.ToString(rw["fullname"]),
                                     user_identity_card_num = Convert.ToString(rw["user_identity_card_num"]),
                                     user_phone = Convert.ToString(rw["user_phone"]),
                                 }).ToList();

            return convertedList;
        }

        public Account convertToUser(DataTable dt)
        {
            var convertedList = (from rw in dt.AsEnumerable()
                                 select new Account()
                                 {
                                     user_id = Convert.ToString(rw["user_id"]),
                                     password = Convert.ToString(rw["password"]),
                                     fullname = Convert.ToString(rw["fullname"]),
                                     user_identity_card_num = Convert.ToString(rw["user_identity_card_num"]),
                                     user_phone = Convert.ToString(rw["user_phone_number"]),
                                 }).ToList();

            return convertedList[0];
        }
    }
}
