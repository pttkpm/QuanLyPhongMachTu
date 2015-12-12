using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLHS2010;

namespace QLPMT_DAL_WS
{
    public class BaoCaoSuDungThuocDAO : DataProvider
    {
        public BaoCaoSuDungThuocDAO()
        {
            connect();
        }

        public void insert(BaoCaoSuDungThuocDTO info)
        {
            string insertCommand = string.Format("INSERT INTO BAOCAOSUDUNGTHUOC VALUES('{0}')",
                info.MaBCSDT);

            executeNonQuery(insertCommand);
        }
    }
}