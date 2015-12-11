using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class DanhMucGiaoDichDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DanhMucGiaoDichDTO()
        //{
        //    LICHSUNHAPXUATs = new HashSet<LichSuNhapXuatDTO>();
        //}

        public string MaGiaoDich { get; set; }

        public string TenLoaiGiaoDich { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual LichSuNhapXuatDTO[] LICHSUNHAPXUATs { get; set; }
    }
}