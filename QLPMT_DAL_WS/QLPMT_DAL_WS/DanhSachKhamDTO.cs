using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class DanhSachKhamDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DanhSachKhamDTO()
        //{
        //    BENHNHANs = new HashSet<BenhNhanDTO>();
        //}

        public string MaDanhSach { get; set; }

        public DateTime? NgayLap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public BenhNhanDTO[] BENHNHANs { get; set; }
    }
}
