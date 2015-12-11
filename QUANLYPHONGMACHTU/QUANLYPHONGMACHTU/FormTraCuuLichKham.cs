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
   

    public partial class FormTraCuuLichKham : Form
    {
        public FormTraCuuLichKham()
        {
            InitializeComponent();
        }

        QLPMT_BUS_WebServiceSoapClient ws = new QLPMT_BUS_WebServiceSoapClient();

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LichHenDTO[] list = ws.getDsLichHen(tbTenBacSi.Text.ToString(), tbNgay.Text.ToString());
            dataGridView1.DataSource = list;
            //dataGridView1.Data
        }
    }
}
