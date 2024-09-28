using DAO;
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
    public class HoaDonDAO : DatabaseAccess
    {


        public DataTable select(ref String queryStr)
        {
            SqlDataAdapter adt;
            DataTable dt = new DataTable();
            String query = queryStr;
            OpenConnection();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(dt);
            CloseConnection();
            return dt;
        }


        public DataTable TimKiem(String text)
        {
            String query = "select * from HoaDon where concat(MaHoaDon,MaThue,MaKhachHang,MaNhanVien,TenHoaDon) like N'%" + text + "%'";
            return select(ref query);
        }

        public DataTable getAllHoaDon()
        {
            String query = "select * from HoaDon";
            return select(ref query);
        }

        public bool insert(HoaDon hd)
        {

            String query = "insert into dbo.HoaDon " +
            "\r\nvalues ( @MaKhachHang,  @MaNhanVien, @MaKhuyenMai,  @MaThue,  @TenHoaDon,GETDATE(), @TongTien, @TongTienKhuyenMai, @TongTienThue,@HinhThucThanhToan, @ThanhTien,1)";
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = hd.MaKhachHang;
            cmd.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = hd.MaNhanVien;
            cmd.Parameters.Add("@MaKhuyenMai", SqlDbType.Int).Value = hd.MaKhuyenMai;
            cmd.Parameters.Add("@MaThue", SqlDbType.Int).Value = hd.MaThue;
            cmd.Parameters.Add("@TenHoaDon", SqlDbType.NVarChar).Value = hd.TenHoaDon;
            cmd.Parameters.Add("@TongTien", SqlDbType.Float).Value = hd.TongTien;
            cmd.Parameters.Add("@TongTienKhuyenMai", SqlDbType.Float).Value = hd.TongTienKhuyenMai;
            cmd.Parameters.Add("@TongTienThue", SqlDbType.Float).Value = hd.TongTienThue;
            cmd.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar).Value = hd.HinhThucThanhToan;
            cmd.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = hd.ThanhTien;
            cmd.ExecuteNonQuery();
            CloseConnection();
            return true;



        }



      /*  hd.MaHoaDon = reader.GetInt32(0);
                    hd.MaKhachHang = reader.GetInt32(1);
                    hd.MaNhanVien = reader.GetInt32(2);
                    hd.MaKhuyenMai = reader.GetInt32(3);
                    hd.MaThue = reader.GetInt32(4);
                    hd.TenHoaDon = reader.GetString(5);
                    hd.NgayLapHoaDon = reader.GetDateTime(6);
                    hd.TongTien = Convert.ToSingle(reader.GetDouble(7));
                    hd.TongTienKhuyenMai = Convert.ToSingle(reader.GetDouble(8));
                    hd.TongTienThue = Convert.ToSingle(reader.GetDouble(9));
                    hd.HinhThucThanhToan = reader.GetString(10);
                    hd.ThanhTien = Convert.ToSingle(reader.GetDouble(11));*/
        public bool update(HoaDon hd)
        {

            String query = "update dbo.HoaDon " +
            "\r\nset MaKhachHang = @MaKhachHang, MaNhanVien = @MaNhanVien, MaKhuyenMai = @MaKhuyenMai, MaThue = @MaThue,TenHoaDon =  @TenHoaDon,GETDATE()," +
            "TongTien = @TongTien,TongTienKhuyenMai = @TongTienKhuyenMai,TongTienThue = @TongTienThue,HinhThucThanhToan = @HinhThucThanhToan,ThanhTien = @ThanhTien" +
            "\n\rwhere  MaHoaDon = "+hd.MaHoaDon;
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = hd.MaKhachHang;
            cmd.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = hd.MaNhanVien;
            cmd.Parameters.Add("@MaKhuyenMai", SqlDbType.Int).Value = hd.MaKhuyenMai;
            cmd.Parameters.Add("@MaThue", SqlDbType.Int).Value = hd.MaThue;
            cmd.Parameters.Add("@TenHoaDon", SqlDbType.NVarChar).Value = hd.TenHoaDon;
            cmd.Parameters.Add("@TongTien", SqlDbType.Float).Value = hd.TongTien;
            cmd.Parameters.Add("@TongTienKhuyenMai", SqlDbType.Float).Value = hd.TongTienKhuyenMai;
            cmd.Parameters.Add("@TongTienThue", SqlDbType.Float).Value = hd.TongTienThue;
            cmd.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar).Value = hd.HinhThucThanhToan;
            cmd.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = hd.ThanhTien;
            cmd.ExecuteNonQuery();
            CloseConnection();
            return true;



        }

        public bool delete(String ma)
        {

            String query = "update dbo.HoaDon " +
            "\r\nset TrangThai = 0 " +
            "\n\rwhere MaHoaDon = "+ma;
            SqlCommand cmd = new SqlCommand(query,conn);
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
            return true;
        }

        public List<HoaDon> LayToanBoHoaDon()
        {
            List<HoaDon> danhSachHoaDon = new List<HoaDon>();
            String query = "select * from HoaDon";
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = reader.GetInt32(0);
                    hd.MaKhachHang = reader.GetInt32(1);
                    hd.MaNhanVien = reader.GetInt32(2);
                    hd.MaKhuyenMai = reader.GetInt32(3);
                    hd.MaThue = reader.GetInt32(4);
                    hd.TenHoaDon = reader.GetString(5);
                    hd.NgayLapHoaDon = reader.GetDateTime(6);
                    hd.TongTien = Convert.ToSingle(reader.GetDouble(7));
                    hd.TongTienKhuyenMai = Convert.ToSingle(reader.GetDouble(8));
                    hd.TongTienThue = Convert.ToSingle(reader.GetDouble(9));
                    hd.HinhThucThanhToan = reader.GetString(10);
                    hd.ThanhTien = Convert.ToSingle(reader.GetDouble(11));
                    danhSachHoaDon.Add(hd);


                }
            }
            CloseConnection();
            return danhSachHoaDon;
        }

        public HoaDon LayHoaDonTuMa(String text)
        {
            String query = "select * from HoaDon where MaHoaDon  = N'"+text+"'";
            SqlCommand cmd;
            HoaDon hd = new HoaDon();
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                     
                    hd.MaHoaDon = reader.GetInt32(0);
                    hd.MaKhachHang = reader.GetInt32(1);
                    hd.MaNhanVien = reader.GetInt32(2);
                    hd.MaKhuyenMai = reader.GetInt32(3);
                    hd.MaThue = reader.GetInt32(4);
                    hd.TenHoaDon = reader.GetString(5);
                    hd.NgayLapHoaDon = reader.GetDateTime(6);
                    hd.TongTien = Convert.ToSingle(reader.GetDouble(7));
                    hd.TongTienKhuyenMai = Convert.ToSingle(reader.GetDouble(8));
                    hd.TongTienThue = Convert.ToSingle(reader.GetDouble(9));
                    hd.HinhThucThanhToan = reader.GetString(10);
                    hd.ThanhTien = Convert.ToSingle(reader.GetDouble(11));


                }
            }
            CloseConnection();
            return hd;
        }


        ////////////////////////////
        ///


        public ArrayList getAllList()
        {
            ArrayList list = new ArrayList();
            String query = "select * from HoaDon where TrangThai = 1";
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = reader.GetInt32(0);
                    hd.MaKhachHang = reader.GetInt32(1);
                    hd.MaNhanVien = reader.GetInt32(2);
                    hd.MaKhuyenMai = reader.GetInt32(3);
                    hd.MaThue = reader.GetInt32(4);
                    hd.TenHoaDon = reader.GetString(5);
                    hd.NgayLapHoaDon = reader.GetDateTime(6);
                    hd.TongTien = Convert.ToSingle(reader.GetDouble(7));
                    hd.TongTienKhuyenMai = Convert.ToSingle(reader.GetDouble(8));
                    hd.TongTienThue = Convert.ToSingle(reader.GetDouble(9));
                    hd.HinhThucThanhToan = reader.GetString(10);
                    hd.ThanhTien = Convert.ToSingle(reader.GetDouble(11));
                    list.Add(hd);


                }
            }
            CloseConnection();
            return list;
        }


        public ArrayList DanhSachHoaDonTrongKhoang(String DateStart, String DateEnd)
        {
            ArrayList list = new ArrayList();
            String query = "select * from HoaDon where TrangThai = 1 and ((NgayLapHoaDon >= '"+DateStart+"' and  NgayLapHoaDon <= '"+DateEnd+"') OR" +
                " (NgayLapHoaDon = '"+DateStart+ "' and  NgayLapHoaDon ='" + DateEnd+"' )) ";
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = reader.GetInt32(0);
                    hd.MaKhachHang = reader.GetInt32(1);
                    hd.MaNhanVien = reader.GetInt32(2);
                    hd.MaKhuyenMai = reader.GetInt32(3);
                    hd.MaThue = reader.GetInt32(4);
                    hd.TenHoaDon = reader.GetString(5);
                    hd.NgayLapHoaDon = reader.GetDateTime(6);
                    hd.TongTien = Convert.ToSingle(reader.GetDouble(7));
                    hd.TongTienKhuyenMai = Convert.ToSingle(reader.GetDouble(8));
                    hd.TongTienThue = Convert.ToSingle(reader.GetDouble(9));
                    hd.HinhThucThanhToan = reader.GetString(10);
                    hd.ThanhTien = Convert.ToSingle(reader.GetDouble(11));
                    list.Add(hd);


                }
            }
            CloseConnection();
            return list;
        }

    }
}
