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
    public partial class FormLapDanhSachKham : Form
    {
        public FormLapDanhSachKham()
        {
            InitializeComponent();
        }

        QLPMT_BUS_WebServiceSoapClient ws = new QLPMT_BUS_WebServiceSoapClient();

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }

        private void FormLapDanhSachKham_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /*
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
           
            ChiTietDanhSachKhamDTO ct = new ChiTietDanhSachKhamDTO();
            ct.MaBenhNhan = tbMaBenhNhan.Text.ToString();
            ct.MaDanhSachKham = tbMaDSKham.Text.ToString();

            ws.insertChiTietDanhSachKham(ct);
            

            
        }
         */

    }
}
