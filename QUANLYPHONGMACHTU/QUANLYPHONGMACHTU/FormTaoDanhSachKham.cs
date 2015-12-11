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
    public partial class FormTaoDanhSachKham : Form
    {
        public FormTaoDanhSachKham()
        {
            InitializeComponent();
        }
        QLPMT_BUS_WebServiceSoapClient ws = new QLPMT_BUS_WebServiceSoapClient();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachKhamDTO ds = new DanhSachKhamDTO();
            ds.MaDanhSach = tbMaDanhSach.Text.ToString();
            ds.NgayLap = DateTime.Parse(tbNgayLap.Text.ToString());

            ws.insertDanhSachKham(ds);
        }
    }
}
