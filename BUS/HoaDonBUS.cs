using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hd1 = new HoaDonDAO();
        public  bool insert(HoaDon hd)
        {
            return hd1.insert(hd);
        }

        public  ArrayList getAllList()
        {
            return hd1.getAllList();
        }    

        public DataTable push()
        {
            return hd1.getAllHoaDon();
        }
        public DataTable TimKiem(String text)
        {

            return hd1.TimKiem(text);
        }

        public ArrayList DanhSachHoaDonTrongKhoang(String DateStart, String DateEnd)
        {

            return hd1.DanhSachHoaDonTrongKhoang(DateStart, DateEnd);
        }


        public HoaDon LayHoaDonTuMa(String text)
        {
            return hd1.LayHoaDonTuMa(text);
        }


    }

}
