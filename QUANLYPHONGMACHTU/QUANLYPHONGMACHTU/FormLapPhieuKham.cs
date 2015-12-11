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
    public partial class FormLapPhieuKham : Form
    {
        public FormLapPhieuKham()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            FormLapPhieuKhamThemThuoc f = new FormLapPhieuKhamThemThuoc();
            f.ShowDialog();
        }

    }
}
