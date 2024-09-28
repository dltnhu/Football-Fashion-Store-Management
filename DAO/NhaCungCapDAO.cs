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
    public class NhaCungCapDAO : DatabaseAccess
    {
        public List<NhaCungCap> LayToanBoNhaCungCap()
        {
            List<NhaCungCap> danhSachNhaCungCap = new List<NhaCungCap>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM NhaCungCap where TrangThai = 1" ;
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int maNhaCungCap = reader.GetInt32(0);
                    string tenNhaCungCap = reader.GetString(1);
                    string diaChi = reader.GetString(2);
                    string soDienThoai = reader.GetString(3);
                    int trangThai = reader.GetInt32(4);
                    NhaCungCap nhaCungCap = new NhaCungCap();
                    nhaCungCap.MaNhaCungCap = maNhaCungCap;
                    nhaCungCap.TenNhaCungCap = tenNhaCungCap;
                    nhaCungCap.DiaChi = diaChi;
                    nhaCungCap.SoDienThoai = soDienThoai;
                    nhaCungCap.TrangThai = trangThai;

                    danhSachNhaCungCap.Add(nhaCungCap);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachNhaCungCap;
        }

        public bool ThemThongTinNhaCungCap(NhaCungCap nhaCungCap)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO NhaCungCap VALUES(@tenNhaCungCap, @diaChi, @soDienThoai, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@tenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNhaCungCap;
            command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
            command.Parameters.Add("@soDienThoai", SqlDbType.NVarChar).Value = nhaCungCap.SoDienThoai;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = nhaCungCap.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        public bool SuaThongTinNhaCungCap(NhaCungCap nhaCungCap)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE NhaCungCap SET TenNhaCungCap = @tenNhaCungCap, DiaChi = @diaChi, SoDienThoai = @soDienThoai, TrangThai = @trangThai WHERE MaNhaCungCap = @maNhaCungCap";
                command.Connection = conn;
                command.Parameters.Add("@tenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNhaCungCap;
                command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
                command.Parameters.Add("@soDienThoai", SqlDbType.NVarChar).Value = nhaCungCap.SoDienThoai;
                command.Parameters.Add("@trangThai", SqlDbType.Int).Value = nhaCungCap.TrangThai;
                command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = nhaCungCap.MaNhaCungCap;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ketQua > 0;
        }

        public bool XoaNhaCungCap(int maNhaCungCap)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE NhaCungCap SET TrangThai = 0 WHERE MaNhaCungCap = @maNhaCungCap";
            command.Connection = conn;
            command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = maNhaCungCap;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }

        // Tìm kiếm màu sắc
        public List<NhaCungCap> TimKiemNhaCungCap(string text)
        {
            List<NhaCungCap> danhSachNhaCungCap = new List<NhaCungCap>();
            OpenConnection();
            string sql = "select * from NhaCungCap where concat(TenNhaCungCap,DiaChi, SoDienThoai) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhaCungCap nhaCungCap = new NhaCungCap();
                nhaCungCap.MaNhaCungCap = reader.GetInt32(0);
                nhaCungCap.TenNhaCungCap = reader.GetString(1);
                nhaCungCap.DiaChi = reader.GetString(2);
                nhaCungCap.SoDienThoai = reader.GetString(3);
                nhaCungCap.TrangThai = reader.GetInt32(4);
                danhSachNhaCungCap.Add(nhaCungCap);
            }
            CloseConnection();
            return danhSachNhaCungCap;
        }






    }
}
