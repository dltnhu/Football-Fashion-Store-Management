using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAO khuyenMaiDAO = new KhuyenMaiDAO();
        public List<KhuyenMai> LayToanBoKhuyenMai()
        {
            return khuyenMaiDAO.getAllListKhuyenMai();
        }

        public bool themKhuyenMai(KhuyenMai khuyenMai)
        {
            foreach (var item in khuyenMaiDAO.getAllListKhuyenMai())
            {
                if (item.DieuKien == khuyenMai.DieuKien)
                {
                    return false;
                }
            }
            return khuyenMaiDAO.ThemKhuyenMai(khuyenMai);
        }

        public bool SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            foreach (var item in khuyenMaiDAO.getAllListKhuyenMai())
            {
                if (item.DieuKien == khuyenMai.DieuKien)
                {
                    return false;
                }
            }
            return khuyenMaiDAO.SuaKhuyenMai(khuyenMai);
        }

        public bool XoaKhuyenMai(KhuyenMai khuyenMai)
        {
            return khuyenMaiDAO.XoaKhuyenMai(khuyenMai);
        }

        public KhuyenMai LayKhuyenMaiQuaMa(int maKhuyenMai)
        {
            foreach (var item in khuyenMaiDAO.getAllListKhuyenMai()) 
            {
                if(item.MaKhuyenMai == maKhuyenMai)
                {
                    return item;
                }
            }
            return null;
        }

        KhuyenMaiDAO km = new KhuyenMaiDAO();
        public ArrayList getAllList()
        {
            return km.getAllListKhuyenMai1();
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string text)
        {
            return khuyenMaiDAO.TimKiemKhuyenMai(text);
        }
    }
}
