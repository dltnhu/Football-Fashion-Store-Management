using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class TaiKhoanModule : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        public TaiKhoanModule()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                TaiKhoan taikhoan = new TaiKhoan();
                taikhoan.MaTaiKhoan = Convert.ToInt32(comboBoxNhanVien.Text.Split('-')[0]);
                int maNhomQuyen = nhomQuyenBUS.LayNhomQuyenQuaTen(comboBoxNhomQuyen.Text).MaNhomQuyen;
                taikhoan.MaNhomQuyen = maNhomQuyen;
                taikhoan.TenTaikhoan = txtTenDangNhap.Text;
                taikhoan.MatKhau = txtMatKhau.Text;
                taikhoan.TrangThai = 1;

                if (taiKhoanBUS.ThemTaiKhoan(taikhoan))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                TaiKhoan taikhoan = new TaiKhoan();
                taikhoan.MaTaiKhoan = Convert.ToInt32(comboBoxNhanVien.Text.Split('-')[0]);
                int maNhomQuyen = nhomQuyenBUS.LayNhomQuyenQuaTen(comboBoxNhomQuyen.Text).MaNhomQuyen;
                taikhoan.MaNhomQuyen = maNhomQuyen;
                taikhoan.TenTaikhoan = txtTenDangNhap.Text;
                taikhoan.MatKhau = txtMatKhau.Text;
                taikhoan.TrangThai = 1;

                if (taiKhoanBUS.SuaTaiKhoan(taikhoan))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }
    }
}
