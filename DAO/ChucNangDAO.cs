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
    public class ChucNangDAO : DatabaseAccess
    {

        // Lấy ra danh sách chức năng có trạng thái = 1
        public List<ChucNang> LayDanhSachChucNang()
        {

            List<ChucNang> danhSachChucNang = new List<ChucNang>();
            try
            {
                OpenConnection();
                command = new SqlCommand("Select_ChucNang", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChucNang chucNang = new ChucNang();
                    chucNang.MaChucNang = reader.GetInt32(0);
                    chucNang.TenChucNang = reader.GetString(1);
                    chucNang.TrangThai = reader.GetInt32(2);
                    danhSachChucNang.Add(chucNang);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error");
            }
            return danhSachChucNang;
        }

        // tìm kiếm chức năng
        public List<ChucNang> TimKiemChucNang(string text)
        {
            List<ChucNang> chucNang = new List<ChucNang>();
            string sql = "select * from ChucNang where concat(MaChucNang,TenChucNang) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChucNang chucnang = new ChucNang();
                chucnang.MaChucNang = reader.GetInt32(0);
                chucnang.TenChucNang = reader.GetString(1);
                chucnang.TrangThai = reader.GetInt32(2);
                chucNang.Add(chucnang);
            }
            CloseConnection();
            return chucNang;
        }

        // Thêm chức năng
        public bool ThemChucNang(ChucNang chucNang)
        {
            string sql = "insert into ChucNang values(@TenChucNang,@TrangThai)";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@TenChucNang", SqlDbType.NVarChar).Value = chucNang.TenChucNang;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = chucNang.TrangThai;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }


        // Sửa chức năng
        public bool SuaChucNang(ChucNang chucNang)
        {
            string sql = "update ChucNang set TenChucNang=@TenChucNang where MaChucNang=@MaChucNang";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = chucNang.MaChucNang;
            command.Parameters.Add("@TenChucNang", SqlDbType.NVarChar).Value = chucNang.TenChucNang;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Xóa chức năng
        public bool XoaChucNang(int maChucNang)
        {
            string sql = "update ChucNang set TrangThai=0 where MaChucNang=@MaChucNang";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = maChucNang;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }



        public string getTenChucNang(int maChucNang)
        {
            string sql = "select TenChucNang from ChucNang where MaChucNang=@MaChucNang";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = maChucNang;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                string tmp = reader.GetString(0);
                CloseConnection();
                return tmp;
            }
            CloseConnection();
            return "";
        }

        public int getMaChucNang(string tenChucNang)
        {
            string sql = "select MaChucNang from ChucNang where TenChucNang=@TenChucNang";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@TenChucNang", SqlDbType.NVarChar).Value = tenChucNang;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                int tmp = reader.GetInt32(0);
                CloseConnection();
                return tmp;
            }
            CloseConnection();
            return 0;
        }

        

        public bool KiemTraChucNang(string tenchucnang)
        {
            string sql = "select * from ChucNang where TenChucNang=@TenChucNang";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@TenChucNang", SqlDbType.NVarChar).Value = tenchucnang;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
    }
}
