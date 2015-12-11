using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public  class PhieuKhamBenhDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public PhieuKhamBenhDTO()
        //{
        //    CHITIETPHIEUKHAMs = new HashSet<ChiTietPhieuKhamDTO>();
        //}

        public string MaPhieuKhamBenh { get; set; }

        public string MaBenhNhan { get; set; }

        public DateTime? NgayKhamBenh { get; set; }

        public string TrieuChungBenh { get; set; }

        public string DuDoanLoaiBenh { get; set; }

        public virtual BenhNhanDTO BENHNHAN { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ChiTietPhieuKhamDTO[] CHITIETPHIEUKHAMs { get; set; }
    }
}
