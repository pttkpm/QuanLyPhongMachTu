using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class TaiKhoanDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public TaiKhoanDTO()
        //{
        //    DANHMUCQUYENs = new HashSet<DanhMucQuyenDTO>();
        //}

        public string MaTaiKhoan { get; set; }

        public string TenTaiKhoan { get; set; }

        public string MatKhau { get; set; }

        public virtual TKBacSiDTO TKBACSI { get; set; }

        public virtual TKChuPhongKhamDTO TKCHUPHONGKHAM { get; set; }

        public virtual TKLeTanDTO TKLETAN { get; set; }

        public virtual TKThuKhoDTO TKTHUKHO { get; set; }

        public virtual TKThuNganDTO TKTHUNGAN { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual DanhMucQuyenDTO[] DANHMUCQUYENs { get; set; }
    }
}
