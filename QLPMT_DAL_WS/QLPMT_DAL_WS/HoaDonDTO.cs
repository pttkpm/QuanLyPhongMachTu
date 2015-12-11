using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }

        public string MaBenhNhan { get; set; }

        public DateTime? NgayKham { get; set; }

        public int? TienKham { get; set; }

        public int? TienThuoc { get; set; }

        public virtual BenhNhanDTO BENHNHAN { get; set; }
    }
}
