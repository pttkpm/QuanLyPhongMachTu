using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class DanhMucQuyenDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DanhMucQuyenDTO()
        //{
        //    TAIKHOANs = new HashSet<TaiKhoanDTO>();
        //}

        public string MaSoQuyen { get; set; }

        public string ThongTinQuyen { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual TaiKhoanDTO[] TAIKHOANs { get; set; }
    }
}