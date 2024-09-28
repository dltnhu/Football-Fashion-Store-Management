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
    public class PhieuNhapBUS
    {
        PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        public List<PhieuNhap> LayToanBoPhieuNhap()
        {
            return phieuNhapDAO.LayToanBoPhieuNhap();
        }
        public bool ThemPhieuNhap(PhieuNhap phieuNhap)
        {
            return phieuNhapDAO.ThemPhieuNhap(phieuNhap);
        }

        public bool XoaPhieuNhap(int maPhieuNhap)
        {
            return phieuNhapDAO.XoaPhieuNhap(maPhieuNhap);
        }

        public bool SuaPhieuNhap(PhieuNhap phieuNhap)
        {
            return phieuNhapDAO.SuaPhieuNhap(phieuNhap);
        }

        public List<PhieuNhap> TimKiemPhieuNhap(string text)
        {
            return phieuNhapDAO.TimKiemPhieuNhap(text);
        }

        public PhieuNhap LayPhieuNhapQuaMa(int maPhieuNhap)
        {
            foreach (var item in LayToanBoPhieuNhap())
            {
                if (item.MaPhieuNhap == maPhieuNhap)
                {
                    return item;
                }
            }
            return null;
        }
        public List<PhieuNhap> LayToanBoPhieuNhapTrongKhoang(String DateStart, String DateEnd)
        {
            return phieuNhapDAO.LayToanBoPhieuNhapTrongKhoang(DateStart,DateEnd);
        }
    }
}
