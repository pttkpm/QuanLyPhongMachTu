using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QLHS2010;

namespace QLPMT_DAL_WS
{
    public class DanhSachKhamDAO : DataProvider
    {
        public DanhSachKhamDAO()
        {
            connect();
        }

        public void insert(DanhSachKhamDTO info)
        {
            string insertCommand = string.Format("INSERT INTO DANHSACHKHAM VALUES('{0}', '{1}')",
                info.MaDanhSach, info.NgayLap);

            executeNonQuery(insertCommand);
        }

        public BenhNhanDTO[] getListDanhSachKham(string NgayLap)
        {
            string query = string.Format("select bn.MaBenhNhan, bn.HoTen, bn.DiaChi, bn.GioiTinh, bn.NamSinh from DanhSachKham dsk, CHITIETDANHSACHKHAM ct, BENHNHAN bn where dsk.MaDanhSach = ct.MaDanhSachKham and ct.MaBenhNhan = bn.MaBenhNhan and dsk.NgayLap = = '{0}'", NgayLap);
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            DanhSachKhamDTO dsk = new DanhSachKhamDTO();
            BenhNhanDAO tmp = new BenhNhanDAO();

            DataTable dt = dataset.Tables[0];
            int i, n = dt.Rows.Count;
            dsk.BENHNHANs = new BenhNhanDTO[n];
            
            for (i = 0; i < n; i++)
            {
                object ob = tmp.GetDataFromDataRow(dt, i);
                dsk.BENHNHANs[i] = (BenhNhanDTO)ob;
            }
            return dsk.BENHNHANs.ToArray();
        }


    }
}