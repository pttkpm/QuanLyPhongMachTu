using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLPMT_DAL_WS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BenhNhanDTO info = new BenhNhanDTO();
            info.MaBenhNhan = "1";
            info.HoTen = "Toan";
            info.DiaChi = "Binh Thuan";
            info.GioiTinh = "Nam";
            info.NamSinh = 1995;
            BenhNhanDAO ob = new BenhNhanDAO();
            ob.insert(info);
        }
    }
}