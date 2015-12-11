using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QLHS2010;

namespace QLPMT_DAL_WS
{
    public class BenhNhanDAO : DataProvider
    {
        public BenhNhanDAO()
        {
            connect();
        }

        public void insert(BenhNhanDTO info)
        {
            string insertCommand = string.Format("INSERT INTO BENHNHAN VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                info.MaBenhNhan, info.HoTen, info.DiaChi, info.GioiTinh, info.NamSinh);

            executeNonQuery(insertCommand);
        }

        public override object GetDataFromDataRow(DataTable dt, int i)
        {
            BenhNhanDTO ob = new BenhNhanDTO();
            ob.MaBenhNhan = dt.Rows[i]["MaBenhNhan"].ToString();
            ob.HoTen = dt.Rows[i]["HoTen"].ToString();
            ob.DiaChi = dt.Rows[i]["DiaChi"].ToString();
            ob.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
            ob.NamSinh = Convert.ToInt32(dt.Rows[i]["NamSinh"]);

            return (object)ob;
        }

        public int countNumberofBenhNhan()
        {
            string sql = "Select count(*) as SL from BENHNHAN";
            adapter = new SqlDataAdapter(sql, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            DataTable dt = dataset.Tables[0];
            int res = Convert.ToInt32(dt.Rows[0]["SL"]);
            return res;
        }

        public int isExist(BenhNhanDTO ob)
        {
            string sql = string.Format(
                    "Select count(*) as SL from BENHNHAN where HoTen = '{0}' and GioiTinh = '{1}' and DiaChi = '{2}' and NamSinh = '{3}'",
                    ob.HoTen, ob.GioiTinh, ob.DiaChi, ob.NamSinh);
            adapter = new SqlDataAdapter(sql, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            DataTable dt = dataset.Tables[0];
            int res = Convert.ToInt32(dt.Rows[0]["SL"]);
            if (res > 0)
                return countNumberofBenhNhan();
            else
            {
                return -1;
            }
        }
    }
}