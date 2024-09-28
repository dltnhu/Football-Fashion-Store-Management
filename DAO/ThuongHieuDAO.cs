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
    public class ThuongHieuDAO : DatabaseAccess
    {
        // Lấy danh sách thương hiệu
        public List<ThuongHieu> LayDanhSachThuongHieu()
        {
            List<ThuongHieu> danhSachThuongHieu = new List<ThuongHieu>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Select_ThuongHieu";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int maThuongHieu = reader.GetInt32(0);
                    string tenThuongHieu = reader.GetString(1);
                    int trangThai = reader.GetInt32(2);
                    ThuongHieu thuongHieu = new ThuongHieu();
                    thuongHieu.MaThuongHieu = maThuongHieu;
                    thuongHieu.TenThuongHieu = tenThuongHieu;
                    thuongHieu.TrangThai = trangThai;
                    danhSachThuongHieu.Add(thuongHieu);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachThuongHieu;
        }

        // Thêm thương hiệu

        public bool ThemThuongHieu(ThuongHieu thuongHieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO ThuongHieu VALUES(@tenThuongHieu, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@tenThuongHieu", SqlDbType.NVarChar).Value = thuongHieu.TenThuongHieu;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = thuongHieu.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        //Sửa thương hiệu
        public bool SuaThuongHieu(ThuongHieu thuongHieu)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ThuongHieu SET TenThuongHieu = @tenThuongHieu, TrangThai = @trangThai WHERE MaThuongHieu = @maThuongHieu";
                command.Connection = conn;
                command.Parameters.Add("@tenThuongHieu", SqlDbType.NVarChar).Value = thuongHieu.TenThuongHieu;
                command.Parameters.Add("@trangThai", SqlDbType.Int).Value = thuongHieu.TrangThai;
                command.Parameters.Add("@maThuongHieu", SqlDbType.Int).Value = thuongHieu.MaThuongHieu;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ketQua > 0;
        }

        // Xóa thương hiệu
        public bool XoaThuongHieu(int maThuongHieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE ThuongHieu SET TrangThai = 0 WHERE MaThuongHieu = @maThuongHieu";
            command.Connection = conn;
            command.Parameters.Add("@maThuongHieu", SqlDbType.Int).Value = maThuongHieu;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }

        // Tìm kiếm thương hiệu
        public List<ThuongHieu> TimKiemThuongHieu(string text)
        {
            List<ThuongHieu> danhSachThuongHieuTimKiem = new List<ThuongHieu>();
            OpenConnection();
            string sql = "select * from ThuongHieu where concat(MaThuongHieu,TenThuongHieu) COLLATE Latin1_General_CI_AI like N'%" + text + "%'";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ThuongHieu thuongHieu = new ThuongHieu();
                thuongHieu.MaThuongHieu = reader.GetInt32(0);
                thuongHieu.TenThuongHieu = reader.GetString(1);
                thuongHieu.TrangThai = reader.GetInt32(2);
                danhSachThuongHieuTimKiem.Add(thuongHieu);
            }
            CloseConnection();
            return danhSachThuongHieuTimKiem;
        }

        public ThuongHieu getFromSP(String sp)
        {
            ThuongHieu th = new ThuongHieu();
            SqlCommand cmd;
            String query = "select th.* from SanPham as sp, ThuongHieu as th\r\nwhere sp.MaThuongHieu  = th.MaThuongHieu\r\nand sp.MaSanPham = " + sp;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    th.MaThuongHieu = reader.GetInt32(0);
                    th.TenThuongHieu = reader.GetString(1);

                }
            }
            CloseConnection();
            return th;
        }



    }
}

