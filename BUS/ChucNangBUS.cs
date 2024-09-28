using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucNangBUS
    {
        ChucNangDAO chucNangDAO = new ChucNangDAO();

        // lấy danh sách chức năng
        public List<ChucNang> LayDanhSachChucNang()
        {
            return chucNangDAO.LayDanhSachChucNang();
        }

        // Thêm chức năng
        public bool ThemChucNang(ChucNang chucNang)
        {
            foreach (var item in chucNangDAO.LayDanhSachChucNang())
            {
                if(item.TenChucNang == chucNang.TenChucNang)
                {
                    return false;
                }
            }
            return chucNangDAO.ThemChucNang(chucNang);
        }

        // Sửa chức năng
        public bool SuaChucNang(ChucNang chucNang)
        {
            foreach (var item in chucNangDAO.LayDanhSachChucNang())
            {
                if (item.TenChucNang == chucNang.TenChucNang)
                {
                    return false;
                }

            }
            return chucNangDAO.SuaChucNang(chucNang);
        }

        // Xóa chức năng
        public bool XoaChucNang(int maChucNang)
        {
            return chucNangDAO.XoaChucNang(maChucNang);
        }

        // Tìm kiếm chức năng
        public List<ChucNang> TimKiemChucNang(string text)
        {
            return chucNangDAO.TimKiemChucNang(text);
        }

        // Lấy chức năng qua mã
        public ChucNang LayChucNangQuaMa(int maChucNang)
        {

            foreach (var item in chucNangDAO.LayDanhSachChucNang())
            {
                if(item.MaChucNang == maChucNang)
                {
                    return item;
                }
            }
            return null;
        }

        // Lấy chức năng qua tên
        public ChucNang LayChucNangQuaTen(string tenChucNang)
        {
            foreach (var item in chucNangDAO.LayDanhSachChucNang())
            {
                if (item.TenChucNang == tenChucNang)
                {
                    return item;
                }
            }
            return null;
        }

        // Lấy danh sách tên chức năng
        public List<string> LayDanhSachTenChucNang()
        {
            List<string> list = new List<string>();
            foreach (var i in chucNangDAO.LayDanhSachChucNang())
            {
                list.Add(i.TenChucNang);
            }
            return list;
        }



        public string TenChucNang(int machucnang)
        {
            return chucNangDAO.getTenChucNang(machucnang);
        }

        public int getMaChucNang(string tenChucNang)
        {
            return chucNangDAO.getMaChucNang(tenChucNang);
        }

        

       


        public bool KiemTraChucNang(string tenchucnang)
        {
            return chucNangDAO.KiemTraChucNang(tenchucnang);
        }

        
    }
}
