using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class BaoCaoDoanhThuDTO
    {
        public string MaBCDT { get; set; }

        public DateTime? Ngay { get; set; }

        public int? SoLuongBenhNhan { get; set; }

        public int? DoanhThu { get; set; }

        public int? TyLe { get; set; }

        public virtual BaoCaoDTO BAOCAO { get; set; }
    }
}