using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class ChiTietNhapXuatDTO
    {
        public string MaLSNX { get; set; }

        public string MaSanPham { get; set; }

        public int? SoLuong { get; set; }

        public int? ThanhTien { get; set; }

        public virtual LichSuNhapXuatDTO LICHSUNHAPXUAT { get; set; }

        public virtual SanPhamDTO SANPHAM { get; set; }
    }
}