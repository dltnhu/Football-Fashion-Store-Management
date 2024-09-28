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
    public class TheLoaiBUS
    {
        TheLoaiDAO theLoaiDAO = new TheLoaiDAO();

        // lấy danh sách thể loại
        public List<TheLoai> LayDanhSachTheLoai()
        {
            return theLoaiDAO.LayDanhSachTheLoai();
        }

        // Thêm thể loại (Kiểm tra nếu trùng thì không thêm trừ khi trạng thái bằng = 0)
        public bool ThemTheLoai(TheLoai theLoai)
        {
            foreach (var item in theLoaiDAO.LayDanhSachTheLoai())
            {
                if (item.TenTheLoai == theLoai.TenTheLoai && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return theLoaiDAO.ThemTheLoai(theLoai);
        }

        // Sửa thể loại (kiểm tra trùng)
        public bool SuaTheLoai(TheLoai theLoai)
        {
            foreach (var item in theLoaiDAO.LayDanhSachTheLoai())
            {
                if (item.TenTheLoai == theLoai.TenTheLoai && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return theLoaiDAO.SuaTheLoai(theLoai);
        }

        // xóa thể loại
        public bool XoaTheLoai(int maTheLoai)
        {
            return theLoaiDAO.XoaTheLoai(maTheLoai);

        }

        // truyền vào mã thể loại lấy ra thể loại
        public TheLoai LayTheLoaiQuaMa(int maTheLoai)
        {
            foreach (var item in theLoaiDAO.LayDanhSachTheLoai())
            {
                if (item.MaTheLoai == maTheLoai && item.TrangThai == 1)
                {
                    return item;
                }
            }
            return null;
        }

        // truyền vào tên thể loại lấy ra thể loại
        public TheLoai LayTheLoaiQuaTen(string tenTheLoai)
        {
            foreach (var item in theLoaiDAO.LayDanhSachTheLoai())
            {
                if (item.TenTheLoai == tenTheLoai && item.TrangThai == 1)
                {
                    return item;
                }
            }
            return null;
        }

        // Lấy danh sách tên thể loại
        public List<string> LayDanhSachTenTheLoai()
        {
            List<string> danhSachTenTheLoai = new List<string>();
            foreach (var item in theLoaiDAO.LayDanhSachTheLoai())
            {
                if (item.TrangThai == 1)
                {
                    danhSachTenTheLoai.Add(item.TenTheLoai);
                }
            }
            return danhSachTenTheLoai;
        }


        // tìm kiếm thể loại
        public List<TheLoai> TimKiemTheLoai(string text)
        {
            return theLoaiDAO.TimKiemTheLoai(text);
        }

        TheLoaiDAO tl1 = new TheLoaiDAO();
        public TheLoai getFromsSP(String sp)
        {
            return tl1.getFromSP(sp);
        }



    }
}
