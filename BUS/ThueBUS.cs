using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThueBUS
    {
        ThueDAO thueDAO = new ThueDAO();
        public List<Thue> LayToanBoThue()
        {
            return thueDAO.LayToanBoThue();
        }

        public bool ThemThongTinThue(Thue thue)
        {
            foreach (var item in thueDAO.LayToanBoThue())
            {
                if (item.TenThue == thue.TenThue && item.MucThue == thue.MucThue && item.TrangThai == thue.TrangThai)
                {
                    return false;
                }
            }
            return thueDAO.ThemThongTinThue(thue);
        }


        public bool XoaThongTinThue(int MaThue)
        {
            return thueDAO.XoaThongTinThue(MaThue);
        }

        public Thue LayThongTinThue(int mathue)
        {
            foreach (var item in thueDAO.LayToanBoThue())
            {
                if (item.MaThue == mathue)
                {
                    return item;
                }

            }
            return null;
        }

        public List<Thue> TimKiemThue(string text)
        {
            return thueDAO.TimKiemThue(text);
        }


        ThueDAO t1 = new ThueDAO();
        public ArrayList getAllList()
        {
            return t1.getAllListThue();
        }


    }
}
