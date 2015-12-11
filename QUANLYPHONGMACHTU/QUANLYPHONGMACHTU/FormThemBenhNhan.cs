using QUANLYPHONGMACHTU.QLPMT_BUS_WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHONGMACHTU
{

    public partial class FormThemBenhNhan : Form
    {
        QLPMT_BUS_WebServiceSoapClient ws = new QLPMT_BUS_WebServiceSoapClient();

        public FormThemBenhNhan()
        {
            InitializeComponent();
        }
        /*
        private void btnOK_Click(object sender, EventArgs e)
        {
            BenhNhanDTO bn = new BenhNhanDTO();
            bn.HoTen = tbHoTen.Text.ToString();
            bn.GioiTinh = tbGioiTinh.Text.ToString();
            bn.NamSinh = Int32.Parse(tbNamSinh.Text.ToString());
            bn.DiaChi = tbDiaChi.Text.ToString();

            ws.insertBenhNhan(bn);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         */
    }
}
