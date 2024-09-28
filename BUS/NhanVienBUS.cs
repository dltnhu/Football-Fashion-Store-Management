using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        // Lấy danh sách nhân viên
        public List<NhanVien> LayDanhSachNhanVien()
        {
            return nhanVienDAO.LayDanhSachNhanVien();
        }


        // Thêm nhân viên

        public bool ThemNhanVien(NhanVien nhanVien)
        {
            return nhanVienDAO.ThemNhanVien(nhanVien);
        }

        // Sửa nhân viên
        public bool SuaNhanVien(NhanVien nhanVien)
        {
            return nhanVienDAO.SuaNhanVien(nhanVien);
        }

        // Xóa nhân viên
        public bool XoaNhanVien(int MaNhanVien)
        {
            return nhanVienDAO.XoaNhanVien(MaNhanVien);
        }


        // Tìm kiếm nhân viên
        public List<NhanVien> TimKiemNhanVien(string text)
        {
            return nhanVienDAO.TimKiemNhanVien(text);
        }

        // Lấy nhân viên qua mã
        public NhanVien LayNhanVienQuaMa(int maNhanVien)
        {
            foreach (var item in nhanVienDAO.LayDanhSachNhanVien())
            {
                if(item.MaNhanVien == maNhanVien)
                {
                    return item;
                }
            }
            return null;
        }

        // lấy danh sách tên nhân viên
        public List<string> DanhSachTenNhanVien()
        {
            List<string> list = new List<string>();
            foreach (var i in nhanVienDAO.LayDanhSachNhanVien())
            {
                list.Add(i.MaNhanVien + "-" + i.TenNhanVien);
            }
            return list;
        }
    }
}
