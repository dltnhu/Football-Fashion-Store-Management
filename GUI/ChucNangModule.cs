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
    public partial class ChucNangModule : Form
    {
        ChucNangBUS chucNangBUS = new ChucNangBUS();

        public int MaChucNang { get; set; }
        public ChucNangModule()
        {
            InitializeComponent();
        }

        public ChucNangModule(int maChucNang)
        {
            this.MaChucNang = maChucNang;
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenChucNang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                ChucNang chucNang = new ChucNang();
                chucNang.TenChucNang = txtTenChucNang.Text;
                chucNang.TrangThai = 1;
                if (chucNangBUS.ThemChucNang(chucNang))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenChucNang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                ChucNang chucNang = new ChucNang();
                chucNang.MaChucNang = this.MaChucNang;
                chucNang.TenChucNang = txtTenChucNang.Text;
                chucNang.TrangThai = 1;
                if (chucNangBUS.SuaChucNang(chucNang))
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
