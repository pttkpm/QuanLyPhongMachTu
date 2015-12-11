using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class DanhMucDonViDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DanhMucDonViDTO()
        //{
        //    SANPHAMs = new HashSet<SanPhamDTO>();
        //}

        public string MaDonVi { get; set; }

        [StringLength(50)]
        public string TenDonVi { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual SanPhamDTO[] SANPHAMs { get; set; }
    }
}