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
    public partial class KichCoModule : Form
    {
        KichCoBUS kichCoBUS = new KichCoBUS();
        public int MaKichCo { get; set; }

        public KichCoModule()
        {
            InitializeComponent();
        }

        public KichCoModule(int maKichCo)
        {
            InitializeComponent();
            this.MaKichCo = maKichCo;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KichCo kichCo = new KichCo();
            kichCo.TenKichCo = txtTenKichCo.Text;
            kichCo.TrangThai = 1;
            if (string.IsNullOrWhiteSpace(txtTenKichCo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (kichCoBUS.ThemKichCo(kichCo))
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
            KichCo kichCo = new KichCo();
            kichCo.MaKichCo = this.MaKichCo;
            kichCo.TenKichCo = txtTenKichCo.Text;
            kichCo.TrangThai = 1;
            if (string.IsNullOrWhiteSpace(txtTenKichCo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (kichCoBUS.SuaKichCo(kichCo))
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
