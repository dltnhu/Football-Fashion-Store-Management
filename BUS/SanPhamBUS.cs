using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanPhamDAO = new SanPhamDAO();
        TheLoaiDAO theLoaiDAO = new TheLoaiDAO();
        ChatLieuDAO chatLieuDAO = new ChatLieuDAO();
        ChiTietSanPhamDAO chiTietSanPhamDAO = new ChiTietSanPhamDAO();

        // lấy danh sách sản phẩm
        public List<SanPham> LayDanhSachSanPham()
        {
            return sanPhamDAO.LayDanhSachSanPham();
        }

        // thêm sản phẩm
        public bool ThemSanPham(SanPham sanPham)
        {
            foreach (var item in sanPhamDAO.LayDanhSachSanPham())
            {
                if (item.TenSanPham == sanPham.TenSanPham &&
                    item.MaTheLoai == sanPham.MaTheLoai &&
                    item.MaChatLieu == item.MaChatLieu &&
                    item.MaThuongHieu == sanPham.MaThuongHieu &&
                    item.TrangThai == 1)
                {
                    return false;
                }
            }
            return sanPhamDAO.ThemSanPham(sanPham);
        }

        // Sửa sản phẩm
        public bool SuaSanPham(SanPham sanPham)
        {
            foreach (var item in sanPhamDAO.LayDanhSachSanPham())
            {
                if (item.TenSanPham == sanPham.TenSanPham && 
                    item.MaTheLoai == sanPham.MaTheLoai && 
                    item.MaThuongHieu == sanPham.MaThuongHieu &&
                    item.MaChatLieu == sanPham.MaChatLieu &&
                    item.GiaSanPham == sanPham.GiaSanPham && 
                    
                    item.TrangThai == 1)
                {
                    return false;
                }
            }
            return sanPhamDAO.SuaSanPham(sanPham);
        }

        // Xóa sản phẩm
        public bool XoaSanPham(int maSanPham)
        {
            return sanPhamDAO.XoaSanPham(maSanPham);
        }

        public SanPham LaySanPhamQuaMa(int maSanPham)
        {
            SanPham sanPham = new SanPham();
            foreach (var item in sanPhamDAO.LayDanhSachSanPham())
            {
                if (item.TrangThai == 1 && item.MaSanPham == maSanPham)
                {
                    sanPham = item;
                }
            }
            return sanPham;
        }

        // Lấy danh sách mã sản phẩm
        public List<int> LayDanhSachMaSanPham()
        {
            List<int> danhSachMaSanPham = new List<int>();
            foreach (SanPham sanPham in sanPhamDAO.LayDanhSachSanPham())
            {
                danhSachMaSanPham.Add(sanPham.MaSanPham);
            }
            return danhSachMaSanPham;
        }


        // cập nhật số lướng
        public bool capNhatSoLuong(int maSanPham)
        {
            int slNhap = 0;
            int slTon = 0;
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if(item.TrangThai == 1 && item.MaSanPham == maSanPham)
                {
                    
                    slNhap += item.SoLuongNhap;
                    slTon += item.SoLuongTon;
                    
                }
                
            }
            return sanPhamDAO.capNhatSoLuong(maSanPham, slNhap, slTon);
        }

        // tìm kiếm sản phẩm
        public List<SanPham> TimKiemSanPham(string text)
        {
            return sanPhamDAO.TimKiemSanPham(text);
        }










        SanPhamDAO sp1 = new SanPhamDAO();
        public DataTable getAllDataTable()
        {
            return sp1.getAllSanPham();
        }

        public ArrayList getAllList()
        {
            return sp1.getAllListSanPham();
        }

        public SanPham getFromMa(String ma)
        {
            return sp1.getSanPham(ma);
        }
        public SanPham getFromCTSP(String ma)
        {
            return sp1.getSanPhamFromCTSP(ma);
        }

        public int getSoLuongTonFromMa(String ma)
        {
            return sp1.getSoLuongTonfromMa(ma);
        }
        public int getSoLuongBanFromMa(String ma)
        {
            return sp1.getSoLuongTonfromMa(ma);
        }

        public bool updateSoLuong(int slBan, String ma)
        {
            return sp1.updateSoLuong(slBan, ma);
        }

        public ArrayList timkiemDGV(String text)
        {
            return sp1.TimKiemSanPhamDGV(text);
        }

        public ArrayList getAllSanPhamDGV()
        {
            return sp1.getAllListSanPham();
        }



    }
}
