using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhuyenMaiDAO : DatabaseAccess
    {
        // lấy danh sách khuyến mãi

        public List<KhuyenMai> getAllListKhuyenMai()
        {
            List<KhuyenMai> danhSachKhuyenMai = new List<KhuyenMai>();
            String query = "SELECT * FROM KhuyenMai ";
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    KhuyenMai km = new KhuyenMai();
                    km.MaKhuyenMai = reader.GetInt32(0);
                    km.MucKhuyenMai = Convert.ToSingle(reader.GetDouble(1));
                    km.DieuKien = reader.GetString(2);
                    km.ThoiGianBatDau = reader.GetDateTime(3);
                    km.ThoiGianKetThuc = reader.GetDateTime(4);
                    km.TrangThai = reader.GetInt32(5);
                    danhSachKhuyenMai.Add(km);
                }
            }
            CloseConnection();
            return danhSachKhuyenMai;
        }


        // Thêm khuyến mãi
        public bool ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO KhuyenMai VALUES(@mucKhuyenMai, @dieuKien, @thoiGianBatDau, @thoiGianKetThuc, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@mucKhuyenMai", SqlDbType.Float).Value = khuyenMai.MucKhuyenMai;
            command.Parameters.Add("@dieuKien", SqlDbType.NVarChar).Value = khuyenMai.DieuKien;
            command.Parameters.Add("@thoiGianBatDau", SqlDbType.DateTime).Value = khuyenMai.ThoiGianBatDau;
            command.Parameters.Add("@thoiGianKetThuc", SqlDbType.DateTime).Value = khuyenMai.ThoiGianKetThuc;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = khuyenMai.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Xóa khuyến mãi
        public bool XoaKhuyenMai(KhuyenMai khuyenMai)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE KhuyenMai SET TrangThai = 0 WHERE MaKhuyenMai = @maKhuyenMai";
            command.Connection = conn;
            command.Parameters.Add("@maKhuyenMai", SqlDbType.Int).Value = khuyenMai.MaKhuyenMai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }

        // Sửa khuyến mãi
        public bool SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE KhuyenMai SET MucKhuyenMai = @mucKhuyenMai, DieuKien = @dieuKien, ThoiGianBatDau = @thoiGianBatDau, ThoiGianKetThuc = @thoiGianKetThuc WHERE MaKhuyenMai = @maKhuyenMai";
            command.Connection = conn;
            command.Parameters.Add("@mucKhuyenMai", SqlDbType.Float).Value = khuyenMai.MucKhuyenMai;
            command.Parameters.Add("@dieuKien", SqlDbType.NVarChar).Value = khuyenMai.DieuKien;
            command.Parameters.Add("@thoiGianBatDau", SqlDbType.DateTime).Value = khuyenMai.ThoiGianBatDau;
            command.Parameters.Add("@thoiGianKetThuc", SqlDbType.DateTime).Value = khuyenMai.ThoiGianKetThuc;
            command.Parameters.Add("@maKhuyenMai", SqlDbType.Int).Value = khuyenMai.MaKhuyenMai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        

        public ArrayList getAllListKhuyenMai1()
        {
            ArrayList list = new ArrayList();
            String query = "SELECT * FROM KhuyenMai  WHERE TrangThai = 1\r\nand getDate() < ThoiGianKetThuc\r\nand getDate() >ThoiGianBatDau";
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    KhuyenMai km = new KhuyenMai();
                    km.MaKhuyenMai = reader.GetInt32(0);
                    km.MucKhuyenMai = Convert.ToSingle(reader.GetDouble(1));
                    km.DieuKien = reader.GetString(2);
                    
                    list.Add(km);
                }
            }
            CloseConnection();
            return list;
        }


        public List<KhuyenMai> TimKiemKhuyenMai(string text)
        {
            List<KhuyenMai> khuyenMai = new List<KhuyenMai>();
            string sql = "select * from KhuyenMai where concat(MucKhuyenMai,DieuKien) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                KhuyenMai km = new KhuyenMai();
                km.MaKhuyenMai = reader.GetInt32(0);
                km.MucKhuyenMai = Convert.ToSingle(reader.GetDouble(1));
                km.DieuKien = reader.GetString(2);
                km.ThoiGianBatDau = reader.GetDateTime(3);
                km.ThoiGianKetThuc = reader.GetDateTime(4);
                km.TrangThai = reader.GetInt32(5);
                khuyenMai.Add(km);
            }
            CloseConnection();
            return khuyenMai;
        }

    }
}
