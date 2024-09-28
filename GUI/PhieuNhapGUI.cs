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
    public partial class PhieuNhapGUI : Form
    {
        public int NhanVien { get; set; }
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        public PhieuNhapGUI()

        {
            InitializeComponent();
            LoadDataPhieuNhap();

        }

        public PhieuNhapGUI(int maNhanVien)
        {
            InitializeComponent();
            LoadDataPhieuNhap();
            this.NhanVien = maNhanVien;


        }


        public void LoadDataPhieuNhap()
        {
            danhSachPhieuNhap.RowCount = 0;
            foreach (var item in phieuNhapBUS.LayToanBoPhieuNhap())
            {
                if (item.TrangThai == 1)
                {
                    danhSachPhieuNhap.Rows.Add(item.MaPhieuNhap, nhaCungCapBUS.LayNhaCungCapQuaMa(item.MaNhaCungCap).TenNhaCungCap, nhanVienBUS.LayNhanVienQuaMa(item.MaNhanVien).TenNhanVien, item.NgayNhap, item.TenPhieuNhap, item.TongTienNhap);
                }
            }
        }


        public void showDialogThem(PhieuNhapModule phieuNhapModule)
        {
            int maPhieuNhap;
            if (phieuNhapBUS.LayToanBoPhieuNhap().Count == 0)
            {
                maPhieuNhap = 1;
            }
            else
            {
                PhieuNhap phieuNhap = phieuNhapBUS.LayToanBoPhieuNhap().Last();
                maPhieuNhap = phieuNhap.MaPhieuNhap + 1;

            }
            phieuNhapModule.txtMaPhieuNhap.Text = maPhieuNhap + "";
            phieuNhapModule.txtNgayNhap.Text = DateTime.Now.ToString();
            phieuNhapModule.txtTenNhanVien.Text = nhanVienBUS.LayNhanVienQuaMa(this.NhanVien).TenNhanVien;
            phieuNhapModule.comboxNhaCungCap.DataSource = nhaCungCapBUS.LayDanhSachTenNhaCungCap();
            LoadDataChiTietSanPham(phieuNhapModule);


        }

        public void LoadDataChiTietSanPham(PhieuNhapModule phieuNhapModule)
        {
            phieuNhapModule.danhSachChiTietSanPham.RowCount = 0;
            foreach (var item in chiTietSanPhamBUS.LayToanBoChiTietSanPham())
            {
                if (item.HinhAnh != null && item.HinhAnh.Length > 0)
                {
                    // Chuyển từ kiểu Byte sang đối tượng Image 
                    Image image;
                    using (MemoryStream ms = new MemoryStream(item.HinhAnh))
                    {
                        image = Image.FromStream(ms);
                    }
                    phieuNhapModule.danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, image, item.SoLuongNhap, item.SoLuongTon);
                }
                else
                {
                    phieuNhapModule.danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, GUI.Properties.Resources.Product, item.SoLuongNhap, item.SoLuongTon);
                }
            }
        }

        private void danhSachPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachPhieuNhap.Rows[e.RowIndex];
            int maPhieuNhap = Convert.ToInt32(row.Cells[0].Value.ToString());
            PhieuNhap phieuNhap = phieuNhapBUS.LayPhieuNhapQuaMa(maPhieuNhap);


            string selectedColumnName = danhSachPhieuNhap.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "ChiTiet")
            {
                ChiTietPhieuNhapGUI chiTietPhieuNhapGUI = new ChiTietPhieuNhapGUI(phieuNhap.MaPhieuNhap);
                chiTietPhieuNhapGUI.FormBorderStyle = FormBorderStyle.Sizable;
                chiTietPhieuNhapGUI.ShowDialog();

            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            PhieuNhapModule phieuNhapModule = new PhieuNhapModule(this.NhanVien);
            showDialogThem(phieuNhapModule);
            phieuNhapModule.ShowDialog();
            LoadDataPhieuNhap();

        }
    }
}
