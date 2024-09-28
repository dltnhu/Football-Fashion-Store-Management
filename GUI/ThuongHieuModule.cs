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
    public partial class ThuongHieuModule : Form
    {
        public int MaThuongHieu { get; set; }
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        public ThuongHieuModule()
        {
            InitializeComponent();
        }

        public ThuongHieuModule(int maThuongHieu)
        {
            InitializeComponent();
            this.MaThuongHieu = maThuongHieu;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenThuongHieu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                ThuongHieu thuongHieu = new ThuongHieu();
                thuongHieu.TenThuongHieu = txtTenThuongHieu.Text;
                thuongHieu.TrangThai = 1;

                if (thuongHieuBUS.ThemThuongHieu(thuongHieu))
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
            ThuongHieu thuongHieu = new ThuongHieu();
            thuongHieu.MaThuongHieu = this.MaThuongHieu;
            thuongHieu.TenThuongHieu = txtTenThuongHieu.Text;
            thuongHieu.TrangThai = 1;

            if (string.IsNullOrWhiteSpace(txtTenThuongHieu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (thuongHieuBUS.SuaThuongHieu(thuongHieu))
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
