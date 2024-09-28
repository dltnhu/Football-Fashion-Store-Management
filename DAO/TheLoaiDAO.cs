using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiDAO : DatabaseAccess
    {
        // Lấy danh sách thể loại
        public List<TheLoai> LayDanhSachTheLoai()
        {
            List<TheLoai> danhSachTheLoai = new List<TheLoai>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Select_TheLoai";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int maTheLoai = reader.GetInt32(0);
                    string tenTheLoai = reader.GetString(1);
                    int trangThai = reader.GetInt32(2);
                    TheLoai theLoai = new TheLoai();
                    theLoai.MaTheLoai = maTheLoai;
                    theLoai.TenTheLoai = tenTheLoai;
                    theLoai.TrangThai = trangThai;

                    danhSachTheLoai.Add(theLoai);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachTheLoai;
        }

        // Thêm thể loại 
        public bool ThemTheLoai(TheLoai theLoai)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO TheLoai VALUES(@tenTheLoai, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@tenTheLoai", SqlDbType.NVarChar).Value = theLoai.TenTheLoai;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = theLoai.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Sửa thể loại
        public bool SuaTheLoai(TheLoai theLoai)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE TheLoai SET TenTheLoai = @tenTheLoai WHERE MaTheLoai = @maTheLoai";
                command.Connection = conn;
                command.Parameters.Add("@tenTheLoai", SqlDbType.NVarChar).Value = theLoai.TenTheLoai;
                command.Parameters.Add("@maTheLoai", SqlDbType.Int).Value = theLoai.MaTheLoai;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ketQua > 0;
        }

        // Xóa thể loại
        public Boolean XoaTheLoai(int maTheLoai)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE TheLoai SET TrangThai = 0 WHERE MaTheLoai = @maTheLoai";
            command.Connection = conn;
            command.Parameters.Add("@maTheLoai", SqlDbType.Int).Value = maTheLoai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }


        // Tìm kiếm thể loại
        public List<TheLoai> TimKiemTheLoai(string text)
        {
            List<TheLoai> danhSachTheLoaiTimKiem = new List<TheLoai>();
            OpenConnection();
            string sql = "select * from TheLoai where concat(MaTheLoai,TenTheLoai) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                TheLoai theloai = new TheLoai();
                theloai.MaTheLoai = reader.GetInt32(0);
                theloai.TenTheLoai = reader.GetString(1);
                theloai.TrangThai = reader.GetInt32(2);
                danhSachTheLoaiTimKiem.Add(theloai);
            }
            CloseConnection();
            return danhSachTheLoaiTimKiem;
        }


        public TheLoai getFromSP(String sp)
        {
            TheLoai theLoai = new TheLoai();
            SqlCommand cmd;
            String query = "select tl.* from SanPham as sp, TheLoai as tl\r\nwhere sp.MaTheLoai  = tl.MaTheLoai\r\nand sp.MaSanPham = " + sp;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    theLoai.MaTheLoai = reader.GetInt32(0);
                    theLoai.TenTheLoai = reader.GetString(1);

                }
            }
            CloseConnection();
            return theLoai;
        }
    }
}
