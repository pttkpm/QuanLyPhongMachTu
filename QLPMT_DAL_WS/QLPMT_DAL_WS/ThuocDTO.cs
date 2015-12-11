using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class ThuocDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public ThuocDTO()
        //{
        //    CHITIETBAOCAOSUDUNGTHUOCs = new HashSet<ChiTietBaoCaoSuDungThuocDTO>();
        //    CHITIETPHIEUKHAMs = new HashSet<ChiTietPhieuKhamDTO>();
        //}

        public string MaThuoc { get; set; }

        public string CachDung { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ChiTietBaoCaoSuDungThuocDTO[] CHITIETBAOCAOSUDUNGTHUOCs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ChiTietPhieuKhamDTO[] CHITIETPHIEUKHAMs { get; set; }

        public virtual SanPhamDTO SANPHAM { get; set; }
    }
}
