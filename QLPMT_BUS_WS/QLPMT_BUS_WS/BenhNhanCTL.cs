using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLPMT_BUS_WS.QLPMT_DAL_WebService;

namespace QLPMT_BUS_WS
{
    public class BenhNhanCTL
    {
        private BenhNhanDTO info = new BenhNhanDTO();
        private QLPMT_DAL_WebServiceSoapClient ws = new QLPMT_DAL_WebServiceSoapClient();

        public BenhNhanDTO BenhNhan
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

        public int insert()
        {
            if (ws.isExistBenhNhan(info) < 0)
                return 0;
            else
                info.MaBenhNhan = Convert.ToString(ws.isExistBenhNhan(info) + 1);
                
            ws.insertBenhNhan(info);
            return 1;
        }

        //public BenhNhanDTO[] getDsBenhNhan()
        //{
        //    return ws.getDsBenhNhan();
        //}
    }
}