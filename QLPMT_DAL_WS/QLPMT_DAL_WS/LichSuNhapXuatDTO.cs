using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class LichSuNhapXuatDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public LichSuNhapXuatDTO()
        //{
        //    CHITIETNHAPXUATs = new HashSet<ChiTietNhapXuatDTO>();
        //}

        public string MaLSNX { get; set; }

        public DateTime? Ngay { get; set; }

        public string LoaiGiaoDich { get; set; }

        public string LoaiSanPham { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ChiTietNhapXuatDTO[] CHITIETNHAPXUATs { get; set; }

        public virtual DanhMucGiaoDichDTO DANHMUCGIAODICH { get; set; }

        public virtual DanhMucSanPhamDTO DANHMUCSANPHAM { get; set; }
    }
}
