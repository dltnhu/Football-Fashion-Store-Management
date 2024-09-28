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
    public partial class TheLoaiModule : Form
    {
        public int MaTheLoai { get; set; }
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();

        public TheLoaiModule()
        {
            InitializeComponent();
        }

        public TheLoaiModule(int maTheLoai)
        {
            InitializeComponent();
            this.MaTheLoai = maTheLoai;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.TenTheLoai = txtTenTheLoai.Text;
            theLoai.TrangThai = 1;
            if (string.IsNullOrWhiteSpace(txtTenTheLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                if (theLoaiBUS.ThemTheLoai(theLoai))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.MaTheLoai = this.MaTheLoai;
            theLoai.TenTheLoai = txtTenTheLoai.Text;
            theLoai.TrangThai = 1;
            if (string.IsNullOrWhiteSpace(txtTenTheLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (theLoaiBUS.SuaTheLoai(theLoai))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }
    }
}
