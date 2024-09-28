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
    public partial class ChiTietPhieuNhapGUI : Form
    {
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        public ChiTietPhieuNhapGUI()
        {
            InitializeComponent();
            LoadDataTable();
        }

        public ChiTietPhieuNhapGUI(int maPhieuNhap)
        {
            InitializeComponent();
            LoadDataTable(maPhieuNhap);
        }

        public void LoadDataTable()
        {
            danhSachChiPhieuNhap.RowCount = 0;
            foreach (var item in chiTietPhieuNhapBUS.LayToanBoChiTietPhieuNhap())
            {
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(item.MaChiTietSanPham);
                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                MauSac mauSac = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac);
                KichCo kichCo = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo);

                danhSachChiPhieuNhap.Rows.Add(item.MaChiTietPhieuNhap, phieuNhapBUS.LayPhieuNhapQuaMa(item.MaPhieuNhap).TenPhieuNhap, sanPham.TenSanPham, mauSac.TenMauSac, kichCo.TenKichCo, item.SoLuongNhap, item.DonVi, item.TienNhap, item.ThanhTien);
            }
        }

        public void LoadDataTable(int maPhieuNhap)
        {
            danhSachChiPhieuNhap.RowCount = 0;
            foreach (var item in chiTietPhieuNhapBUS.LayToanBoChiTietPhieuNhap())
            {
                if(item.MaPhieuNhap  == maPhieuNhap)
                {
                    ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(item.MaChiTietSanPham);
                    SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                    MauSac mauSac = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac);
                    KichCo kichCo = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo);

                    danhSachChiPhieuNhap.Rows.Add(item.MaChiTietPhieuNhap, phieuNhapBUS.LayPhieuNhapQuaMa(item.MaPhieuNhap).TenPhieuNhap, sanPham.TenSanPham, mauSac.TenMauSac, kichCo.TenKichCo, item.SoLuongNhap, item.DonVi, item.TienNhap, item.ThanhTien);
                }
                
            }
        }
        private void danhSachChiPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
