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
    public class ChatLieuBUS
    {
        ChatLieuDAO chatLieuDAO = new ChatLieuDAO();

        // lấy danh sách chất liệu
        public List<ChatLieu> LayDanhSachChatLieu()
        {
            return chatLieuDAO.LayDanhSachChatLieu();
        }


        // thêm chất liệu
        public bool ThemChatLieu(ChatLieu chatLieu)
        {
            foreach (var item in chatLieuDAO.LayDanhSachChatLieu())
            {
                if (item.TenChatLieu == chatLieu.TenChatLieu)
                {
                    return false;
                }
            }
            return chatLieuDAO.ThemChatLieu(chatLieu);
        }

        // sửa chất liệu
        public bool SuaChatLieu(ChatLieu chatLieu)
        {
            foreach (var item in chatLieuDAO.LayDanhSachChatLieu())
            {
                if (item.TenChatLieu == chatLieu.TenChatLieu)
                {
                    return false;
                }
            }
            return chatLieuDAO.SuaChatLieu(chatLieu);
        }

        // xóa chất liệu
        public bool XoaChatLieu(ChatLieu chatLieu)
        {
            return chatLieuDAO.XoaChatLieu(chatLieu);
        }

        // Lấy chất liệu qua mã
        public ChatLieu LayChatLieuQuaMa(int maChatLieu)
        {
            foreach (var item in chatLieuDAO.LayDanhSachChatLieu())
            {
                if (item.MaChatLieu == maChatLieu)
                {
                    return item;
                }
            }
            return null;
        }


        // Lấy chất liệu qua tên
        public ChatLieu LayChatLieuQuaTen(string tenChatLieu)
        {
            foreach (var item in chatLieuDAO.LayDanhSachChatLieu())
            {
                if (item.TenChatLieu == tenChatLieu)
                {
                    return item;
                }
            }
            return null;
        }

        // Tìm kiếm chất liệu
        public List<ChatLieu> TimKiemChatLieu(string keyWord)
        {
            return chatLieuDAO.TimKiemChatLieu(keyWord);
        }



        //  Trả về danh sách tên các chất liệu
        public List<string> LayDanhSachTenChatLieu()
        {
            List<string> danhSachTenChatLieu = new List<string>();
            foreach (var item in chatLieuDAO.LayDanhSachChatLieu())
            {
                if (item.TrangThai == 1)
                {
                    danhSachTenChatLieu.Add(item.TenChatLieu);
                }
            }
            return danhSachTenChatLieu;
        }


        ChatLieuDAO cl = new ChatLieuDAO();
        public ChatLieu getFromSP(String sp)
        {
            return cl.getFromSP(sp);
        }

    }
}
