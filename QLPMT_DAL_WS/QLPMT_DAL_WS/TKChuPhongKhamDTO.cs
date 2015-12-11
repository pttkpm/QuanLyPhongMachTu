using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class TKChuPhongKhamDTO
    {
        public string MaTKCPK { get; set; }

        public virtual TaiKhoanDTO TAIKHOAN { get; set; }
    }
}
