using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLPMT_DAL_WS
{
    public class ChiTietBaoCaoSuDungThuocDTO
    {
        public string MaBCSDT { get; set; }

        public string MaThuoc { get; set; }

        public int? SoLanDung { get; set; }

        public virtual BaoCaoSuDungThuocDTO BAOCAOSUDUNGTHUOC { get; set; }

        public virtual ThuocDTO THUOC { get; set; }
    }
}
