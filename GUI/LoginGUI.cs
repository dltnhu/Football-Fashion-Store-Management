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
    public partial class LoginGUI : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        ChucNangBUS chucNangBUS = new ChucNangBUS();
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();
        public LoginGUI()
        {
            InitializeComponent();
        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        public void DangNhap()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Không Được Để Trống");
                return;
            }
            else
            {
                if (taiKhoanBUS.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
                {

                        int mataikhoan = taiKhoanBUS.LayThongTinTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text).MaTaiKhoan;
                        int maNhomQuyen = taiKhoanBUS.LayTaiKhoanQuaMa(mataikhoan).MaNhomQuyen;
                        List<int> danhSachChucNang = chiTietQuyenBUS.LayDanhSachChucNang(maNhomQuyen);
                        List<string> danhSachTenChucNang = new List<string>();
                        foreach (var item in danhSachChucNang)
                        {
                            if (chucNangBUS.LayChucNangQuaMa(item) == null)
                            {
                                
                            }
                            else
                            {
                                danhSachTenChucNang.Add(chucNangBUS.LayChucNangQuaMa(item).TenChucNang);
                            }
                            
                        }
                        TrangChuGUI trangChuGUI = new TrangChuGUI(mataikhoan, maNhomQuyen, danhSachTenChucNang);
                        trangChuGUI.ShowDialog();
                        this.Dispose();
                    

                }
                else
                {
                    txtMatKhau.Text = "";
                    MessageBox.Show("Tài Khoản Chưa Được Đăng Ký");

                    return;
                }
            }
        }
    }
}
