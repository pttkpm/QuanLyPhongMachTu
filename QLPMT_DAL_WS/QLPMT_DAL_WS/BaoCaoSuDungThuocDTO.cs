using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class BaoCaoSuDungThuocDTO
    {
        //public BaoCaoSuDungThuocDTO()
        //{
        //    CHITIETBAOCAOSUDUNGTHUOCs = new HashSet<ChiTietBaoCaoSuDungThuocDTO>();
        //}

        public string MaBCSDT { get; set; }

        public virtual BaoCaoDTO BAOCAO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ChiTietBaoCaoSuDungThuocDTO[] CHITIETBAOCAOSUDUNGTHUOCs { get; set; }
    }
}