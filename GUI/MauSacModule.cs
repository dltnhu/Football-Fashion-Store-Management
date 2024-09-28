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
    public partial class MauSacModule : Form
    {
        MauSacBUS mauSacBUS = new MauSacBUS();
        public int MaMauSac { get; set; }
        public MauSacModule()
        {
            InitializeComponent();
        }

        public MauSacModule(int maMauSac)
        {
            InitializeComponent();
            this.MaMauSac = maMauSac;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MauSac mauSac = new MauSac();
            mauSac.TenMauSac = txtTenMauSac.Text;
            mauSac.TrangThai = 1;
            if (string.IsNullOrWhiteSpace(txtTenMauSac.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (mauSacBUS.ThemMauSac(mauSac))
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
            MauSac mauSac = new MauSac();
            mauSac.MaMauSac = this.MaMauSac;
            mauSac.TenMauSac = txtTenMauSac.Text;
            mauSac.TrangThai = 1;
            if (string.IsNullOrWhiteSpace(txtTenMauSac.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (mauSacBUS.SuaMauSac(mauSac))
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
