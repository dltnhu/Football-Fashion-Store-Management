using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        public int MaChiTietHoaDon { get; set; }
        public int MaChiTietSanPham { get; set; }
        public int MaHoaDon { get; set; }
        public float GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }

        public ChiTietHoaDon(int MaChiTietSanPham, float GiaSanPham, int SoLuong, float ThanhTien)
        {
            this.MaChiTietSanPham = MaChiTietSanPham;
            this.MaHoaDon = -1;
            this.GiaSanPham = GiaSanPham;
            this.SoLuong = SoLuong;
            this.ThanhTien = ThanhTien;
        }
    }
}
