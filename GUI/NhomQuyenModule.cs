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
    public partial class NhomQuyenModule : Form
    {
        public int MaNhomQuyen { get; set; }
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        public NhomQuyenModule()
        {
            InitializeComponent();
        }

        public NhomQuyenModule(int maNhomQuyen)
        {
            this.MaNhomQuyen = maNhomQuyen;
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhomQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                NhomQuyen nhomQuyen = new NhomQuyen();
                nhomQuyen.TenNhomQuyen = txtTenNhomQuyen.Text;
                nhomQuyen.TrangThai = 1;
                if (nhomQuyenBUS.ThemNhomQuyen(nhomQuyen))
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
            if (string.IsNullOrWhiteSpace(txtTenNhomQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                NhomQuyen nhomQuyen = new NhomQuyen();
                nhomQuyen.MaNhomQuyen = this.MaNhomQuyen;
                nhomQuyen.TenNhomQuyen = txtTenNhomQuyen.Text;
                nhomQuyen.TrangThai = 1;
                if (nhomQuyenBUS.SuaNhomQuyen(nhomQuyen))
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
            this.Dispose();
        }
    }
}
