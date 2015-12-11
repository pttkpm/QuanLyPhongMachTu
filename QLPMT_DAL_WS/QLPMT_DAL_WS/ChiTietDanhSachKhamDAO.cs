using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QLHS2010;

namespace QLPMT_DAL_WS
{
    public class ChiTietDanhSachKhamDAO : DataProvider
    {
        public ChiTietDanhSachKhamDAO()
        {
            connect();
        }

        public void insert(ChiTietDanhSachKhamDTO info)
        {
            string insertCommand = string.Format("INSERT INTO CHITIETDANHSACHKHAM VALUES('{0}', '{1}')",
                info.MaDanhSachKham, info.MaBenhNhan);

            executeNonQuery(insertCommand);
        }
    }
}