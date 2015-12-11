using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class DanhMucSanPhamDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DanhMucSanPhamDTO()
        //{
        //    LICHSUNHAPXUATs = new HashSet<LichSuNhapXuatDTO>();
        //}

        public string MaLoaiSanPham { get; set; }

        public string TenLoaiSanPham { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual LichSuNhapXuatDTO[] LICHSUNHAPXUATs { get; set; }
    }
}