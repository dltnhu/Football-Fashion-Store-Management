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

namespace BUS
{
    public class ChiTietQuyenBUS
    {
        // lấy danh sách chi tiết quyền
        ChiTietQuyenDAO chiTietQuyenDAO = new ChiTietQuyenDAO();
        public List<ChiTietQuyen> LayDanhSachChiTietQuyen()
        {
            return chiTietQuyenDAO.LayDanhSachChiTietQuyen();
        }

        // Tìm kiếm chi tiết quyền
        public List<ChiTietQuyen> TimKiemChiTietQuyen(string text)
        {
            return chiTietQuyenDAO.TimKiemChiTietQuyen(text);
        }

        // lấy chi tiết quyền qua mã
        public ChiTietQuyen LayChiTietQuyenQuaMa(int maChiTietQuyen)
        {
            foreach (var item in chiTietQuyenDAO.LayDanhSachChiTietQuyen())
            {
                if(item.MaChiTietQuyen == maChiTietQuyen)
                {
                    return item;
                }
            }
            return null;
        }

        // Thêm chi tiết quyền
        public bool ThemChiTietQuyen(ChiTietQuyen chiTietQuyen)
        {
            foreach (var item in chiTietQuyenDAO.LayDanhSachChiTietQuyen())
            {
                if(item.MaNhomQuyen == chiTietQuyen.MaNhomQuyen 
                    && item.MaChucNang == chiTietQuyen.MaChucNang
                    && item.HanhDong == chiTietQuyen.HanhDong)
                {
                    return false;
                }
            }
            return chiTietQuyenDAO.ThemChiTietQuyen(chiTietQuyen);
        }

        // Xóa chi tiết quyền
        public bool XoaChiTietQuyen(int maChiTietQuyen)
        {
            return chiTietQuyenDAO.XoaChiTietQuyen(maChiTietQuyen);
        }

        // Sửa chi tiết quyền
        public bool SuaChiTietQuyen(ChiTietQuyen chiTietQuyen)
        {
            foreach (var item in chiTietQuyenDAO.LayDanhSachChiTietQuyen())
            {
                if (item.MaNhomQuyen == chiTietQuyen.MaNhomQuyen
                    && item.MaChucNang == chiTietQuyen.MaChucNang
                    && item.HanhDong == chiTietQuyen.HanhDong)
                {
                    return false;
                }
            }
            return chiTietQuyenDAO.SuaChiTietQuyen(chiTietQuyen);
        }

        // Lấy toàn bộ chức năng thông qua mã nhóm quyền
        public List<int> LayDanhSachChucNang(int maNhomQuyen)
        {
            return chiTietQuyenDAO.LayDanhSachChucNang(maNhomQuyen);
        }

        // Kiểm tra hành động của nhóm quyền đối với chức năng
        public bool kiemTraHanhDong(int manhomquyen, int machucnang, string HanhDong)
        {
            foreach (var item in chiTietQuyenDAO.LayDanhSachChiTietQuyen())
            {
                if(item.MaNhomQuyen == manhomquyen && item.MaChucNang == machucnang && item.HanhDong == HanhDong) {
                    return true;
                }
            }
            return false;
        }
    }
}
