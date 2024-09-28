using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThuongHieuBUS
    {
        ThuongHieuDAO thuongHieuDAO = new ThuongHieuDAO();

        // Lấy danh sách thương hiệu
        public List<ThuongHieu> LayDanhSachThuongHieu()
        {
            return thuongHieuDAO.LayDanhSachThuongHieu();
        }

        // Thêm thương hiệu
        public bool ThemThuongHieu(ThuongHieu thuongHieu)
        {
            foreach (var item in thuongHieuDAO.LayDanhSachThuongHieu())
            {
                if (item.TenThuongHieu == thuongHieu.TenThuongHieu && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return thuongHieuDAO.ThemThuongHieu(thuongHieu);
        }

        // Sửa thương hiệu
        public bool SuaThuongHieu(ThuongHieu thuongHieu)
        {
            foreach (var item in thuongHieuDAO.LayDanhSachThuongHieu())
            {
                if (item.TenThuongHieu == thuongHieu.TenThuongHieu && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return thuongHieuDAO.SuaThuongHieu(thuongHieu);
        }

        // Xóa thương hiệu
        public bool XoaThuongHieu(int maThuongHieu)
        {
            return thuongHieuDAO.XoaThuongHieu(maThuongHieu);
        }

        // Lấy thương hiệu qua mã
        public ThuongHieu LayThuongHieuQuaMa(int maThuongHieu)
        {
            foreach (var item in thuongHieuDAO.LayDanhSachThuongHieu())
            {
                if (item.MaThuongHieu == maThuongHieu && item.TrangThai == 1)
                {
                    return item;
                }
            }
            return null;
        }

        // Lấy thương hiệu qua tên
        public ThuongHieu LayThuongHieuQuaTen(string tenThuongHieu)
        {
            foreach (var item in thuongHieuDAO.LayDanhSachThuongHieu())
            {
                if (item.TenThuongHieu == tenThuongHieu && item.TrangThai == 1)
                {
                    return item;
                }
            }
            return null;
        }

        //  Trả về danh sách tên các thương hiệu
        public List<string> LayDanhSachTenThuongHieu()
        {
            List<string> danhSachTenThuongHieu = new List<string>();

            foreach (var item in thuongHieuDAO.LayDanhSachThuongHieu())
            {
                if (item.TrangThai == 1)
                {
                    danhSachTenThuongHieu.Add(item.TenThuongHieu);
                }
            }
            return danhSachTenThuongHieu;
        }

        public List<ThuongHieu> TimKiemThuongHieu(string keyWord)
        {
            return thuongHieuDAO.TimKiemThuongHieu(keyWord);
        }

        ThuongHieuDAO ThuongHieuDAO = new ThuongHieuDAO();
        public ThuongHieu getFromSP(String sp)
        {
            return ThuongHieuDAO.getFromSP(sp);
        }





    }
}
