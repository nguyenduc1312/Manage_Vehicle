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

        public DataTable queryVehicle(string vehicle_id,string license_plates,string FrPrice, string ToPrice, string type_vehicle, string status)
        {
            DataTable da = new DataTable();
            string sqlStr = "SELECT A.vehicle_id AS vehicle_id, " +
                                   "A.license_plates AS license_plates, " +
                                   "B.minor_nm AS type_vehicle, " +
                                   "A.vehicle_name AS vehicle_name, " +
                                   "C.price AS price, " +
                                   "D.minor_nm as status, " +
                                   "A.purchase_date AS purchase_date, " +
                                   "A.seat_num as seat_num " +
                             "FROM ( " +
                                  "( " +
                                  "tbl_vehicle AS A " +
                                   "LEFT JOIN tbl_minor AS B ON A.type_vehicle = B.minor_cd ) " +
                                   "LEFT JOIN tbl_price AS C ON A.vehicle_id = C.vehicle_id ) " +
                                   "LEFT JOIN tbl_minor AS D ON A.vehicle_status = D.minor_cd " +
                             "WHERE ('' = '" + vehicle_id + "' or A.[vehicle_id] = '" + vehicle_id + "') " +
                                    "AND ('' = '" + license_plates + "' or A.[license_plates] = '" + license_plates + "') " +
                                    "AND ('' = '" + license_plates + "' or A.[license_plates] = '" + license_plates + "') " +
                                    "AND (FrPrice <= C.[price] AND C.[price] => ToPrice) " +
                                    "AND ('' = '" + type_vehicle + "' or B.[minor_cd] = '" + type_vehicle + "') " +
                                    "AND ('' = '" + status + "' or D.[minor_cd] = '" + status + "')";
            da = dbCon.getTable(sqlStr);
            return da;
        }
    }
}
