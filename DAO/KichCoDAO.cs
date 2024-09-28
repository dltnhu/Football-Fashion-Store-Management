using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DAO
{
    public class KichCoDAO : DatabaseAccess
    {

        // Lấy danh sách kích cỡ
        public List<KichCo> LayDanhSachKichCo()
        {
            List<KichCo> danhSachKichCo = new List<KichCo>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Select_KichCo";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int maKichCo = reader.GetInt32(0);
                    string tenKichCo = reader.GetString(1);
                    int trangThai = reader.GetInt32(2);
                    KichCo kichCo = new KichCo();
                    kichCo.MaKichCo = maKichCo;
                    kichCo.TenKichCo = tenKichCo;
                    kichCo.TrangThai = trangThai;

                    danhSachKichCo.Add(kichCo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachKichCo;
        }

        // Thêm kích cỡ
        public bool ThemKichCo(KichCo kichCo)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO KichCo VALUES(@tenKichCo, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@tenKichCo", SqlDbType.NVarChar).Value = kichCo.TenKichCo;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = kichCo.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Sửa kích cỡ
        public bool SuaKichCo(KichCo kichCo)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KichCo SET TenKichCo = @tenKichCo, TrangThai = @trangThai WHERE MaKichCo = @maKichCo";
                command.Connection = conn;
                command.Parameters.Add("@tenKichCo", SqlDbType.NVarChar).Value = kichCo.TenKichCo;
                command.Parameters.Add("@trangThai", SqlDbType.Int).Value = kichCo.TrangThai;
                command.Parameters.Add("@maKichCo", SqlDbType.Int).Value = kichCo.MaKichCo;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ketQua > 0;
        }

        // Xóa kích cỡ
        public bool XoaKichCo(KichCo kichCo)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE KichCo SET TrangThai = 0 WHERE MaKichCo = @maKichCo";
            command.Connection = conn;
            command.Parameters.Add("@maKichCo", SqlDbType.Int).Value = kichCo.MaKichCo;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }

        // Tìm kiếm kích cỡ
        public List<KichCo> TimKiemKichCo(string text)
        {
            List<KichCo> danhSachKichCoTimKiem = new List<KichCo>();
            OpenConnection();
            string sql = "select * from KichCo where concat(MaKichCo,TenKichCo) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                KichCo kichCo = new KichCo();
                kichCo.MaKichCo = reader.GetInt32(0);
                kichCo.TenKichCo = reader.GetString(1);
                kichCo.TrangThai = reader.GetInt32(2);
                danhSachKichCoTimKiem.Add(kichCo);
            }
            CloseConnection();
            return danhSachKichCoTimKiem;
        }



        public ArrayList getAllListKichCo(SanPham sp)
        {
            ArrayList list = new ArrayList();
            SqlCommand cmd;
            String query = "SELECT kc.* FROM SAN_PHAM as sp,CHI_TIET_SAN_PHAM as ct,kichco as kc" +
                "\nWHERE sp.MA_SAN_PHAM = ct.MA_SAN_PHAM" +
                "\nAND ct.MA_KICH_CO = kc.makichco " +
                "\nAND sp.MA_SAN_PHAM = N'" + sp.MaSanPham + "'" +
                "\nAND kc.trangthai = 1";
            OpenConnection();
            /*try
            {*/
            cmd = new SqlCommand(query, conn)
            {

            };
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    KichCo kc = new KichCo();
                    kc.MaKichCo = reader.GetInt32(0);
                    kc.TenKichCo = reader.GetString(1);
                    list.Add(kc);
                }

            }
            /*                }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }*/

            CloseConnection();
            return list;
        }

        public ArrayList getAllListKichCoMS(SanPham sp, MauSac ms)
        {
            ArrayList list = new ArrayList();
            SqlCommand cmd;
            String query = "SELECT kc.* FROM SAN_PHAM as sp,CHI_TIET_SAN_PHAM as ct,kichco as kc,mausac as ms" +
                "\nWHERE sp.MA_SAN_PHAM = ct.MA_SAN_PHAM" +
                "\nAND ct.MA_KICH_CO = kc.makichco " +
                "\nAND sp.MA_SAN_PHAM = N'" + sp.MaSanPham + "'" +

                "\nAND kc.trangthai = 1";
            OpenConnection();
            /*try
            {*/
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    KichCo kc = new KichCo();
                    kc.MaKichCo = reader.GetInt32(0);
                    kc.TenKichCo = reader.GetString(1);
                    list.Add(kc);
                }

            }
            /*                }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }*/

            CloseConnection();
            return list;
        }


        public KichCo getAllListKichCoFromCTSP(String ctsp)
        {
            KichCo kc = new KichCo();
            ArrayList list = new ArrayList();
            SqlCommand cmd;
            String query = "select kc.* from DBO.ChiTietSanPham as ctsp, DBO.KichCo as kc" +
                "\r\nwhere ctsp.MaKichCo = kc.MaKichCo" +
                "\r\nand ctsp.MaChiTietSanPham = " + ctsp + "" +
                "\r\nand\tkc.TrangThai = 1" +
                "\r\nand 1 = (select sp.TrangThai from DBO.SanPham as sp where MaSanPham = ctsp.MaSanPham)";
            OpenConnection();
            /*try
            {*/
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    kc.MaKichCo = reader.GetInt32(0);
                    kc.TenKichCo = reader.GetString(1);

                }

            }
            /*                }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }*/

            CloseConnection();
            return kc;











        }
    }
}
