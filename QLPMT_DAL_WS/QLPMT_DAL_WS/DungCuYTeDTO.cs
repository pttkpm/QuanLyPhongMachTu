using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPMT_DAL_WS
{
    public class DungCuYTeDTO
    {
        public string MaDCYT { get; set; }

        public virtual SanPhamDTO SANPHAM { get; set; }
    }
}