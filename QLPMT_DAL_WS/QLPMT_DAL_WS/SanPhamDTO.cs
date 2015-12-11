using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class SanPhamDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public SanPhamDTO()
        //{
        //    CHITIETNHAPXUATs = new HashSet<ChiTietNhapXuatDTO>();
        //}

        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public string DonVi { get; set; }

        public int? DonGia { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ChiTietNhapXuatDTO[] CHITIETNHAPXUATs { get; set; }

        public virtual DanhMucDonViDTO DANHMUCDONVI { get; set; }

        public virtual DungCuYTeDTO DUNGCUYTE { get; set; }

        public virtual ThuocDTO THUOC { get; set; }
    }
}
