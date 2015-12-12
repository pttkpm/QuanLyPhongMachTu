using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLHS2010;

namespace QLPMT_DAL_WS
{
    public class BaoCaoDoanhThuDAO : DataProvider
    {
        public BaoCaoDoanhThuDAO()
        {
            connect();
        }

        public void insert(BaoCaoDoanhThuDTO info)
        {
            string insertCommand = string.Format("INSERT INTO BAOCAODOANHTHU VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                info.MaBCDT, info.Ngay, info.SoLuongBenhNhan, info.DoanhThu, info.TyLe);

            executeNonQuery(insertCommand);
        }
    }
}