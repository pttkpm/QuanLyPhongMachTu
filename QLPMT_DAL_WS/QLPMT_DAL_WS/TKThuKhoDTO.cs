using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class TKThuKhoDTO
    {
        public string MaTKTK { get; set; }

        public virtual TaiKhoanDTO TAIKHOAN { get; set; }
    }
}
