using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLHS2010;
using System.Data;
using System.Data.SqlClient;

namespace QLPMT_DAL_WS
{
    public class LichHenDAO : DataProvider
    {
        public LichHenDAO()
        {
            connect();
        }

        public void insert(LichHenDTO info)
        {
            string insertCommand = string.Format("INSERT INTO LICHHEN VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                info.MaLichHen, info.MaBenhNhan, info.GioKham, info.NgayHen, info.TenBacSi);

            executeNonQuery(insertCommand);
        }

        public LichHenDTO[] getListLichHen(string TenBS, string Ngayhen)
        {
            string query = string.Format("SELECT * FROM LICHHEN WHERE TenBacSi = '{0}' and NgayHen = '{1}'", TenBS, Ngayhen);
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            LichHenDTO[] arr;

            DataTable dt = dataset.Tables[0];
            int i, n = dt.Rows.Count;
            arr = new LichHenDTO[n];
            for (i = 0; i < n; i++)
            {
                object ob = GetDataFromDataRow(dt, i);
                arr[i] = (LichHenDTO)ob;
            }
            return arr;
        }

        public override object GetDataFromDataRow(DataTable dt, int i)
        {
            LichHenDTO ob = new LichHenDTO();
            ob.MaLichHen = dt.Rows[i]["MaLichHen"].ToString();
            ob.MaBenhNhan = dt.Rows[i]["MaBenhNhan"].ToString();
            ob.NgayHen = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
            ob.GioKham = DateTime.Parse(dt.Rows[i]["GioKham"].ToString());
            ob.TenBacSi = dt.Rows[i]["TenBacSi"].ToString();

            return (object)ob;
        }
    }
}