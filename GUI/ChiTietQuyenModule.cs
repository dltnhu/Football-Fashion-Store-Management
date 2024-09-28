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
    public partial class ChiTietQuyenModule : Form
    {
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        ChucNangBUS chucNangBUS = new ChucNangBUS();
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();

        public int MaChiTietQuyen { get; set; }
        public ChiTietQuyenModule()
        {
            InitializeComponent();
        }

        public ChiTietQuyenModule(int maChiTietQuyen)
        {
            InitializeComponent();
            this.MaChiTietQuyen = maChiTietQuyen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNhomQuyen = comboBoxNhomQuyen.Text;
            string tenChucNang = comboBoxChucNang.Text;
            string hanhDong = comboBoxHanhDong.Text;

            int maNhomQuyen = nhomQuyenBUS.LayNhomQuyenQuaTen(tenNhomQuyen).MaNhomQuyen;
            int maChucNang = chucNangBUS.LayChucNangQuaTen(tenChucNang).MaChucNang;

            ChiTietQuyen chiTietQuyen = new ChiTietQuyen();
            chiTietQuyen.MaNhomQuyen = maNhomQuyen;
            chiTietQuyen.MaChucNang = maChucNang;
            chiTietQuyen.HanhDong = hanhDong;
            if (chiTietQuyenBUS.ThemChiTietQuyen(chiTietQuyen))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenNhomQuyen = comboBoxNhomQuyen.Text;
            string tenChucNang = comboBoxChucNang.Text;
            string hanhDong = comboBoxHanhDong.Text;

            int maNhomQuyen = nhomQuyenBUS.LayNhomQuyenQuaTen(tenNhomQuyen).MaNhomQuyen;
            int maChucNang = chucNangBUS.LayChucNangQuaTen(tenChucNang).MaChucNang;

            ChiTietQuyen chiTietQuyen = new ChiTietQuyen();
            chiTietQuyen.MaChiTietQuyen = this.MaChiTietQuyen;
            chiTietQuyen.MaNhomQuyen = maNhomQuyen;
            chiTietQuyen.MaChucNang = maChucNang;
            chiTietQuyen.HanhDong = hanhDong;
            if (chiTietQuyenBUS.SuaChiTietQuyen(chiTietQuyen))
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
