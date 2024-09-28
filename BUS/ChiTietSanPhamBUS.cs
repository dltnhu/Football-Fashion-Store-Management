using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BUS
{
    public class ChiTietSanPhamBUS
    {
        ChiTietSanPhamDAO chiTietSanPhamDAO = new ChiTietSanPhamDAO();

        // Lấy danh sách chi tiết sản phẩm
        public List<ChiTietSanPham> LayToanBoChiTietSanPham()
        {
            return chiTietSanPhamDAO.LayToanBoChiTietSanPham();
        }

        // Lấy danh sách chi tiết sản phẩm thông qua mã sản phẩm
        public List<ChiTietSanPham> LayDanhSachChiTietTheoMaSanPham(int maSanPham)
        {
            List<ChiTietSanPham> danhSachChiTietTheoMa = new List<ChiTietSanPham>();
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.MaSanPham == maSanPham && item.TrangThai == 1)
                {
                    if (item.TrangThai == 1)
                    {
                        danhSachChiTietTheoMa.Add(item);
                    }
                }
            }
            return danhSachChiTietTheoMa;
        }


        // THêm chi tiết sản phẩm
        public bool ThemChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            if (chiTietSanPhamDAO.LayToanBoChiTietSanPham().Count == 0)
            {
                return chiTietSanPhamDAO.ThemChiTietSanPham(chiTietSanPham);
            }
            else
            {
                foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
                {
                    if (item.MaSanPham == chiTietSanPham.MaSanPham)
                    {
                        if (item.MaMauSac == chiTietSanPham.MaMauSac && item.MaKichCo == chiTietSanPham.MaKichCo && item.HinhAnh == chiTietSanPham.HinhAnh)
                        {
                            return false;
                        }
                    }

                }
            }
            return chiTietSanPhamDAO.ThemChiTietSanPham(chiTietSanPham);
        }

        // lấy ra chi tiết sản phẩm thông qua mã sản phẩm, mã màu, mã kích cỡ
        public ChiTietSanPham TimKiemChiTietSanPham(int maSanPham, int maMauSac, int maKichCo)
        {
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.TrangThai == 1)
                {
                    if (item.MaMauSac == maMauSac && item.MaKichCo == maKichCo && item.MaSanPham == maSanPham && item.TrangThai == 1)
                    {
                        return item;
                    }
                }

            }
            return null;
        }


        // Sửa chi tiết sản phẩm
        public bool SuaChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            return chiTietSanPhamDAO.SuaChiTietSanPham(chiTietSanPham);
        }


        // Xóa chi tiết sản phẩm
        public bool XoaChiTietSanPham(int maChiTietSanPham)
        {
            return chiTietSanPhamDAO.XoaChiTietSanPham(maChiTietSanPham);
        }


        public List<ChiTietSanPham> TimKiem(string text)
        {
            return chiTietSanPhamDAO.TimKiem(text);
        }


        // Lấy ra chi tiết sản phẩm thông qua mã chi tiết sản phẩm
        public ChiTietSanPham LaySanPhamChiTietQuaMa(int maChiTietSanPham)
        {
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.MaChiTietSanPham == maChiTietSanPham)
                {
                    return item;
                }
            }
            return null;
        }

        // Cập  nhật số lượng
        public bool CapNhatSoLuong(int maChiTietSanPham, int soLuongNhap)
        {
            ChiTietSanPham chiTietSanPham = LaySanPhamChiTietQuaMa(maChiTietSanPham);
            int slNhap = chiTietSanPham.SoLuongNhap + soLuongNhap;
            int slTon = chiTietSanPham.SoLuongTon + soLuongNhap;
            return chiTietSanPhamDAO.capNhatSoLuong(maChiTietSanPham, slNhap, slTon);
        }



        public ArrayList getAllListCTSP()
        {
            ChiTietSanPhamDAO ctsp1 = new ChiTietSanPhamDAO();
            return chiTietSanPhamDAO.getAllListCTSP();
        }

        public int getSoLuongTon(String ma)
        {
            ChiTietSanPhamDAO ctsp1 = new ChiTietSanPhamDAO();
            return chiTietSanPhamDAO.getSoLuongTonCTSPfromMa(ma);
        }
        public int getSoLuongBan(String ma)
        {
            ChiTietSanPhamDAO ctsp1 = new ChiTietSanPhamDAO();
            return chiTietSanPhamDAO.getSoLuongBanCTSPfromMa(ma);
        }
        public bool updateSoLuong(int slBan, String ctsp)
        {
            ChiTietSanPhamDAO ctsp1 = new ChiTietSanPhamDAO();
            return chiTietSanPhamDAO.updateSoLuong(slBan, ctsp);
        }

        public List<ChiTietSanPham> LayToanBoChiTietSanPhamTuMaSanPham(int maSanPham)
        {
            return chiTietSanPhamDAO.LayToanBoChiTietSanPhamTuMaSanPham(maSanPham);
        }


    }

        
}
