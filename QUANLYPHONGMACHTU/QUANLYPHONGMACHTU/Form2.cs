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
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDatLichKham_Click(object sender, EventArgs e)
        {
            FormDatLichKham f = new FormDatLichKham();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnLapDanhSach_Click(object sender, EventArgs e)
        {
            FormLapDanhSachKham f = new FormLapDanhSachKham();
            f.StartPosition = FormStartPosition.CenterParent;
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
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTaoDanhSachKham f = new FormTaoDanhSachKham();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            FormXemDanhSachKham f = new FormXemDanhSachKham();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnTraCuuBN_Click(object sender, EventArgs e)
        {
            FormTraCuuBN f = new FormTraCuuBN();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnLapPhieuKham_Click(object sender, EventArgs e)
        {
            FormLapPhieuKham f = new FormLapPhieuKham();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnThayDoiSoLuongBenh_Click(object sender, EventArgs e)
        {
            FormThayDoiSoLuongBenh f = new FormThayDoiSoLuongBenh();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnLapHoaDonThanhToan_Click(object sender, EventArgs e)
        {
            FormLapHoaDonThanhToan f = new FormLapHoaDonThanhToan();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnThayDoiTienKham_Click(object sender, EventArgs e)
        {
            FormThayDoiTienKham f = new FormThayDoiTienKham();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnThayDoiDonGiaThuoc_Click(object sender, EventArgs e)
        {
            FormThayDoiDonGiaThuoc f = new FormThayDoiDonGiaThuoc();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnThemThuocMoi_Click(object sender, EventArgs e)
        {
            FormThemThuocMoi f = new FormThemThuocMoi();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            FormXoaThuoc f = new FormXoaThuoc();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnTraCuuThuoc_Click(object sender, EventArgs e)
        {
            FormTraCuuThuoc f = new FormTraCuuThuoc();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnThayDoiThongTinThuoc_Click(object sender, EventArgs e)
        {
            FormThayDoiThongTinThuoc f = new FormThayDoiThongTinThuoc();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            FormThemBenhNhan f = new FormThemBenhNhan();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnXuHuongKham_Click(object sender, EventArgs e)
        {

        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan f = new FormTaoTaiKhoan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btnPhanQuyenNguoiDung_Click(object sender, EventArgs e)
        {
            FormPhanQuyenNguoiDung f = new FormPhanQuyenNguoiDung();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btnDuDoanXuHuong_Click(object sender, EventArgs e)
        {

        }

        private void btnKeHoachNhapThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeThuocBanChay_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuuXuatKho_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuuNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btnGhiNhanNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btnGhiNhanXuatKho_Click(object sender, EventArgs e)
        {

        }
    }
}
