using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAO
{
    public class ChiTietQuyenDAO : DatabaseAccess
    {

        // Lấy danh sách chi tiết quyền
        public List<ChiTietQuyen> LayDanhSachChiTietQuyen()
        {
            List<ChiTietQuyen> danhSachChiTietQuyen = new List<ChiTietQuyen>();
            try
            {
                OpenConnection();
                command = new SqlCommand("Select_ChiTietQuyen", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietQuyen chiTietQuyen = new ChiTietQuyen();
                    chiTietQuyen.MaChiTietQuyen = reader.GetInt32(0);
                    chiTietQuyen.MaNhomQuyen = reader.GetInt32(1);
                    chiTietQuyen.MaChucNang = reader.GetInt32(2);
                    chiTietQuyen.HanhDong = reader.GetString(3);
                    danhSachChiTietQuyen.Add(chiTietQuyen);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietQuyen;
        }

        // Tìm kiếm chi tiết quyền
        public List<ChiTietQuyen> TimKiemChiTietQuyen(string text)
        {
            List<ChiTietQuyen> dt = new List<ChiTietQuyen>();
            string sql = "select ChiTietQuyen.MaChiTietQuyen,ChiTietQuyen.MaNhomQuyen,ChiTietQuyen.MaChucNang,ChiTietQuyen.HanhDong from ChiTietQuyen join ChucNang on " +
                "ChiTietQuyen.MaChucNang=ChucNang.MaChucNang join NhomQuyen on ChiTietQuyen.MaNhomQuyen=NhomQuyen.MaNhomQuyen " +
                "where concat(ChiTietQuyen.MaNhomQuyen,ChiTietQuyen.MaChucNang,ChiTietQuyen.HanhDong,ChucNang.TenChucNang,NhomQuyen.TenNhomQuyen) " +
                "like N'%" + text + "%' and ChucNang.TrangThai=1 and NhomQuyen.TrangThai=1";
            OpenConnection();
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChiTietQuyen chiTietQuyen = new ChiTietQuyen();
                chiTietQuyen.MaChiTietQuyen = reader.GetInt32(0);
                chiTietQuyen.MaNhomQuyen = reader.GetInt32(1);
                chiTietQuyen.MaChucNang = reader.GetInt32(2);
                chiTietQuyen.HanhDong = reader.GetString(3);
                dt.Add(chiTietQuyen);
            }
            CloseConnection();
            return dt;
        }

        // Thêm chi tiết quyền
        public bool ThemChiTietQuyen(ChiTietQuyen chiTietQuyen)
        {
            OpenConnection();
            string sql = "insert into ChiTietQuyen values(@MaNhomQuyen,@MaChucNang,@HanhDong)";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = chiTietQuyen.MaNhomQuyen;
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = chiTietQuyen.MaChucNang;
            command.Parameters.Add("@HanhDong", SqlDbType.NVarChar).Value = chiTietQuyen.HanhDong;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Xóa chi tiết quyền
        public bool XoaChiTietQuyen(int maChiTietQuyen)
        {
            OpenConnection();
            string sql = "delete ChiTietQuyen where MaChiTietQuyen=@MaChiTietQuyen";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaChiTietQuyen", SqlDbType.Int).Value = maChiTietQuyen;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Sửa chi tiết quyền
        public bool SuaChiTietQuyen(ChiTietQuyen chiTietQuyen)
        {
            OpenConnection();
            string sql = "update ChiTietQuyen set MaNhomQuyen=@MaNhomQuyen, MaChucNang = @MaChucNang, HanhDong = @HanhDong where MaChiTietQuyen=@MaChiTietQuyen";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = chiTietQuyen.MaNhomQuyen;
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = chiTietQuyen.MaChucNang;
            command.Parameters.Add("@HanhDong", SqlDbType.NVarChar).Value = chiTietQuyen.HanhDong;
            command.Parameters.Add("@MaChiTietQuyen", SqlDbType.Int).Value = chiTietQuyen.MaChiTietQuyen;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public List<int> LayDanhSachChucNang(int maNhomQuyen)
        {

            List<int> dt = new List<int>();
            string sql = "SELECT DISTINCT MaChucNang  FROM ChiTietQuyen WHERE MaNhomQuyen = @MaNhomQuyen";
            OpenConnection();
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = maNhomQuyen;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maChucNang = reader.GetInt32(0);
                dt.Add(maChucNang);
            }
            CloseConnection();
            return dt;
        }

        

        /*
        public string ChucNang(int MaNhomQuyen)
        {
            string sql = "select distinct MaChucNang from ChiTietQuyen where MaNhomQuyen=@MaNhomQuyen";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = MaNhomQuyen;
            OpenConnection();
            string s = "";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                s += reader.GetInt32(0) + ",";
            }
            if (s == "")
            {
                CloseConnection();
                return "";
            }
            else
            {
                CloseConnection();
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }
        public string HanhDong(int MaNhomQuyen, int MaChucNang)
        {
            string sql = "select HanhDong from ChiTietQuyen where MaNhomQuyen=@MaNhomQuyen and MaChucNang=@MaChucNang";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = MaNhomQuyen;
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = MaChucNang;
            reader = command.ExecuteReader();
            string s = "";
            while (reader.Read())
            {
                s += reader.GetString(0) + ",";
            }
            s = s.Substring(0, s.Length - 1);
            CloseConnection();
            return s;
        }
       
        
        */
    }
}
