using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLPMT_BUS_WS.QLPMT_DAL_WebService;

namespace QLPMT_BUS_WS
{
    public class DanhSachKhamCTL
    {
        private DanhSachKhamDTO info = new DanhSachKhamDTO();
        private QLPMT_DAL_WebServiceSoapClient ws = new QLPMT_DAL_WebServiceSoapClient();

        public DanhSachKhamDTO DanhSachKham
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
            ws.insertDanhSachKham(info);
        }
    }
}
