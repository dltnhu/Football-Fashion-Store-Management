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
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAO chiTietPhieuNhapDAO = new ChiTietPhieuNhapDAO();
        public List<ChiTietPhieuNhap> LayToanBoChiTietPhieuNhap()
        {
            return chiTietPhieuNhapDAO.LayToanBoChiTietPhieuNhap();
        }
        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            return chiTietPhieuNhapDAO.ThemChiTietPhieuNhap(chiTietPhieuNhap);
        }
        public bool XoaChiTietPhieuNhap(int maChiTietPhieuNhap)
        {
            return chiTietPhieuNhapDAO.XoaChiTietPhieuNhap(maChiTietPhieuNhap);
        }
        public bool SuaChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            return chiTietPhieuNhapDAO.SuaChiTietPhieuNhap(chiTietPhieuNhap);
        }
        public List<ChiTietPhieuNhap> TimKiemChiTietPhieuNhap(string text)
        {
            return chiTietPhieuNhapDAO.TimKiemChiTietPhieuNhap(text);
        }
    }
}
