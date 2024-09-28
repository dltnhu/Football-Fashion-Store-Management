using BUS;
using DTO;
using System;
using System.Collections;
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
    public partial class ThongKeGUI : Form
    {
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        ThueBUS thueBUS = new ThueBUS();
        KhuyenMaiBUS KhuyenMaiBUS = new KhuyenMaiBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();
        private float DoanhThu;
        private String dateStart = "";
        private String dateEnd = "";
        public float tongTienHoaDon = 0;
        public float tongTienPhieuNhap = 0;

        public ThongKeGUI()
        {
            InitializeComponent();
            LoadDataPhieuNhap();
            LoadDataSanPham();
            LoadDataHoaDon();
            DoanhThu = tongTienHoaDon - tongTienPhieuNhap;
            LoadDuLieuTong(DoanhThu);

        }
        private void LoadDuLieuTong(float loi)
        {
            if (loi >= 0)
            {
                this.lbLoi.Text = "LỜI";
                this.lbTongThuDuoc.Text = string.Format("{0:0,0.0}", loi) + "VNĐ";
                this.lbLoi.ForeColor = Color.White;
                this.lbTongThuDuoc.ForeColor = Color.White;
            }
            else
            {
                this.lbLoi.Text = "LỖ";
                this.lbTongThuDuoc.Text = string.Format("{0:0,0.0}", loi * (-1)) + "VNĐ";
                this.lbLoi.ForeColor = Color.Red;
                this.lbTongThuDuoc.ForeColor = Color.Red;

            }

        }


        private void LoadDataHoaDon()
        {
            DoanhThu = 0;
            danhSachHoaDon.RowCount = 0;
            foreach (HoaDon item in hoaDonBUS.getAllList())
            {
                danhSachHoaDon.Rows.Add(item.MaHoaDon, item.MaThue, item.MaKhachHang, item.MaNhanVien, item.MaKhuyenMai,
                    item.MaHoaDon, item.NgayLapHoaDon, item.TongTien, item.HinhThucThanhToan, item.ThanhTien);
                tongTienHoaDon += item.ThanhTien;
            }
            lbTongHoaDon.Text = danhSachHoaDon.RowCount + "";
            lbDoanhThu.Text = string.Format("{0:0,0.0}", this.tongTienHoaDon) + "VNĐ";


        }


        public void LoadDataPhieuNhap()
        {
            danhSachPhieuNhap.RowCount = 0;
            foreach (var item in phieuNhapBUS.LayToanBoPhieuNhap())
            {
                if (item.TrangThai == 1)
                {
                    danhSachPhieuNhap.Rows.Add(item.MaPhieuNhap, nhaCungCapBUS.LayNhaCungCapQuaMa(item.MaNhaCungCap).TenNhaCungCap, nhanVienBUS.LayNhanVienQuaMa(item.MaNhanVien).TenNhanVien, item.NgayNhap, item.TenPhieuNhap, item.TongTienNhap);
                    tongTienPhieuNhap += item.TongTienNhap;
                }
            }
            lbTongPhieuNhap.Text = danhSachPhieuNhap.RowCount + "";
            lbTienNhap.Text = string.Format("{0:0,0.0}", this.tongTienPhieuNhap) + "VNĐ";
        }

        // Load dữ liệu sản phẩm lên bảng
        public void LoadDataSanPham()
        {
            danhSachSanPham.RowCount = 0;
            foreach (SanPham sanPham in sanPhamBUS.LayDanhSachSanPham())
            {
                if (sanPham.TrangThai == 1)
                {
                    danhSachSanPham.Rows.Add(
                    sanPham.MaSanPham,
                       sanPham.TenSanPham,
                       sanPham.GiaSanPham,
                       sanPham.GiaNhap,
                       sanPham.SoLuongNhap,
                       sanPham.SoLuongTon);
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

        private void danhSachChiTietSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void danhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachSanPham.Rows[e.RowIndex];
            int maSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
            SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(maSanPham);


            string selectedColumnName = danhSachSanPham.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "ChiTietSanpham")
            {
                ChiTietSanPhamGUI chiTietSanPhamGUI = new ChiTietSanPhamGUI(sanPham.MaSanPham);
                chiTietSanPhamGUI.FormBorderStyle = FormBorderStyle.Sizable;
                chiTietSanPhamGUI.ShowDialog();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string dayStart = this.dateTimeStart.Value.Day.ToString();
            string monthStart = this.dateTimeStart.Value.Month.ToString();
            string yearStart = this.dateTimeStart.Value.Year.ToString();
            dateStart = yearStart + "-" + monthStart + "-" + dayStart;
        }

        private void ThongKeGUI_Load(object sender, EventArgs e)
        {

        }

        private void pageHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void danhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String tenCot = danhSachHoaDon.Columns[e.ColumnIndex].Name;
            int maHoaDon = (int)danhSachHoaDon.Rows[e.RowIndex].Cells[0].Value;
            HoaDon hoadon = hoaDonBUS.LayHoaDonTuMa(maHoaDon + "");
            if (tenCot.Equals("ChiTietHoaDon"))
            {
                HoaDonModel hoaDonModel = new HoaDonModel(maHoaDon);
                KhachHang khachHang = khachHangBUS.LayKhachHangTuMa(hoadon.MaKhachHang + "");
                hoaDonModel.txtMaKhachHang.Text = hoadon.MaKhachHang.ToString();
                hoaDonModel.txtMaKhuyenMai.Text = hoadon.MaKhuyenMai.ToString();
                hoaDonModel.txtMaNhanVien.Text = hoadon.MaNhanVien.ToString();
                hoaDonModel.txtMaThue.Text = hoadon.MaThue.ToString();
                hoaDonModel.txtThanhTien1.Text = hoadon.ThanhTien.ToString();
                hoaDonModel.txtTenKhachHang.Text = khachHang.TenKhachHang.ToString();
                hoaDonModel.txtTongTienDonHang.Text = hoadon.TongTien + "";

                hoaDonModel.ShowDialog();
            }
        }

        private void LoadDate()
        {
            string dayEnd = this.dateTimeEnd.Value.Day.ToString();
            string monthEnd = this.dateTimeEnd.Value.Month.ToString();
            string yearEnd = this.dateTimeEnd.Value.Year.ToString();
            dateEnd = yearEnd + "-" + monthEnd + "-" + dayEnd;
            string dayStart = this.dateTimeStart.Value.Day.ToString();
            string monthStart = this.dateTimeStart.Value.Month.ToString();
            string yearStart = this.dateTimeStart.Value.Year.ToString();
            dateStart = yearStart + "-" + monthStart + "-" + dayStart;


        }
        private void dateTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            string dayEnd = this.dateTimeEnd.Value.Day.ToString();
            string monthEnd = this.dateTimeEnd.Value.Month.ToString();
            string yearEnd = this.dateTimeEnd.Value.Year.ToString();
            dateEnd = yearEnd + "-" + monthEnd + "-" + dayEnd;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            danhSachHoaDon.RowCount = 0;
            this.tongTienHoaDon = 0;
            ArrayList danhSachHoaDonTimKiem = this.hoaDonBUS.DanhSachHoaDonTrongKhoang(dateStart, dateEnd);
            //MessageBox.Show(danhSachHoaDonTimKiem.Count+"\n "+dateStart+"\n"+dateEnd);
            this.lbTongHoaDon.Text = danhSachHoaDonTimKiem.Count.ToString();
            foreach (HoaDon item in danhSachHoaDonTimKiem)
            {
                danhSachHoaDon.Rows.Add(item.MaHoaDon, item.MaThue, item.MaKhachHang, item.MaNhanVien, item.MaKhuyenMai,
                    item.MaHoaDon, item.NgayLapHoaDon, item.TongTien, item.HinhThucThanhToan, item.ThanhTien);
                tongTienHoaDon += item.ThanhTien;
            }
            lbDoanhThu.Text = string.Format("{0:0,0.0}", this.tongTienHoaDon) + "VNĐ";

            danhSachPhieuNhap.RowCount = 0;
            this.tongTienPhieuNhap = 0;
            List<PhieuNhap> danhSachPhieuNhapTimKiem = this.phieuNhapBUS.LayToanBoPhieuNhapTrongKhoang(dateStart, dateEnd);
            //MessageBox.Show(danhSachHoaDonTimKiem.Count+"\n "+dateStart+"\n"+dateEnd);
            this.lbTongPhieuNhap.Text = danhSachPhieuNhapTimKiem.Count.ToString();
            foreach (PhieuNhap item in danhSachPhieuNhapTimKiem)
            {
                danhSachPhieuNhap.Rows.Add(item.MaPhieuNhap, nhaCungCapBUS.LayNhaCungCapQuaMa(item.MaNhaCungCap).TenNhaCungCap, nhanVienBUS.LayNhanVienQuaMa(item.MaNhanVien).TenNhanVien, item.NgayNhap, item.TenPhieuNhap, item.TongTienNhap);
                tongTienPhieuNhap += item.TongTienNhap;
            }
            lbTienNhap.Text = string.Format("{0:0,0.0}", this.tongTienPhieuNhap) + "VNĐ";

            DoanhThu = tongTienHoaDon - tongTienPhieuNhap;
            LoadDuLieuTong((DoanhThu));
        }
    }
}
