using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYPHONGMACHTU.QLPMT_BUS_WebService;

namespace QUANLYPHONGMACHTU
{
    public partial class FormDatLichKham : Form
    {
        public FormDatLichKham()
        {
            InitializeComponent();
        }
        QLPMT_BUS_WebServiceSoapClient ws = new QLPMT_BUS_WebServiceSoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            LichHenDTO lh = new LichHenDTO();

            //lh.MaLichHen = tbMaLichHen.Text.ToString();
            lh.MaBenhNhan = tbMaBenhNhan.Text.ToString();
            lh.NgayHen = DateTime.Parse(dateTimePicker1.Text.ToString());
            lh.GioKham = DateTime.Parse(tbHH.Text.ToString());
            lh.TenBacSi = tbTenBacSi.Text.ToString();

            ws.insertLichHen(lh);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTraCuuLichKham f = new FormTraCuuLichKham();
            f.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
