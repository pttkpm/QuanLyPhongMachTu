using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class ChiTietPhieuKhamDTO
    {
        public string MaPhieuKham { get; set; }

        public string MaSoThuoc { get; set; }

        public int? SoLuong { get; set; }

        public virtual PhieuKhamBenhDTO PHIEUKHAMBENH { get; set; }

        public virtual ThuocDTO THUOC { get; set; }
    }
}