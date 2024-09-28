using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MauSacBUS
    {
        MauSacDAO mauSacDAO = new MauSacDAO();

        // Lấy danh sách màu sắc
        public List<MauSac> LayDanhSachMauSac()
        {
            return mauSacDAO.LayDanhSachMauSac();
        }

        // Thêm màu sắc
        public bool ThemMauSac(MauSac mauSac)
        {
            foreach (var item in mauSacDAO.LayDanhSachMauSac())
            {
                if (item.TenMauSac == mauSac.TenMauSac && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return mauSacDAO.ThemMauSac(mauSac);
        }

        // Sửa màu sắc
        public bool SuaMauSac(MauSac mauSac)
        {
            foreach (var item in mauSacDAO.LayDanhSachMauSac())
            {
                if (item.TenMauSac == mauSac.TenMauSac && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return mauSacDAO.SuaMauSac(mauSac);
        }

        // Xóa màu sắc
        public bool XoaMauSac(MauSac mauSac)
        {
            return mauSacDAO.XoaMauSac(mauSac);
        }

        // Lấy danh sách tên màu sắc
        public List<string> LayDanhSachTenMauSac()
        {
            List<string> danhSachTenMauSac = new List<string>();
            foreach (var item in mauSacDAO.LayDanhSachMauSac())
            {
                if (item.TrangThai == 1)
                {
                    danhSachTenMauSac.Add(item.TenMauSac);
                }
            }
            return danhSachTenMauSac;
        }

        // Lấy màu sắc qua tên
        public MauSac LayMauSacQuaTen(string tenMauSac)
        {
            foreach (var item in mauSacDAO.LayDanhSachMauSac())
            {
                if (item.TenMauSac == tenMauSac && item.TrangThai == 1)
                {
                    return item;
                }
            }
            return null;
        }

        // Lấy màu sắc qua mã
        public MauSac LayMauSacQuaMa(int maMauSac)
        {
            foreach (var item in mauSacDAO.LayDanhSachMauSac())
            {
                if (item.MaMauSac == maMauSac && item.TrangThai == 1)
                {
                    return item;
                }
            }
            return null;
        }

        // Tìm kiếm màu sắc
        public List<MauSac> TimKiemMauSac(string keyWord)
        {
            return mauSacDAO.TimKiemMauSac(keyWord);
        }


        MauSacDAO ms1 = new MauSacDAO();
        public MauSac getFromCTSP(String ctsp)
        {
            return ms1.getMauSacfromCTSP(ctsp);
        }



    }
}
