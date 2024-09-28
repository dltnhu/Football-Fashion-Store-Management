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
    public class TaiKhoanBUS
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        // Lấy danh sách tài khoản  
        public List<TaiKhoan> LayDanhSachTaiKhoan()
        {
            return taiKhoanDAO.LayDanhSachTaiKhoan();
        }

        // Thêm tài khoản
        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            return taiKhoanDAO.ThemTaiKhoan(taiKhoan);
        }

        // Xóa tài khoản
        public bool XoaTaiKhoan(int MaTaiKhoan)
        {
            return taiKhoanDAO.XoaTaiKhoan(MaTaiKhoan);
        }

        // Sửa tài khoản
        public bool SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            return taiKhoanDAO.SuaTaiKhoan(taiKhoan);
        }

        // Đăng nhập
        public bool DangNhap(string taikhoan, string matkhau)
        {
            return taiKhoanDAO.DangNhap(taikhoan, matkhau);
        }

        // Tìm kiếm tài khoản
        public List<TaiKhoan> TimKiemTaiKhoan(string text)
        {
            return taiKhoanDAO.TimKiemTaiKhoan(text);
        }

        public TaiKhoan LayTaiKhoanQuaMa(int maTaiKhoan)
        {
            foreach (var item in taiKhoanDAO.LayDanhSachTaiKhoan()) 
            {
                if(item.MaTaiKhoan == maTaiKhoan)
                {
                    return item;
                }
            }
            return null;
        }

        public TaiKhoan LayThongTinTaiKhoan(string tenDangNhap, string matKhau)
        {
            foreach (var item in taiKhoanDAO.LayDanhSachTaiKhoan())
            {
                if(item.TenTaikhoan == tenDangNhap && item.MatKhau == matKhau)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
