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
    public class SanPhamDAO : DatabaseAccess
    {

        // Lấy danh sách sản phẩm
        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> danhSachSanPham = new List<SanPham>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Select_SanPham";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    SanPham sanPham = new SanPham();
                    sanPham.MaSanPham = reader.GetInt32(0);
                    sanPham.MaThuongHieu = reader.GetInt32(1);
                    sanPham.MaTheLoai = reader.GetInt32(2);
                    sanPham.MaChatLieu = reader.GetInt32(3);
                    sanPham.TenSanPham = reader.GetString(4);
                    double giasanpham = reader.GetDouble(5);
                    double gianhap = reader.GetDouble(6);
                    sanPham.GiaSanPham = Convert.ToSingle(giasanpham);
                    sanPham.GiaNhap = Convert.ToSingle(gianhap);
                    sanPham.SoLuongNhap = reader.GetInt32(7);
                    sanPham.SoLuongTon = reader.GetInt32(8);
                    sanPham.TrangThai = reader.GetInt32(9);
                    danhSachSanPham.Add(sanPham);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachSanPham;
        }

        // Thêm sản phẩm
        public bool ThemSanPham(SanPham sanPham)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO SanPham VALUES(@maThuongHieu, @maTheLoai, @maChatLieu, @tenSanPham, @giaSanPham, @giaNhap, @soLuongNhap, @soLuongTon, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@maThuongHieu", SqlDbType.NVarChar).Value = sanPham.MaThuongHieu;
            command.Parameters.Add("@maTheLoai", SqlDbType.NVarChar).Value = sanPham.MaTheLoai;
            command.Parameters.Add("@maChatLieu", SqlDbType.NVarChar).Value = sanPham.MaChatLieu;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
            command.Parameters.Add("@giaSanPham", SqlDbType.NVarChar).Value = sanPham.GiaSanPham;
            command.Parameters.Add("@giaNhap", SqlDbType.NVarChar).Value = sanPham.GiaNhap;
            command.Parameters.Add("@soLuongNhap", SqlDbType.NVarChar).Value = sanPham.SoLuongNhap;
            command.Parameters.Add("@soLuongTon", SqlDbType.NVarChar).Value = sanPham.SoLuongTon;
            command.Parameters.Add("@trangThai", SqlDbType.NVarChar).Value = sanPham.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Sửa sản phẩm
        public bool SuaSanPham(SanPham sanPham)
        {
            string sql = "update SanPham set MaThuongHieu=@maThuongHieu, MaTheLoai=@maTheLoai, MaChatLieu=@maChatLieu,TenSanPham= @tenSanPham, GiaSanPham=@giaSanPham where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = sanPham.MaSanPham;
            command.Parameters.Add("@maThuongHieu", SqlDbType.Int).Value = sanPham.MaThuongHieu;
            command.Parameters.Add("@maTheLoai", SqlDbType.Int).Value = sanPham.MaTheLoai;
            command.Parameters.Add("@maChatLieu", SqlDbType.Int).Value = sanPham.MaChatLieu;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
            command.Parameters.Add("@giaSanPham", SqlDbType.Float).Value = sanPham.GiaSanPham;
            OpenConnection();
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Xóa sản phẩm
        public bool XoaSanPham(int maSanPham)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE SanPham SET TrangThai = 0 WHERE MaSanPham = @maSanPham";
            command.Connection = conn;
            command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = maSanPham;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }


        // cập nhật số lượng

        public bool capNhatSoLuong(int maSanPham, int soLuongNhap, int soLuongTon)
        {
            string sql = "UPDATE SanPham SET SoLuongNhap = @soLuongNhap, SoLuongTon = @soLuongTon  WHERE MaSanPham = @maSanPham";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@soLuongNhap", SqlDbType.Int).Value = soLuongNhap;
            command.Parameters.Add("@soLuongTon", SqlDbType.Int).Value = soLuongTon;
            command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = maSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // tìm kiếm sản phẩm
        public List<SanPham> TimKiemSanPham(string text)
        {
            List<SanPham> arraysanpham = new List<SanPham>();
            //string sql = "select * from SanPham where concat(MaSanPham,MaThuongHieu,MaTheLoai,MaChatLieu,TenSanPham,GiaSanPham,GiaNhap,SoLuongNhap,SoLuongTon) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            string sql = "select MaSanPham,ThuongHieu.MaThuongHieu,TheLoai.MaTheLoai,ChatLieu.MaChatLieu,TenSanPham,GiaSanPham,GiaNhap,SoLuongNhap,SoLuongTon,SanPham.TrangThai from SanPham join TheLoai " +
                "on TheLoai.MaTheLoai=SanPham.MaTheLoai join ThuongHieu on ThuongHieu.MaThuongHieu=SanPham.MaThuongHieu join ChatLieu on ChatLieu.MaChatLieu=SanPham.MaChatLieu " +
                "where CONCAT(MaSanPham,ThuongHieu.MaThuongHieu,TheLoai.MaTheLoai,ChatLieu.MaChatLieu,TenSanPham,GiaSanPham,GiaNhap,SoLuongNhap,SoLuongTon,ThuongHieu.TenThuongHieu,TheLoai.TenTheLoai,ChatLieu.TenChatLieu)COLLATE Latin1_General_CI_AI like '%" + text + "%' and SanPham.TrangThai=1";
            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                double gsp, gn;
                SanPham sanpham = new SanPham();
                sanpham.MaSanPham = reader.GetInt32(0);
                sanpham.MaThuongHieu = reader.GetInt32(1);
                sanpham.MaTheLoai = reader.GetInt32(2);
                sanpham.MaChatLieu = reader.GetInt32(3);
                sanpham.TenSanPham = reader.GetString(4);
                gsp = reader.GetDouble(5);
                sanpham.GiaSanPham = Convert.ToSingle(gsp);
                gn = reader.GetDouble(6);
                sanpham.GiaNhap = Convert.ToSingle(gn);
                sanpham.SoLuongNhap = reader.GetInt32(7);
                sanpham.SoLuongTon = reader.GetInt32(8);
                sanpham.TrangThai = reader.GetInt32(9);
                arraysanpham.Add(sanpham);
            }
            CloseConnection();
            return arraysanpham;
        }


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
        public ArrayList getAllListSanPham()
        {
            SqlCommand cmd;
            ArrayList list = new ArrayList();
            String query = "SELECT sp.*,sp.GiaSanPham  FROM SanPham as sp, ChiTietSanPham as ctsp WHERE ctsp.TrangThai = 1 and sp.MaSanPham = ctsp.MaSanPham";

            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    SanPham sp = new SanPham();
                    sp.MaSanPham = reader.GetInt32(0);
                    sp.MaThuongHieu = reader.GetInt32(1);
                    sp.MaTheLoai = reader.GetInt32(2);
                    sp.MaChatLieu = reader.GetInt32(3);
                    sp.TenSanPham = reader.GetString(4);
                    sp.GiaSanPham = Convert.ToSingle(reader.GetDouble(5));
                    sp.GiaNhap = Convert.ToSingle(reader.GetDouble(6));
                    sp.SoLuongNhap = reader.GetInt32(7);
                    sp.SoLuongTon = reader.GetInt32(8);
                    list.Add(sp.MaSanPham + "," + sp.MaThuongHieu + "," + sp.MaTheLoai + "," 
                        + sp.MaChatLieu + "," + sp.TenSanPham + "," + sp.GiaSanPham + "," +
                        sp.GiaNhap + "," + sp.SoLuongNhap + "," + sp.SoLuongTon + "," );

                }

            }
            CloseConnection();

            return list;
        }

        public ArrayList getAllListSanPham1()
        {
            SqlCommand cmd;
            ArrayList list = new ArrayList();
            String query = "SELECT sp.*,sp.GiaSanPham  FROM SanPham as sp, ChiTietSanPham as ctsp WHERE ctsp.TrangThai = 1 and sp.MaSanPham = ctsp.MaSanPham";

            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    SanPham sp = new SanPham();
                    sp.MaSanPham = reader.GetInt32(0);
                    sp.MaThuongHieu = reader.GetInt32(1);
                    sp.MaTheLoai = reader.GetInt32(2);
                    sp.MaChatLieu = reader.GetInt32(3);
                    sp.TenSanPham = reader.GetString(4);
                    sp.GiaSanPham = Convert.ToSingle(reader.GetDouble(5));
                    sp.GiaNhap = Convert.ToSingle(reader.GetDouble(6));
                    sp.SoLuongNhap = reader.GetInt32(7);
                    sp.SoLuongTon = reader.GetInt32(8);

                }

            }
            CloseConnection();

            return list;
        }

        public SanPham getSanPham(String ma)
        {

            SanPham sp = new SanPham();
            SqlCommand cmd;
            String query = "SELECT sp.*,ctsp.GiaSanPham FROM SanPham WHERE MaSanPham = " + ma + " AND TrangThai = 1";
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    sp.MaSanPham = reader.GetInt32(0);
                    sp.MaThuongHieu = reader.GetInt32(1);
                    sp.MaTheLoai = reader.GetInt32(2);
                    sp.MaChatLieu = reader.GetInt32(3);
                    sp.TenSanPham = reader.GetString(4);
                    sp.GiaSanPham = Convert.ToSingle(reader.GetDouble(11));
                    sp.GiaNhap = Convert.ToSingle(reader.GetDouble(6));
                    sp.SoLuongNhap = reader.GetInt32(7);
                    sp.SoLuongTon = reader.GetInt32(8);


                }

            }

            return sp;

        }

        public SanPham getSanPhamFromCTSP(String ctsp)
        {

            SanPham sp = new SanPham();
            SqlCommand cmd;
            String query = "select sp.* from DBO.SanPham as sp,DBO.ChiTietSanPham as ctsp" +
                "\r\nwhere sp.MaSanPham = ctsp.MaSanPham" +
                "\r\nand ctsp.MaChiTietSanPham = " + ctsp;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    sp.MaSanPham = reader.GetInt32(0);
                    sp.MaThuongHieu = reader.GetInt32(1);
                    sp.MaTheLoai = reader.GetInt32(2);
                    sp.MaChatLieu = reader.GetInt32(3);
                    sp.TenSanPham = reader.GetString(4);
                    sp.GiaSanPham = Convert.ToSingle(reader.GetDouble(5));
                    sp.GiaNhap = Convert.ToSingle(reader.GetDouble(6));
                    sp.SoLuongNhap = reader.GetInt32(7);
                    sp.SoLuongTon = reader.GetInt32(8);




                }

            }
            CloseConnection();
            return sp;

        }


        public DataTable getAllSanPham()
        {
            String query = "select ctsp.MaChiTietSanPham, sp.TenSanPham, ms.TenMauSac,kc.TenKichCo,tl.TenTheLoai,cl.TenChatLieu,th.TenThuongHieu,ctsp.SoLuongTon" +
                " from   SanPham as sp, ChiTietSanPham as ctsp, MauSac as ms, KichCo as kc, TheLoai as tl, ChatLieu as cl,ThuongHieu as th" +
                " where sp.TrangThai =1 " +
                " and sp.MaSanPham = ctsp.MaSanPham" +
                " and ms.MaMauSac = ctsp.MaMauSac" +
                " and kc.MaKichCo =ctsp.MaKichCo" +
                " and tl.MaTheLoai = sp.MaTheLoai" +
                " and cl.MaChatLieu = sp.MaChatLieu" +
                " and th.MaThuongHieu = sp.MaThuongHieu";
            return select(ref query);
        }

        public DataTable FindSanPham(String key)
        {
            String query;
            double so = 0;
            if (IsNumeric(key))
            {
                so = double.Parse(key);
                query = "SELECT MA_SAN_PHAM,TEN_SAN_PHAM,GIA_SAN_PHAM,SO_LUONG_TON FROM SAN_PHAM\n" +
               " WHERE TRANG_THAI = 1" +
               "AND ((GIA_SAN_PHAM = " + so + ") " +
                "OR (SO_LUONG_TON = " + so + "))";
            }
            else
            {
                query = "SELECT MA_SAN_PHAM,TEN_SAN_PHAM,GIA_SAN_PHAM,SO_LUONG_TON FROM SAN_PHAM\n" +
               " WHERE " +
               "MA_SAN_PHAM  LIKE N'%" + key + "%' " +
               "OR TEN_SAN_PHAM  LIKE N'%" + key + "%' ";
            }

            return select(ref query);
        }

        public static bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }

        public int getSoLuongTonfromMa(String maSP)
        {
            int soLuongTon = 0;
            SqlCommand cmd;
            String query = "SELECT sp.SoLuongTon FROM DBO.SanPham as sp" +
                    "\r\nwhere sp.MaSanPham = " + maSP;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    soLuongTon = reader.GetInt32(0);
                }
                CloseConnection();
            }
            return soLuongTon;


        }

        public int getSoLuongBanfromMa(String maSP)
        {
            int soLuongBan = 0;
            SqlCommand cmd;
            String query = "SELECT sp.SoLuongBan FROM DBO.SanPham as sp" +
                    "\r\nwhere sp.MaSanPham = " + maSP;
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    soLuongBan = reader.GetInt32(0);
                }
            }
            CloseConnection();
            return soLuongBan;


        }


        public bool updateSoLuong(int slBan, String ma)
        {
            try
            {
                SqlCommand cmd;
                int soLuongTon = getSoLuongTonfromMa(ma);
                int updatedSoLuongTon = soLuongTon - slBan;
                String query = "update DBO.SanPham" +
                    "\r\nset SoLuongTon= " + updatedSoLuongTon +
                    " \r\nwhere MaSanPham = " + ma;

                OpenConnection();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }




        }

        public ArrayList TimKiemSanPhamDGV(String text)
        {
            String sql = "select ctsp.MaChiTietSanPham, sp.TenSanPham, ms.TenMauSac,kc.TenKichCo,tl.TenTheLoai,cl.TenChatLieu,th.TenThuongHieu,ctsp.SoLuongTon" +
                " from   SanPham as sp, ChiTietSanPham as ctsp, MauSac as ms, KichCo as kc, TheLoai as tl, ChatLieu as cl,ThuongHieu as th" +
                " where sp.TrangThai =1 " +
                "and concat(ctsp.MaChiTietSanPham, sp.TenSanPham, ms.TenMauSac,kc.TenKichCo,tl.TenTheLoai,cl.TenChatLieu,th.TenThuongHieu) like N'%" + text + "%'" +
                " and sp.MaSanPham = ctsp.MaSanPham" +
                " and ms.MaMauSac = ctsp.MaMauSac" +
                " and kc.MaKichCo =ctsp.MaKichCo" +
                " and tl.MaTheLoai = sp.MaTheLoai" +
                " and cl.MaChatLieu = sp.MaChatLieu" +
                " and th.MaThuongHieu = sp.MaThuongHieu";

            ArrayList list = new ArrayList();
            SqlCommand cmd = new SqlCommand(sql, conn);
            OpenConnection();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    int MaChiTietSanPham = reader.GetInt32(0);
                    string TenSanPham = reader.GetString(1);
                    string TenMauSac = reader.GetString(2);
                    string TenKichCo = reader.GetString(3);
                    string TenTheLoai = reader.GetString(4);
                    string TenChatLieu = reader.GetString(5);
                    string TenThuongHieu = reader.GetString(6);
                    int SoLuongTon = reader.GetInt32(7);
                    string sb = new string("");
                    sb = MaChiTietSanPham + "," + TenSanPham + "," + TenMauSac + "," + TenKichCo + "," + TenTheLoai + "," + TenChatLieu + "," + TenThuongHieu + "," + SoLuongTon;
                    list.Add(sb);
                }
            }
            CloseConnection();
            return list;
        }


    }
}
