using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO cthd1 = new ChiTietHoaDonDAO();
        public  bool insert(ChiTietHoaDon cthd,int MaHoaDon)
        {
           return cthd1.insertCTHD(cthd,MaHoaDon);
        }

        public DataTable pushToDGV(String MaHoaDon)
        {
            return cthd1.pushCTHDFromHD(MaHoaDon);
        }
    }

}
