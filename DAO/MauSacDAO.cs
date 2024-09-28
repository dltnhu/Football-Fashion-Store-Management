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
    public class MauSacDAO : DatabaseAccess
    {
        // Lấy danh sách màu sắc
        public List<MauSac> LayDanhSachMauSac()
        {
            List<MauSac> danhSachMauSac = new List<MauSac>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Select_MauSac";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int maMauSac = reader.GetInt32(0);
                    string tenMauSac = reader.GetString(1);
                    int trangThai = reader.GetInt32(2);
                    MauSac mauSac = new MauSac();
                    mauSac.MaMauSac = maMauSac;
                    mauSac.TenMauSac = tenMauSac;
                    mauSac.TrangThai = trangThai;

                    danhSachMauSac.Add(mauSac);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachMauSac;
        }

        // Thêm màu sắc
        public bool ThemMauSac(MauSac mauSac)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO MauSac VALUES(@tenMauSac, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@tenMauSac", SqlDbType.NVarChar).Value = mauSac.TenMauSac;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = mauSac.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Sửa màu sắc
        public bool SuaMauSac(MauSac mauSac)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE MauSac SET TenMauSac = @tenMauSac, TrangThai = @trangThai WHERE MaMauSac = @maMauSac";
                command.Connection = conn;
                command.Parameters.Add("@tenMauSac", SqlDbType.NVarChar).Value = mauSac.TenMauSac;
                command.Parameters.Add("@trangThai", SqlDbType.Int).Value = mauSac.TrangThai;
                command.Parameters.Add("@maMauSac", SqlDbType.Int).Value = mauSac.MaMauSac;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ketQua > 0;
        }

        //Xóa màu sắc
        public bool XoaMauSac(MauSac mauSac)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM MauSac WHERE MaMauSac = @maMauSac";
            command.Connection = conn;
            command.Parameters.Add("@maMauSac", SqlDbType.Int).Value = mauSac.MaMauSac;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }


        // Tìm kiếm màu sắc
        public List<MauSac> TimKiemMauSac(string text)
        {
            List<MauSac> danhSachMauSacTimKiem = new List<MauSac>();
            OpenConnection();
            string sql = "select * from MauSac where concat(MaMauSac,TenMauSac) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                MauSac mauSac = new MauSac();
                mauSac.MaMauSac = reader.GetInt32(0);
                mauSac.TenMauSac = reader.GetString(1);
                mauSac.TrangThai = reader.GetInt32(2);
                danhSachMauSacTimKiem.Add(mauSac);
            }
            CloseConnection();
            return danhSachMauSacTimKiem;
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


        public ArrayList select(string query1)
        {
            ArrayList list = new ArrayList();
            SqlCommand cmd;

            string query = query1;
            OpenConnection();

            /*try
            {*/
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    MauSac ms = new MauSac();
                    ms.MaMauSac = reader.GetInt32(0);
                    ms.TenMauSac = reader.GetString(1);
                    list.Add(ms);
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

        /* public static ArrayList getAllListMauSacKC(SanPham sp,kichco kc)
         {
             string query= "SELECT ms.* FROM SAN_PHAM as sp,CHI_TIET_SAN_PHAM as ct,mausac as ms" +
                     "\nWHERE sp.MA_SAN_PHAM = ct.MA_SAN_PHAM" +
                     "\nAND ct.MA_MAU_SAC = ms.mamau " +
                     "\nAND ct.MA_KICH_CO = N'"+kc.MaKichCo+"'" +
                     "\nAND sp.MA_SAN_PHAM = N'" + sp.MaSanPham.Trim() + "'" +
                     "\nAND ms.trangthai = 1";
             return select(query);
         }*/
        public MauSac getMauSacfromCTSP(string ctsp)
        {

            MauSac ms = new MauSac();
            SqlCommand cmd;

            string query = "select ms.* from DBO.ChiTietSanPham as ctsp, DBO.MauSac as ms" +
            "\r\nwhere ctsp.MaMauSac = ms.MaMauSac \r\nand ctsp.MaChiTietSanPham = " + ctsp + "" +
            "\r\nand ms.TrangThai = 1" +
            "\r\nand  1 = (select sp.TrangThai from DBO.SanPham as sp where MaSanPham = ctsp.MaSanPham)";
            OpenConnection();
            /*try
            {*/
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ms.MaMauSac = reader.GetInt32(0);
                    ms.TenMauSac = reader.GetString(1);

                }

            }
            /*                }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }*/

            CloseConnection();
            return ms;
        }
    }
}
