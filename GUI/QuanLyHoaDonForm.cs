using BUS;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApp3.GUI
{
    public partial class QuanLyHoaDonForm : Form
    {



        private HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();
        private ArrayList listHoaDon = new ArrayList();
        public QuanLyHoaDonForm()
        {
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            this.listHoaDon = hoaDonBUS.getAllList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int index = e.RowIndex;
            HoaDon hd = (HoaDon)this.listHoaDon[index];
            this.dgvCTHD.DataSource = chiTietHoaDonBUS.pushToDGV(hd.MaHoaDon + "");


        }

        private void QuanLyHoaDonForm_Load(object sender, EventArgs e)
        {
            this.dgvHoaDon.DataSource = hoaDonBUS.push();
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.dgvHoaDon.DataSource = this.hoaDonBUS.TimKiem(this.txtTimKiem.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtTimKiem.Text = "";
        }
    }
}
