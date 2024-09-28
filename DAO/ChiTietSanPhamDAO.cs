using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DAO
{
    public class ChiTietSanPhamDAO : DatabaseAccess
    {
        public List<ChiTietSanPham> LayToanBoChiTietSanPham()
        {
            List<ChiTietSanPham> danhSachChiTietSanPham = new List<ChiTietSanPham>();
            try
            {
                OpenConnection();
                string sql = "Select * from ChiTietSanPham";
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                    chiTietSanPham.MaChiTietSanPham = reader.GetInt32(0);
                    chiTietSanPham.MaSanPham = reader.GetInt32(1);
                    chiTietSanPham.MaMauSac = reader.GetInt32(2);
                    chiTietSanPham.MaKichCo = reader.GetInt32(3);
                    chiTietSanPham.HinhAnh = (byte[])reader["HinhAnh"];
                    chiTietSanPham.SoLuongNhap = reader.GetInt32(5);
                    chiTietSanPham.SoLuongTon = reader.GetInt32(6);
                    chiTietSanPham.TrangThai = reader.GetInt32(7);
                    danhSachChiTietSanPham.Add(chiTietSanPham);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietSanPham;
        }

        public bool ThemChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            OpenConnection();
            string sql = "insert into ChiTietSanPham values(@MaSanPham,@MaMauSac,@MaKichCo,@HinhAnh,@SoLuongNhap,@SoLuongTon, @TrangThai)";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = chiTietSanPham.MaSanPham;
            command.Parameters.Add("@MaMauSac", SqlDbType.Int).Value = chiTietSanPham.MaMauSac;
            command.Parameters.Add("@MaKichCo", SqlDbType.Int).Value = chiTietSanPham.MaKichCo;
            command.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = chiTietSanPham.HinhAnh;
            command.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = chiTietSanPham.SoLuongNhap;
            command.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = chiTietSanPham.SoLuongTon;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = chiTietSanPham.TrangThai;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;

        }

        public bool SuaChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            OpenConnection();
            string sql = "UPDATE ChiTietSanPham SET MaMauSac = @maMauSac, MaKichCo = @maKichCo, HinhAnh = @hinhAnh WHERE MaChiTietSanPham = @maChiTietSanPham";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maMauSac", SqlDbType.Int).Value = chiTietSanPham.MaMauSac;
            command.Parameters.Add("@maKichCo", SqlDbType.Int).Value = chiTietSanPham.MaKichCo;
            command.Parameters.Add("@hinhAnh", SqlDbType.Image).Value = chiTietSanPham.HinhAnh;
            command.Parameters.Add("@maChiTietSanPham", SqlDbType.Int).Value = chiTietSanPham.MaChiTietSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool XoaChiTietSanPham(int maChiTietSanPham)
        {
            string sql = "UPDATE ChiTietSanPham SET TrangThai = 0 WHERE MaChiTietSanPham = @maChiTietSanPham";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maChiTietSanPham", SqlDbType.Int).Value = maChiTietSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }


        public List<ChiTietSanPham> TimKiem(string text)
        {
            OpenConnection();
            List<ChiTietSanPham> danhSachChiTietSanPham = new List<ChiTietSanPham>();
            string sql = "select * from ChiTietSanPham where like '%" + text + "%'";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                chiTietSanPham.MaChiTietSanPham = reader.GetInt32(0);
                chiTietSanPham.MaSanPham = reader.GetInt32(1);
                chiTietSanPham.MaMauSac = reader.GetInt32(2);
                chiTietSanPham.MaKichCo = reader.GetInt32(3);
                chiTietSanPham.HinhAnh = (byte[])reader["HinhAnh"];
                chiTietSanPham.SoLuongNhap = reader.GetInt32(5);
                chiTietSanPham.SoLuongTon = reader.GetInt32(7);
                danhSachChiTietSanPham.Add(chiTietSanPham);
            }
            CloseConnection();
            return danhSachChiTietSanPham;
        }

        // cập nhật số lượng chi tiết sản phẩm
        public bool capNhatSoLuong(int maChiTietSanPham, int soLuongNhap, int soLuongTon)
        {
            string sql = "UPDATE ChiTietSanPham SET SoLuongNhap = @soLuongNhap, SoLuongTon = @soLuongTon  WHERE MaChiTietSanPham = @maChiTietSanPham";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@soLuongNhap", SqlDbType.Int).Value = soLuongNhap;
            command.Parameters.Add("@soLuongTon", SqlDbType.Int).Value = soLuongTon;
            command.Parameters.Add("@maChiTietSanPham", SqlDbType.Int).Value = maChiTietSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }






        public string getMaCTSP(string maSP, string maMau, string maKichCo)
        {
            string maCTSP = "";
            SqlCommand cmd;
            String query = " SELECT ctsp.MA_CHI_TIET_SAN_PHAM FROM DBO.CHI_TIET_SAN_PHAM as ctsp,DBO.SAN_PHAM as sp,DBO.mausac as ms,DBO.kichco as kc" +
                "\n where ctsp.MA_SAN_PHAM = sp.MA_SAN_PHAM" +
                "\n and ctsp.MA_KICH_CO = kc.makichco" +
                "\n and ctsp.MA_MAU_SAC = ms.mamau" +
                "\nand ms.mamau = N'" + maMau + "'" +
                "\nand kc.makichco = N'" + maKichCo + "'" +
                "\n and sp.MA_SAN_PHAM = N'" + maSP + "'";
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    maCTSP += reader.GetString(0);
                }
            }
            OpenConnection();
            return maCTSP;


        }
        public int getSoLuongTonCTSP(string maSP, string maMau, string maKichCo)
        {
            int soLuongTon = 0;
            SqlCommand cmd;
            String query = " SELECT ctsp.SO_LUON_TON FROM DBO.CHI_TIET_SAN_PHAM as ctsp,DBO.SAN_PHAM as sp,DBO.mausac as ms,DBO.kichco as kc" +
                "\n where ctsp.MA_SAN_PHAM = sp.MA_SAN_PHAM" +
                "\n and ctsp.MA_KICH_CO = kc.makichco" +
                "\n and ctsp.MA_MAU_SAC = ms.mamau" +
                "\nand ms.mamau = N'" + maMau + "'" +
                "\nand kc.makichco = N'" + maKichCo + "'" +
                "\n and sp.MA_SAN_PHAM = N'" + maSP + "'";
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    soLuongTon = reader.GetInt32(0);
                }
            }
            CloseConnection();
            return soLuongTon;


        }

        public bool updateSoLuong(int slBan, String ctsp)
        {
            try
            {
                SqlCommand cmd;
                int soLuongTon = getSoLuongTonCTSPfromMa(ctsp);
                int updatedSoLuongTon = soLuongTon - slBan;
                String query = "update DBO.ChiTietSanPham" +
                    "\r\nset  SoLuongTon= " + updatedSoLuongTon +
                    " \r\nwhere MaChiTietSanPham = " + ctsp;
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }



        }

        public int getSoLuongTonCTSPfromMa(String maCTSP)
        {
            int soLuongTon = 0;
            SqlCommand cmd;
            String query = "SELECT ctsp.SoLuongTon FROM DBO.ChiTietSanPham as ctsp" +
                    "\r\nwhere ctsp.MaChiTietSanPham= " + maCTSP;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    soLuongTon = reader.GetInt32(0);
                }
            }
            CloseConnection();
            return soLuongTon;


        }


        public int getSoLuongBanCTSPfromMa(String maCTSP)
        {
            int SoLuongBan = 0;
            SqlCommand cmd;
            String query = "SELECT ctsp.SoLuongBan FROM DBO.ChiTietSanPham as ctsp" +
                    "\r\nwhere ctsp.MaChiTietSanPham= " + maCTSP;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    SoLuongBan = reader.GetInt32(0);
                }
            }
            CloseConnection();
            return SoLuongBan;


        }









        public ArrayList getAllListCTSP()
        {
            ArrayList list = new ArrayList();

            SqlCommand cmd;
            String query = "select ctsp.MaChiTietSanPham" +
                "\r\nfrom   SanPham as sp, ChiTietSanPham as ctsp, MauSac as ms, KichCo as kc " +
                "\r\nwhere sp.TrangThai =1  " +
                "\r\nand sp.MaSanPham = ctsp.MaSanPham" +
                "\r\nand ms.MaMauSac = ctsp.MaMauSac" +
                "\r\nand kc.MaKichCo =ctsp.MaKichCo";
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int x = reader.GetInt32(0);
                    list.Add(x);
                }
            }
            CloseConnection();
            return list;


        }

        public List<ChiTietSanPham> LayToanBoChiTietSanPhamTuMaSanPham(int maSanPham)
        {


            List<ChiTietSanPham> danhSachChiTietSanPham = new List<ChiTietSanPham>();
            try
            {
                OpenConnection();
                string sql = "select * from ChiTietSanPham where MaSanPham  = N'" + maSanPham + "'";
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                    chiTietSanPham.MaChiTietSanPham = reader.GetInt32(0);
                    chiTietSanPham.MaSanPham = reader.GetInt32(1);
                    chiTietSanPham.MaMauSac = reader.GetInt32(2);
                    chiTietSanPham.MaKichCo = reader.GetInt32(3);
                    chiTietSanPham.HinhAnh = (byte[])reader["HinhAnh"];
                    chiTietSanPham.SoLuongNhap = reader.GetInt32(5);
                    chiTietSanPham.SoLuongTon = reader.GetInt32(6);
                    chiTietSanPham.TrangThai = reader.GetInt32(7);
                    danhSachChiTietSanPham.Add(chiTietSanPham);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietSanPham;
        }
    }
}

