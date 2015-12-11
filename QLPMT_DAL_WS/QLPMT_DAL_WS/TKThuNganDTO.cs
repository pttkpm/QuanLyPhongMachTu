using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class TKThuNganDTO
    {
        public string MaTKTN { get; set; }

        public virtual TaiKhoanDTO TAIKHOAN { get; set; }
    }
}
