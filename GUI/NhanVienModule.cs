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
    public partial class NhanVienModule : Form
    {
        public int MaNhanVien { get; set; }
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public NhanVienModule()
        {
            InitializeComponent();
        }

        public NhanVienModule(int maNhanVien)
        {
            InitializeComponent();
            this.MaNhanVien = maNhanVien;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || string.IsNullOrWhiteSpace(txtTuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.TenNhanVien = txtTenNhanVien.Text;
                nhanVien.Tuoi = Convert.ToInt32(txtTuoi.Text);
                nhanVien.SoDienThoai = txtSoDienThoai.Text;
                // Chuyển từ đối tượng ảnh sang mảng byte
                byte[] anhByte;
                using (MemoryStream ms = new MemoryStream())
                {
                    picNhanVien.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    anhByte = ms.ToArray();
                }
                nhanVien.HinhAnh = anhByte;
                nhanVien.TrangThai = 1;
                if (nhanVienBUS.ThemNhanVien(nhanVien))
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

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picNhanVien.ImageLocation = dialog.FileName.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || string.IsNullOrWhiteSpace(txtTuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNhanVien = this.MaNhanVien;
                nhanVien.TenNhanVien = txtTenNhanVien.Text;
                nhanVien.Tuoi = Convert.ToInt32(txtTuoi.Text);
                nhanVien.SoDienThoai = txtSoDienThoai.Text;
                // Chuyển từ đối tượng ảnh sang mảng byte
                byte[] anhByte;
                using (MemoryStream ms = new MemoryStream())
                {
                    picNhanVien.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    anhByte = ms.ToArray();
                }
                nhanVien.HinhAnh = anhByte;
                nhanVien.TrangThai = 1;
                if (nhanVienBUS.SuaNhanVien(nhanVien))
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
    }
}
