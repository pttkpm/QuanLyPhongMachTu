using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLPMT_BUS_WS.QLPMT_DAL_WebService;

namespace QLPMT_BUS_WS
{
    public class LichHenCTL
    {
        private LichHenDTO info = new LichHenDTO();
        private QLPMT_DAL_WebServiceSoapClient ws = new QLPMT_DAL_WebServiceSoapClient();

        public LichHenDTO LichHen
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }

        public void insert()
        {
            ws.insertLichHen(info);
        }

        public LichHenDTO[] getDsLichHen(string tenBs,string ngay)
        {
            return ws.getDSLichHen(tenBs,ngay);
        }

    }
}