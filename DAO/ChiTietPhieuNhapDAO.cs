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
    public class ChiTietPhieuNhapDAO : DatabaseAccess
    {
        public List<ChiTietPhieuNhap> LayToanBoChiTietPhieuNhap()
        {
            List<ChiTietPhieuNhap> danhSachChiTietPhieuNhap = new List<ChiTietPhieuNhap>();
            try
            {
                string sql = "select * from ChiTietPhieuNhap";
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                    chiTietPhieuNhap.MaChiTietPhieuNhap = reader.GetInt32(0);
                    chiTietPhieuNhap.MaPhieuNhap = reader.GetInt32(1);
                    chiTietPhieuNhap.MaChiTietSanPham = reader.GetInt32(2);
                    chiTietPhieuNhap.SoLuongNhap = reader.GetInt32(3);
                    chiTietPhieuNhap.DonVi = reader.GetString(4);
                    double tiennhap = reader.GetDouble(5);
                    chiTietPhieuNhap.TienNhap = Convert.ToSingle(tiennhap);
                    double thanhtien = reader.GetDouble(6);
                    chiTietPhieuNhap.ThanhTien = Convert.ToSingle(thanhtien);
                    danhSachChiTietPhieuNhap.Add(chiTietPhieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietPhieuNhap;
        }
        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string sql = "insert into ChiTietPhieuNhap values(@MaPhieuNhap,@MaChiTietSanPham,@SoLuongNhap,@donvi,@TienNhap,@ThanhTien)";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = chiTietPhieuNhap.MaChiTietSanPham;
            command.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = chiTietPhieuNhap.SoLuongNhap;
            command.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = chiTietPhieuNhap.DonVi;
            command.Parameters.Add("@TienNhap", SqlDbType.Float).Value = chiTietPhieuNhap.TienNhap;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = chiTietPhieuNhap.ThanhTien;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool XoaChiTietPhieuNhap(int maChiTietPhieuNhap)
        {
            string sql = "UPDATE ChiTietPhieuNhap SET TrangThai = 0 WHERE MaChiTietPhieuNhap = @maChiTietPhieuNhap";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maChiTietPhieuNhap", SqlDbType.Int).Value = maChiTietPhieuNhap;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool SuaChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string sql = "UPDATE ChiTietPhieuNhap SET MaPhieuNhap = @maPhieuNhap, MaChiTietSanPham = @maChiTietSanPham, SoLuongNhap = @soLuongNhap, DonVi = @donVi, TienNhap = @tienNhap, ThanhTien = @thanhTien WHERE MaChiTietPhieuNhap = @maChiTietPhieuNhap";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = chiTietPhieuNhap.MaChiTietSanPham;
            command.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = chiTietPhieuNhap.SoLuongNhap;
            command.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = chiTietPhieuNhap.DonVi;
            command.Parameters.Add("@TienNhap", SqlDbType.Float).Value = chiTietPhieuNhap.TienNhap;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = chiTietPhieuNhap.ThanhTien;
            command.Parameters.Add("@maChiTietPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaChiTietPhieuNhap;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }


        public List<ChiTietPhieuNhap> TimKiemChiTietPhieuNhap(string text)
        {
            OpenConnection();
            List<ChiTietPhieuNhap> danhSachChiTietPhieuNhap = new List<ChiTietPhieuNhap>();
            string sql = "select * from ChiTietPhieuNhap where like '%" + text + "%'";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                chiTietPhieuNhap.MaPhieuNhap = reader.GetInt32(0);
                chiTietPhieuNhap.MaChiTietSanPham = reader.GetInt32(1);
                chiTietPhieuNhap.SoLuongNhap = reader.GetInt32(2);
                chiTietPhieuNhap.DonVi = reader.GetString(3);
                double tiennhap = reader.GetDouble(4);
                chiTietPhieuNhap.TienNhap = Convert.ToSingle(tiennhap);
                double thanhtien = reader.GetDouble(5);
                chiTietPhieuNhap.ThanhTien = Convert.ToSingle(thanhtien);
                danhSachChiTietPhieuNhap.Add(chiTietPhieuNhap);
            }
            CloseConnection();
            return danhSachChiTietPhieuNhap;
        }
    }
}
