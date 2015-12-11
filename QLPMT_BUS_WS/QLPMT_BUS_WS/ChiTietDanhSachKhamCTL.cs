using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLPMT_BUS_WS.QLPMT_DAL_WebService;

namespace QLPMT_BUS_WS
{
    public class ChiTietDanhSachKhamCTL
    {
        private ChiTietDanhSachKhamDTO info = new ChiTietDanhSachKhamDTO();
        private QLPMT_DAL_WebServiceSoapClient ws = new QLPMT_DAL_WebServiceSoapClient();

        public ChiTietDanhSachKhamDTO ChiTietDanhSachKham
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
            ws.insertChiTietDanhSachKham(info);
        }

        public BenhNhanDTO[] getDsChiTietDanhSachKham(string ngay)
        {
            return ws.getDsChiTietDanhSachKham(ngay);
        }

    }
}