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
    public partial class NhaCungCapModule : Form
    {
        public int MaNhaCungCap { get; set; }
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        public NhaCungCapModule()
        {
            InitializeComponent();
        }

        public NhaCungCapModule(int maNhaCungCap)
        {
            InitializeComponent();
            this.MaNhaCungCap = maNhaCungCap;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhaCungCap.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string tenNhaCungCap = txtNhaCungCap.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;

                NhaCungCap nhaCungCap = new NhaCungCap();
                nhaCungCap.TenNhaCungCap = tenNhaCungCap;
                nhaCungCap.DiaChi = diaChi;
                nhaCungCap.SoDienThoai = soDienThoai;
                nhaCungCap.TrangThai = 1;

                if (nhaCungCapBUS.ThemNhaCungCap(nhaCungCap))
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
            if (string.IsNullOrWhiteSpace(txtNhaCungCap.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string tenNhaCungCap = txtNhaCungCap.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;

                NhaCungCap nhaCungCap = new NhaCungCap();
                nhaCungCap.MaNhaCungCap = this.MaNhaCungCap;
                nhaCungCap.TenNhaCungCap = tenNhaCungCap;
                nhaCungCap.DiaChi = diaChi;
                nhaCungCap.SoDienThoai = soDienThoai;
                nhaCungCap.TrangThai = 1;

                if (nhaCungCapBUS.SuaNhaCungCap(nhaCungCap))
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
