using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLHS2010;

namespace QLPMT_DAL_WS
{
    public class BaoCaoDAO : DataProvider
    {
        public BaoCaoDAO()
        {
            connect();
        }

        public void insert(BaoCaoDTO info)
        {
            string insertCommand = string.Format("INSERT INTO BAOCAO VALUES('{0}', '{1}')",
                info.MaBaoCao, info.Thang);

            executeNonQuery(insertCommand);
        }
    }
}