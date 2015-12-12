using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace QLPMT_DAL_WS
{
    /// <summary>
    /// Summary description for QLPMT_DAL_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLPMT_DAL_WebService : System.Web.Services.WebService
    {
        //BaoCao
        [WebMethod]
        public void insertBaoCao(BaoCaoDTO info)
        {
            BaoCaoDAO ob = new BaoCaoDAO();
            ob.insert(info);
        }

        //BaoCaoDoanhThu
        [WebMethod]
        public void insertBaoCaoDoanhThu(BaoCaoDoanhThuDTO info)
        {
            BaoCaoDoanhThuDAO ob = new BaoCaoDoanhThuDAO();
            ob.insert(info);
        }

        //Benh Nhan
        [WebMethod]
        public int isExistBenhNhan(BenhNhanDTO info)
        {
            BenhNhanDAO ob = new BenhNhanDAO();
            return ob.isExist(info);
        }

        [WebMethod]
        public void insertBenhNhan(BenhNhanDTO info)
        {
            BenhNhanDAO ob = new BenhNhanDAO();
            ob.insert(info);
        }

        [WebMethod]
        public void insertChiTietDanhSachKham(ChiTietDanhSachKhamDTO info)
        {
            ChiTietDanhSachKhamDAO ob = new ChiTietDanhSachKhamDAO();
            ob.insert(info);
        }

        //LichHen
        [WebMethod]
        public void insertLichHen(LichHenDTO info)
        {
            LichHenDAO ob = new LichHenDAO();
            ob.insert(info);
        }

        [WebMethod]
        public LichHenDTO[] getDSLichHen(string TenBS, string NgayLap)
        {
            LichHenDAO ob = new LichHenDAO();
            return ob.getListLichHen(TenBS, NgayLap);
        }


        //Danh Sach Kham
        [WebMethod]
        public void insertDanhSachKham(DanhSachKhamDTO info)
        {
            DanhSachKhamDAO ob = new DanhSachKhamDAO();
            ob.insert(info);
        }

        [WebMethod]
        public BenhNhanDTO[] getDsChiTietDanhSachKham(string Ngay)
        {
            DanhSachKhamDAO ob = new DanhSachKhamDAO();
            return ob.getListDanhSachKham(Ngay);
        }


        
    }
}
