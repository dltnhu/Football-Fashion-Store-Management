using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhomQuyenBUS
    {
        NhomQuyenDAO nhomQuyenDAO = new NhomQuyenDAO();

        // Lấy danh sách nhóm quyền
        public List<NhomQuyen> LayDanhSachNhomQuyen()
        {
            return nhomQuyenDAO.LayDanhSachNhomQuyen();
        }

        // Thêm nhóm quyền
        public bool ThemNhomQuyen(NhomQuyen nhomQuyen)
        {
            foreach (var item in nhomQuyenDAO.LayDanhSachNhomQuyen())
            {
                if(item.TenNhomQuyen == nhomQuyen.TenNhomQuyen)
                {
                    return false;
                }
            }
            return nhomQuyenDAO.ThemNhomQuyen(nhomQuyen);
        }

        // Lấy ra danh sách tên nhóm quyền
        public List<string> LayDanhSachTenNhomQuyen()
        {
            List<string> list = new List<string>();
            foreach (var i in nhomQuyenDAO.LayDanhSachNhomQuyen())
            {
                list.Add(i.TenNhomQuyen);
            }
            return list;
        }

        // Lấy ra nhóm quyền thông qua mã
        public NhomQuyen LayNhomQuyenQuaMa(int maNhomQuyen)
        {
            NhomQuyen nhomQuyen = new NhomQuyen();
            foreach (var item in nhomQuyenDAO.LayDanhSachNhomQuyen())
            {
                if(item.MaNhomQuyen == maNhomQuyen)
                {
                    nhomQuyen.MaNhomQuyen = item.MaNhomQuyen;
                    nhomQuyen.TenNhomQuyen = item.TenNhomQuyen;
                    nhomQuyen.TrangThai = item.TrangThai;
                }
            }
            return nhomQuyen;
        }

        // Lấy mã nhóm quyền thông qua tên
        public NhomQuyen LayNhomQuyenQuaTen(string tenNhomQuyen)
        {
            NhomQuyen nhomQuyen = new NhomQuyen();
            foreach (var item in nhomQuyenDAO.LayDanhSachNhomQuyen())
            {
                if (item.TenNhomQuyen == tenNhomQuyen)
                {
                    nhomQuyen.MaNhomQuyen = item.MaNhomQuyen;
                    nhomQuyen.TenNhomQuyen = item.TenNhomQuyen;
                    nhomQuyen.TrangThai = item.TrangThai;
                }
            }
            return nhomQuyen;
        }

        // Sửa nhóm quyền
        public bool SuaNhomQuyen(NhomQuyen nhomQuyen)
        {
            foreach (var item in nhomQuyenDAO.LayDanhSachNhomQuyen())
            {
                if (item.TenNhomQuyen == nhomQuyen.TenNhomQuyen)
                {
                    return false;
                }
            }
            return nhomQuyenDAO.SuaNhomQuyen(nhomQuyen);
        }

        // Xóa nhóm quyền
        public bool XoaNhomQuyen(int MaNhomQuyen)
        {
            return nhomQuyenDAO.XoaNhomQuyen(MaNhomQuyen);
        }

        // Tìm kiếm nhóm quyền
        public List<NhomQuyen> TimKiemNhomQuyen(string text)
        {
            return nhomQuyenDAO.TimKiemNhomQuyen(text);
        }

        
        
        
    }
}
