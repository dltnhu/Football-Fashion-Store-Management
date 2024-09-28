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
    public partial class KhuyenMaiModule : Form
    {
        public int MaKhuyenMai { get; set; }
        KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();

        public KhuyenMaiModule()
        {
            InitializeComponent();
        }

        public KhuyenMaiModule(int maKhuyenMai)
        {
            InitializeComponent();
            this.MaKhuyenMai = maKhuyenMai;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDieuKien.Text) || string.IsNullOrWhiteSpace(txtMucKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                KhuyenMai khuyenmai = new KhuyenMai();
                khuyenmai.MucKhuyenMai = Convert.ToSingle(txtMucKhuyenMai.Text);
                khuyenmai.DieuKien = txtDieuKien.Text;
                khuyenmai.ThoiGianBatDau = dateBatDau.Value;
                khuyenmai.ThoiGianKetThuc = dateKetThuc.Value;
                khuyenmai.TrangThai = 1;
                if (khuyenMaiBUS.themKhuyenMai(khuyenmai))
                {
                    MessageBox.Show("Thêm Thành Công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDieuKien.Text) || string.IsNullOrWhiteSpace(txtMucKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                KhuyenMai khuyenmai = new KhuyenMai();
                khuyenmai.MaKhuyenMai = this.MaKhuyenMai;
                khuyenmai.MucKhuyenMai = Convert.ToSingle(txtMucKhuyenMai.Text);
                khuyenmai.DieuKien = txtDieuKien.Text;
                khuyenmai.ThoiGianBatDau = dateBatDau.Value;
                khuyenmai.ThoiGianKetThuc = dateKetThuc.Value;
                khuyenmai.TrangThai = 1;
                if (khuyenMaiBUS.SuaKhuyenMai(khuyenmai))
                {
                    MessageBox.Show("Sửa Thành Công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }
    }
}
