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
using System.Xml.Linq;

namespace WindowsFormsApp3.GUI
{
    public partial class KhachHangForm : Form
    { //

        KhachHangBUS khachHangBUS = new KhachHangBUS();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        //
        private ArrayList list = new ArrayList();
        public KhachHangForm()
        {
            InitializeComponent();

        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            this.dgvKhachHang.DataSource = khachHangBUS.getAlKhachHang();
            list = khachHangBUS.GetAllList();

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String cln = this.dgvKhachHang.Columns[e.ColumnIndex].Name;
            if (cln.Equals("sua"))
            {
                KhachHang kh = (KhachHang)this.list[rowIndex];
                themKhachHang themKhachHang = new themKhachHang(this, kh, rowIndex, "sua");
                themKhachHang.ShowDialog();
            }
            else if (cln.Equals("xoa"))
            {
                //string sdt = this.dgvKhachHang.Rows[rowIndex].Cells[3].Value.ToString().Trim();
                KhachHang tmp = (KhachHang)this.list[rowIndex];
                khachHangBUS.XoaThongTinKhachHang(tmp);
                this.dgvKhachHang.Rows.RemoveAt(rowIndex);
                this.list.RemoveAt(rowIndex);


            }
        }



        internal void SuaDGV(String ten, String SoDienThoai, int i)
        {
            this.dgvKhachHang.Rows[i].Cells["TenKhachHang"].Value = ten;
            this.dgvKhachHang.Rows[i].Cells["SoDienThoai"].Value = SoDienThoai;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themKhachHang themKhachHang = new themKhachHang(this, new KhachHang(), -1, "them");
            themKhachHang.ShowDialog();

        }

        internal void ThemDGV(KhachHang khachHang)
        {
            this.dgvKhachHang.DataSource = khachHangBUS.getAlKhachHang();
            this.list.Add(khachHang);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.dgvKhachHang.DataSource = this.khachHangBUS.TimKiemThongTinKhachHang(this.txtTimKiem.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtTimKiem.Text = "";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            themKhachHang themKhachHang = new themKhachHang(this, new KhachHang(), -1, "them");
            themKhachHang.ShowDialog();
        }
    }
}
