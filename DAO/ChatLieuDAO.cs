using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChatLieuDAO : DatabaseAccess
    {
        public List<ChatLieu> LayDanhSachChatLieu()
        {

            // lấy danh sách chất liệu
            List<ChatLieu> danhSachChatLieu = new List<ChatLieu>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Select_ChatLieu";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int maChatLieu = reader.GetInt32(0);
                    string tenChatLieu = reader.GetString(1);
                    int trangThai = reader.GetInt32(2);
                    ChatLieu chatLieu = new ChatLieu();
                    chatLieu.MaChatLieu = maChatLieu;
                    chatLieu.TenChatLieu = tenChatLieu;
                    chatLieu.TrangThai = trangThai;

                    danhSachChatLieu.Add(chatLieu);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachChatLieu;
        }

        // thêm chất liệu
        public bool ThemChatLieu(ChatLieu chatLieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO ChatLieu VALUES(@tenChatLieu, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@tenChatLieu", SqlDbType.NVarChar).Value = chatLieu.TenChatLieu;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = chatLieu.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Sửa chất liệu
        public bool SuaChatLieu(ChatLieu chatLieu)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ChatLieu SET TenChatLieu = @tenChatLieu, TrangThai = @trangThai WHERE MaChatLieu = @maChatLieu";
                command.Connection = conn;
                command.Parameters.Add("@tenChatLieu", SqlDbType.NVarChar).Value = chatLieu.TenChatLieu;
                command.Parameters.Add("@trangThai", SqlDbType.Int).Value = chatLieu.TrangThai;
                command.Parameters.Add("@maChatLieu", SqlDbType.Int).Value = chatLieu.MaChatLieu;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ketQua > 0;
        }

        // Xóa chất liệu
        public bool XoaChatLieu(ChatLieu chatLieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE ChatLieu SET TrangThai = 0 WHERE MaChatLieu = @maChatLieu";
            command.Connection = conn;
            command.Parameters.Add("@maChatLieu", SqlDbType.Int).Value = chatLieu.MaChatLieu;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }

        // Tìm kiếm chất liệu
        public List<ChatLieu> TimKiemChatLieu(string text)
        {
            List<ChatLieu> danhSachChatLieuTimKiem = new List<ChatLieu>();
            OpenConnection();
            string sql = "select * from ChatLieu where concat(MaChatLieu,TenChatLieu) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChatLieu chatLieu = new ChatLieu();
                chatLieu.MaChatLieu = reader.GetInt32(0);
                chatLieu.TenChatLieu = reader.GetString(1);
                chatLieu.TrangThai = reader.GetInt32(2);
                danhSachChatLieuTimKiem.Add(chatLieu);
            }
            CloseConnection();
            return danhSachChatLieuTimKiem;
        }

        public ChatLieu getFromSP(String SP)
        {

            ChatLieu chatlieu = new ChatLieu();
            String query = "select cl.* from SanPham as sp, ChatLieu as cl\r\nwhere sp.MaChatLieu  = cl.MaChatLieu\r\nand sp.MaSanPham = " + SP;
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    chatlieu.MaChatLieu = reader.GetInt32(0);
                    chatlieu.TenChatLieu = reader.GetString(1);
                }
            }
            CloseConnection();
            return chatlieu;
        }



    }
}
