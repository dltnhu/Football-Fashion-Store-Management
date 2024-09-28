using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DAO
{
    public class PhieuNhapDAO : DatabaseAccess
    {
        public List<PhieuNhap> LayToanBoPhieuNhap()
        {
            List<PhieuNhap> danhSachPhieuNhap = new List<PhieuNhap>();
            try
            {
                string sql = "select * from PhieuNhap where trangthai = 1";
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap phieuNhap = new PhieuNhap();
                    phieuNhap.MaPhieuNhap = reader.GetInt32(0);
                    phieuNhap.MaNhaCungCap = reader.GetInt32(1);
                    phieuNhap.MaNhanVien = reader.GetInt32(2);
                    phieuNhap.NgayNhap = Convert.ToDateTime(reader.GetDateTime(3));
                    phieuNhap.TenPhieuNhap = reader.GetString(4);
                    double tongtiennhap = reader.GetDouble(5);
                    phieuNhap.TongTienNhap = Convert.ToSingle(tongtiennhap);
                    phieuNhap.TrangThai = reader.GetInt32(6);
                    danhSachPhieuNhap.Add(phieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachPhieuNhap;
        }


        public List<PhieuNhap> LayToanBoPhieuNhapTrongKhoang(String DateStart, String DateEnd)
        {
            List<PhieuNhap> danhSachPhieuNhap = new List<PhieuNhap>();
            try
            {
                string sql = "select * from PhieuNhap where trangthai = 1 and ((NgayNhap >= '" + DateStart + "' and  NgayNhap <= '" + DateEnd + "') OR" +
                " (NgayNhap = '" + DateStart + "' and  NgayNhap ='" + DateEnd + "' )) "; 
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap phieuNhap = new PhieuNhap();
                    phieuNhap.MaPhieuNhap = reader.GetInt32(0);
                    phieuNhap.MaNhaCungCap = reader.GetInt32(1);
                    phieuNhap.MaNhanVien = reader.GetInt32(2);
                    phieuNhap.NgayNhap = Convert.ToDateTime(reader.GetDateTime(3));
                    phieuNhap.TenPhieuNhap = reader.GetString(4);
                    double tongtiennhap = reader.GetDouble(5);
                    phieuNhap.TongTienNhap = Convert.ToSingle(tongtiennhap);
                    phieuNhap.TrangThai = reader.GetInt32(6);
                    danhSachPhieuNhap.Add(phieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachPhieuNhap;
        }

        public bool ThemPhieuNhap(PhieuNhap phieuNhap)
        {
            OpenConnection();
            string sql = "insert into PhieuNhap values(@MaNhaCungCap,@MaNhanVien,@NgayNhap,@TenPhieuNhap,@TongTienNhap,@TrangThai)";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.Int).Value = phieuNhap.MaNhaCungCap;
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = phieuNhap.MaNhanVien;
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = phieuNhap.NgayNhap;
            command.Parameters.Add("@TenPhieuNhap", SqlDbType.NVarChar).Value = phieuNhap.TenPhieuNhap;
            command.Parameters.Add("@TongTienNhap", SqlDbType.Float).Value = phieuNhap.TongTienNhap;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = phieuNhap.TrangThai;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool XoaPhieuNhap(int maPhieuNhap)
        {
            string sql = "UPDATE PhieuNhap SET TrangThai = 0 WHERE MaPhieuNhap = @maPhieuNhap";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maPhieuNhap", SqlDbType.Int).Value = maPhieuNhap;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool SuaPhieuNhap(PhieuNhap phieuNhap)
        {
            string sql = "UPDATE PhieuNhap SET MaNhaCungCap = @maNhaCungCap, MaNhanVien = @maNhanVien, NgayNhap = @ngayNhap, TenPhieuNhap = @tenPhieuNhap, TongTienNhap = @tongTienNhap WHERE MaPhieuNhap = @maPhieuNhap";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = phieuNhap.MaNhaCungCap;
            command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = phieuNhap.MaNhanVien;
            command.Parameters.Add("@ngayNhap", SqlDbType.DateTime).Value = phieuNhap.NgayNhap;
            command.Parameters.Add("@tenPhieuNhap", SqlDbType.NVarChar).Value = phieuNhap.TenPhieuNhap;
            command.Parameters.Add("@tongTienNhap", SqlDbType.Float).Value = phieuNhap.TongTienNhap;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = phieuNhap.MaPhieuNhap;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public List<PhieuNhap> TimKiemPhieuNhap(string text)
        {
            OpenConnection();
            List<PhieuNhap> danhSachPhieuNhap = new List<PhieuNhap>();
            string sql = "select * from PhieuNhap where like '%" + text + "%'";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.MaPhieuNhap = reader.GetInt32(0);
                phieuNhap.MaNhaCungCap = reader.GetInt32(1);
                phieuNhap.MaNhanVien = reader.GetInt32(2);
                phieuNhap.NgayNhap = Convert.ToDateTime(reader.GetDateTime(3));
                phieuNhap.TenPhieuNhap = reader.GetString(4);
                double tongtiennhap = reader.GetDouble(5);
                phieuNhap.TongTienNhap = Convert.ToSingle(tongtiennhap);
                phieuNhap.TrangThai = reader.GetInt32(6);
                danhSachPhieuNhap.Add(phieuNhap);
            }
            CloseConnection();
            return danhSachPhieuNhap;
        }



    }
}

