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
    public class KhachHangDAO : DatabaseAccess
    {
       
        ////////////////////
        ///
        public ArrayList GetAllList()
        {
            ArrayList list = new ArrayList();
            String query = "Select * From KhachHang where TrangThai = 1";
            SqlCommand cmd;
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKhachHang = reader.GetInt32(0);
                        kh.TenKhachHang = reader.GetString(1);
                        kh.SoDienThoai = reader.GetString(2);
                        list.Add(kh);

                    }
                }
                CloseConnection();

            }
            catch (Exception ex)
            {

            }

            return list;

        }

        public KhachHang GetFromSoDienThoai(String SoDienThoai)
        {
            KhachHang kh = new KhachHang();
            String query = "Select * From KhachHang where SoDienThoai = N'" + SoDienThoai + "' and TrangThai = 1";
            SqlCommand cmd;
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        kh.MaKhachHang = reader.GetInt32(0);
                        kh.TenKhachHang = reader.GetString(1);
                        kh.SoDienThoai = reader.GetString(2);

                    }
                }
                CloseConnection();

            }
            catch (Exception ex)
            {

            }

            return kh;

        }



        public KhachHang LayKhachHangTuMa(String MaKhachHang)
        {
            KhachHang kh = new KhachHang();
            String query = "Select * From KhachHang where MaKhachHang = N'" + MaKhachHang + "' and TrangThai = 1";
            SqlCommand cmd;
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        kh.MaKhachHang = reader.GetInt32(0);
                        kh.TenKhachHang = reader.GetString(1);
                        kh.SoDienThoai = reader.GetString(2);

                    }
                }
                CloseConnection();

            }
            catch (Exception ex)
            {

            }

            return kh;

        }

        public bool hasInDB(String SoDienThoai)
        {
            KhachHang kh = new KhachHang();
            String query = "Select * From KhachHang where SoDienThoai =  N'" + SoDienThoai + "' and TrangThai = 1";
            SqlCommand cmd;
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) return true;
                }
                CloseConnection();

            }
            catch (Exception ex)
            {

            }

            return false;

        }


        public Boolean ThemThongTinKhachHang(KhachHang kh)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO KhachHang VALUES(@TenKhachHang,@SoDienThoai,1)";
            command.Connection = conn;
            command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = kh.TenKhachHang;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = kh.SoDienThoai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        public Boolean SuaThongTinKhachHang(KhachHang kh, String ten, String sdt)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update KhachHang set TenKhachHang=@TenKhachHang, SoDienThoai = @SoDienThoai where MaKhachHang = " + kh.MaKhachHang;
            command.Connection = conn;
            command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = sdt;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        public Boolean XoaThongTinKhachHang(KhachHang kh)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update KhachHang set TrangThai = 0 where MaKhachHang = " + kh.MaKhachHang;
            command.Connection = conn;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }




        public DataTable select(ref String queryStr)
        {
            DataTable dt = null;
            try
            {
                SqlDataAdapter adt;
                dt = new DataTable();
                String query = queryStr;
                OpenConnection();
                adt = new SqlDataAdapter(query, conn);
                adt.Fill(dt);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            CloseConnection();
            return dt;
        }

        public DataTable getAllKhachHang()
        {
            /*String query = "select MaKhachHang, TenKhachHang,SoDienThoai from KhachHang   ";*/
            String query = "select * from KhachHang  where TrangThai = 1  ";
            return select(ref query);
        }


        public DataTable TimKiem(String text)
        {
            /*String query = "select MaKhachHang, TenKhachHang,SoDienThoai from KhachHang   ";*/
            String query = "select * from KhachHang  where TrangThai = 1" +
                "\n and concat(MaKhachHang,TenKhachHang,SoDienThoai) like N'%" + text + "%' ";
            return select(ref query);
        }
    }
}
