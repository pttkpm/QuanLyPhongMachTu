using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using QLPMT_BUS_WS.QLPMT_DAL_WebService;

namespace QLPMT_BUS_WS
{
    /// <summary>
    /// Summary description for QLPMT_BUS_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLPMT_BUS_WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertLichHen(LichHenDTO info)
        {
            LichHenCTL lhCTL = new LichHenCTL();
            lhCTL.LichHen = info;
            lhCTL.insert();
        }

        [WebMethod]
        public LichHenDTO[] getDsLichHen(string tenBs, string ngay)
        {
            LichHenCTL lhCTL = new LichHenCTL();
            return lhCTL.getDsLichHen(tenBs, ngay);
        }

        [WebMethod]
        public void insertDanhSachKham(DanhSachKhamDTO info)
        {
            DanhSachKhamCTL dskCTL = new DanhSachKhamCTL();
            dskCTL.DanhSachKham = info;
            dskCTL.insert();
        }

        [WebMethod]
        public int insertBenhNhan(BenhNhanDTO info)
        {
            BenhNhanCTL bnCTL = new BenhNhanCTL();
            bnCTL.BenhNhan = info;
            return bnCTL.insert();
        }

        [WebMethod]
        public void insertChiTietDanhSachKham(ChiTietDanhSachKhamDTO info)
        {
            ChiTietDanhSachKhamCTL dskCTL = new ChiTietDanhSachKhamCTL();
            dskCTL.ChiTietDanhSachKham = info;
            dskCTL.insert();
        }
    }
}
