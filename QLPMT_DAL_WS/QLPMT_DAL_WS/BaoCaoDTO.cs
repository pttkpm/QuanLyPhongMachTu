using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class BaoCaoDTO
    {
        public string MaBaoCao { get; set; }

        public int? Thang { get; set; }

        public virtual BaoCaoDoanhThuDTO BAOCAODOANHTHU { get; set; }

        public virtual BaoCaoSuDungThuocDTO BAOCAOSUDUNGTHUOC { get; set; }
    }
}