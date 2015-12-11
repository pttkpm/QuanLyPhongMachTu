using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLPMT_BUS_WS.QLPMT_DAL_WebService;

namespace QLPMT_BUS_WS
{
    public class BaoCaoCTL
    {
        private BaoCaoDTO info = new BaoCaoDTO();
        private QLPMT_DAL_WebServiceSoapClient ws = new QLPMT_DAL_WebServiceSoapClient();

        public BaoCaoDTO BaoCao
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
    }
}