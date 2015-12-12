using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLHS2010;

namespace QLPMT_DAL_WS
{
    public class ChiTietBaoCaoSuDungThuocDAO : DataProvider
    {
        public ChiTietBaoCaoSuDungThuocDAO()
        {
            connect();
        }

        public void insert(ChiTietBaoCaoSuDungThuocDTO info)
        {
            string insertCommand = string.Format("INSERT INTO CHITIETBAOCAOSUDUNGTHUOC VALUES('{0}', '{1}', '{2}')",
                info.MaBCSDT, info.MaThuoc, info.SoLanDung);

            executeNonQuery(insertCommand);
        }
    }
}