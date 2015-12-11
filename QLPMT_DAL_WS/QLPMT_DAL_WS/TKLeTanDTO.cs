using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class TKLeTanDTO
    {
        public string MaTKLT { get; set; }

        public virtual TaiKhoanDTO TAIKHOAN { get; set; }
    }
}
