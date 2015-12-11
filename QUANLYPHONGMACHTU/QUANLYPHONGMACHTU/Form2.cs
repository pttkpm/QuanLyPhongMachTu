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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDatLichKham_Click(object sender, EventArgs e)
        {
            FormDatLichKham f = new FormDatLichKham();
            f.ShowDialog();
        }

        private void btnLapDanhSach_Click(object sender, EventArgs e)
        {
            FormLapDanhSachKham f = new FormLapDanhSachKham();
            f.ShowDialog();
        }

        private void btnTraCuuLichKham_Click(object sender, EventArgs e)
        {
            FormTraCuuLichKham f = new FormTraCuuLichKham();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnThayDoiSoLuongBN_Click(object sender, EventArgs e)
        {
            FormThayDoiSoLuongBN f = new FormThayDoiSoLuongBN();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTaoDanhSachKham f = new FormTaoDanhSachKham();
            f.ShowDialog();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            FormXemDanhSachKham f = new FormXemDanhSachKham();
            f.ShowDialog();
        }

        private void btnTraCuuBN_Click(object sender, EventArgs e)
        {
            FormTraCuuBN f = new FormTraCuuBN();
            f.ShowDialog();
        }

        private void btnLapPhieuKham_Click(object sender, EventArgs e)
        {
            FormLapPhieuKham f = new FormLapPhieuKham();
            f.ShowDialog();
        }

        private void btnThayDoiSoLuongBenh_Click(object sender, EventArgs e)
        {
            FormThayDoiSoLuongBenh f = new FormThayDoiSoLuongBenh();
            f.ShowDialog();
        }

        private void btnLapHoaDonThanhToan_Click(object sender, EventArgs e)
        {
            FormLapHoaDonThanhToan f = new FormLapHoaDonThanhToan();
            f.ShowDialog();
        }

        private void btnThayDoiTienKham_Click(object sender, EventArgs e)
        {
            FormThayDoiTienKham f = new FormThayDoiTienKham();
            f.ShowDialog();
        }

        private void btnThayDoiDonGiaThuoc_Click(object sender, EventArgs e)
        {
            FormThayDoiDonGiaThuoc f = new FormThayDoiDonGiaThuoc();
            f.ShowDialog();
        }

        private void btnThemThuocMoi_Click(object sender, EventArgs e)
        {
            FormThemThuocMoi f = new FormThemThuocMoi();
            f.ShowDialog();
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            FormXoaThuoc f = new FormXoaThuoc();
            f.ShowDialog();
        }

        private void btnTraCuuThuoc_Click(object sender, EventArgs e)
        {
            FormTraCuuThuoc f = new FormTraCuuThuoc();
            f.ShowDialog();
        }

        private void btnThayDoiThongTinThuoc_Click(object sender, EventArgs e)
        {
            FormThayDoiThongTinThuoc f = new FormThayDoiThongTinThuoc();
            f.ShowDialog();
        }

        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            FormThemBenhNhan f = new FormThemBenhNhan();
            f.ShowDialog();
        }

        private void btnXuHuongKham_Click(object sender, EventArgs e)
        {

        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {

        }

        
    }
}
