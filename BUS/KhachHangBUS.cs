using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO KhachHangDAO = new KhachHangDAO();

        public ArrayList GetAllList()
        {
            return KhachHangDAO.GetAllList();
        }

        public bool hasInDB(String SoDienThoai)
        {
            return KhachHangDAO.hasInDB(SoDienThoai);
        }

        public String ThemThongTinKhachHang(KhachHang kh)
        {
            if (KhachHangDAO.ThemThongTinKhachHang(kh) )
            {   
                return "Bạn đã thêm thông tin khách hàng thành công!";
            }    
            return "Thêm thông tin thất bại!";
        }
        public DataTable getAlKhachHang()
        {
            return KhachHangDAO.getAllKhachHang();
        }

        public KhachHang getFromSoDienThoai(String SoDienThoai)
        {
            return KhachHangDAO.GetFromSoDienThoai(SoDienThoai);
        }
        public String suaFromSoDienThoai(KhachHang kh, String ten, String sdt)
        {
            if (KhachHangDAO.SuaThongTinKhachHang(kh,ten,sdt))
            {
                return "Bạn đã sửa thông tin khách hàng thành công!";
            }
            return "Sửa thông tin thất bại!";
        }
        public bool XoaThongTinKhachHang(KhachHang kh)
        {
            return KhachHangDAO.XoaThongTinKhachHang(kh);
        }


        public DataTable TimKiemThongTinKhachHang(String text)
        {
            return KhachHangDAO.TimKiem(text);
        }

        public KhachHang LayKhachHangTuMa(String MaKhachHang)
        {
            return KhachHangDAO.LayKhachHangTuMa(MaKhachHang);
        }

    }
}
