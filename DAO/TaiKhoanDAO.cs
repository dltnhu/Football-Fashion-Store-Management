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
    public class TaiKhoanDAO : DatabaseAccess
    {
        // Lấy danh sách tài khoản  
        public List<TaiKhoan> LayDanhSachTaiKhoan()
        {
            List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();
            try
            {
                OpenConnection();
                danhSachTaiKhoan = new List<TaiKhoan>();
                command = new SqlCommand("Select_TaiKhoan", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TaiKhoan taikhoan = new TaiKhoan();
                    taikhoan.MaTaiKhoan = reader.GetInt32(0);
                    taikhoan.MaNhomQuyen = reader.GetInt32(1);
                    taikhoan.TenTaikhoan = reader.GetString(2);
                    taikhoan.MatKhau = reader.GetString(3);
                    taikhoan.TrangThai = reader.GetInt32(4);
                    danhSachTaiKhoan.Add(taikhoan);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return danhSachTaiKhoan;
        }

        // Thêm tài khoản
        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            OpenConnection();
            string sql = "insert into TaiKhoan values(@MaTaiKhoan,@MaNhomQuyen,@TenTaiKhoan,@MatKhau,@TrangThai)";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = taiKhoan.MaTaiKhoan;
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = taiKhoan.MaNhomQuyen;
            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar).Value = taiKhoan.TenTaikhoan;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = taiKhoan.MatKhau;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = taiKhoan.TrangThai;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Xóa tài khoản
        public bool XoaTaiKhoan(int MaTaiKhoan)
        {
            OpenConnection();
            string sql = "update TaiKhoan set TrangThai=0 where MaTaiKhoan=@MaTaiKhoan";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = MaTaiKhoan;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Sửa tài khoản
        public bool SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            OpenConnection();
            string sql = "update TaiKhoan set TenTaiKhoan=@TenTaiKhoan, MaNhomQuyen=@MaQuyen, MatKhau=@MatKhau where MaTaiKhoan=@MaTaiKhoan";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = taiKhoan.MaTaiKhoan;
            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar).Value = taiKhoan.TenTaikhoan;
            command.Parameters.Add("@MaQuyen", SqlDbType.Int).Value = taiKhoan.MaNhomQuyen;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = taiKhoan.MatKhau;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Đăng nhập
        public bool DangNhap(string taikhoan, string matkhau)
        {
            OpenConnection();
            string sql = "select * from TaiKhoan where TenTaiKhoan=@TaiKhoan and MatKhau=@MatKhau and TRANGTHAI = 1";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = taikhoan;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = matkhau;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }

        // Tìm kiếm tài khoản
        public List<TaiKhoan> TimKiemTaiKhoan(string text)
        {
            List<TaiKhoan> arraytaikhoan = new List<TaiKhoan>();
            string sql = "select * from TaiKhoan where concat(MaTaiKhoan, MaNhomQuyen,TenTaiKhoan,MatKhau)COLLATE Latin1_General_CI_AI like N'%" + text + "%' and TrangThai = 1";
            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                TaiKhoan taikhoan = new TaiKhoan();
                taikhoan.MaTaiKhoan = reader.GetInt32(0);
                taikhoan.MaNhomQuyen = reader.GetInt32(1);
                taikhoan.TenTaikhoan = reader.GetString(2);
                taikhoan.MatKhau = reader.GetString(3);
                taikhoan.TrangThai = reader.GetInt32(4);
                arraytaikhoan.Add(taikhoan);
            }
            CloseConnection();
            return arraytaikhoan;

        }


        /*
        
       
       
        public int getMaTaiKhoan(string taikhoan, string matkhau)
        {
            string sql = "select MaTaiKhoan from TaiKhoan where TenTaiKhoan=@TaiKhoan and MatKhau=@MatKhau";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = taikhoan;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = matkhau;
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
        public int getMaNhomQuyen(int MaTaiKhoan)
        {
            string sql = "select MaNhomQuyen from TaiKhoan where MaTaiKhoan=@MaTaiKhoan";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = MaTaiKhoan;
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
        
        public bool KiemTraTaiKhoan(int mataikhoan)
        {
            string sql = "select * from TaiKhoan where MaTaiKhoan=@MaTaiKhoan";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = mataikhoan;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }*/
    }
}
