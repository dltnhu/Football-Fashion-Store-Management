using BUS;
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
    public partial class HoaDonModel : Form
    {
        private HoaDonBUS hoaDonBUS = new HoaDonBUS();
        ChiTietHoaDonBUS ChiTietHoaDonBUS = new ChiTietHoaDonBUS();
        int maHoaDon;
        public HoaDonModel(int maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDonFormThongKe_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void HoaDonModel_Load(object sender, EventArgs e)
        {
            this.DanhSachChiTietSanPhamHoaDon.RowCount = 0;
            this.DanhSachChiTietSanPhamHoaDon.DataSource = ChiTietHoaDonBUS.pushToDGV(maHoaDon + "");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void danhSachChiTietSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
