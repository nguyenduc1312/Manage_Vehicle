using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Duc_manage_vehicle.Common
{
    internal class DBConnect
    { 
        public OleDbConnection GetConnection()
        {
            //string strCon = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=F:\C# Projects\Duc_manage_vehicle\Duc_manage_vehicle\db\Manage_Vehicle.accdb; Jet OLEDB:Database Password=ksyserp;";
            string strCon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=F:\vs_code\Manage_Vehicle\Duc_manage_vehicle\db\Manage_Vehicle.accdb; Jet OLEDB:Database Password=ksyserp;";
            return new OleDbConnection(strCon);
        }
        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return dt;
        }
        public int ExcuteNonQuery(String sql)
        {
            int check = 0;
            try
            {
                OleDbConnection conn = GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                check = cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Clone();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return check;
        }
    }
}
