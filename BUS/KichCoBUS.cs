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
    public class KichCoBUS
    {
        KichCoDAO kichCoDAO = new KichCoDAO();

        // Lấy danh sách kích cỡ
        public List<KichCo> LayDanhSachKichCo()
        {
            return kichCoDAO.LayDanhSachKichCo();
        }

        // Thêm kích cỡ
        public bool ThemKichCo(KichCo kichCo)
        {
            foreach (var item in kichCoDAO.LayDanhSachKichCo())
            {
                if (item.TenKichCo == kichCo.TenKichCo && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return kichCoDAO.ThemKichCo(kichCo);
        }

        // Xóa kích cỡ
        public bool XoaKichCo(KichCo kichCo)
        {
            return kichCoDAO.XoaKichCo(kichCo);
        }

        // Sửa kích cỡ
        public bool SuaKichCo(KichCo kichCo)
        {
            foreach (var item in kichCoDAO.LayDanhSachKichCo())
            {
                if (item.TenKichCo == kichCo.TenKichCo && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return kichCoDAO.SuaKichCo(kichCo);
        }

        // lấy danh sách tên kích cỡ
        public List<string> LayDanhSachTenKichCo()
        {
            List<string> danhSachTenKichCo = new List<string>();
            foreach (var item in kichCoDAO.LayDanhSachKichCo())
            {
                if (item.TrangThai == 1)
                {
                    danhSachTenKichCo.Add(item.TenKichCo);
                }
            }
            return danhSachTenKichCo;
        }

        // lấy thông tin kích cỡ thông qua mã
        public KichCo LayKichCoQuaMa(int maKichCo)
        {
            foreach (var item in kichCoDAO.LayDanhSachKichCo())
            {
                if (item.MaKichCo == maKichCo && item.TrangThai == 1)
                {
                    return item;
                }
            }
            return null;
        }

        // lấy thông tin kích cỡ thông qua tên
        public KichCo LayKichCoQuaTen(string tenKichCo)
        {
            foreach (var item in kichCoDAO.LayDanhSachKichCo())
            {
                if (item.TenKichCo == tenKichCo && item.TrangThai == 1)
                {
                    return item;
                }
            }
            return null;
        }


        // tìm kiếm kích cỡ
        public List<KichCo> TimKiemKichCo(string keyWord)
        {
            return kichCoDAO.TimKiemKichCo(keyWord);
        }



        KichCoDAO kc1 = new KichCoDAO();
        public ArrayList getAllList(SanPham sp)
        {
            return kc1.getAllListKichCo(sp);
        }

        public KichCo getFromCTSP(String ctsp)
        {
            return kc1.getAllListKichCoFromCTSP(ctsp);
        }
    }
}
