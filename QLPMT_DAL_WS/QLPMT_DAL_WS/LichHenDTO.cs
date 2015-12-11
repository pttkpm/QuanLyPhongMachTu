using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class LichHenDTO
    {
        public string MaLichHen { get; set; }

        public string MaBenhNhan { get; set; }

        public DateTime? NgayHen { get; set; }

        public DateTime? GioKham { get; set; }

        public string TenBacSi { get; set; }

        public virtual BenhNhanDTO BENHNHAN { get; set; }
    }
}
