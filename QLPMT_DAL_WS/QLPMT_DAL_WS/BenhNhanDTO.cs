using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class BenhNhanDTO
    {
        //public BenhNhanDTO()
        //{
        //    HOADONs = new HashSet<HoaDonDTO>();
        //    LICHHENs = new HashSet<LichHenDTO>();
        //    PHIEUKHAMBENHs = new HashSet<PhieuKhamBenhDTO>();
        //    DANHSACHKHAMs = new HashSet<DanhSachKhamDTO>();
        //}

        public string MaBenhNhan { get; set; }

        public string HoTen { get; set; }

        public string DiaChi { get; set; }

        public string GioiTinh { get; set; }

        public int? NamSinh { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual HoaDonDTO[] HOADONs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual LichHenDTO[] LICHHENs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual PhieuKhamBenhDTO[] PHIEUKHAMBENHs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual DanhSachKhamDTO[] DANHSACHKHAMs { get; set; }
    }
}