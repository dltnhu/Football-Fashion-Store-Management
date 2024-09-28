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
    public class ChiTietHoaDonDAO : DatabaseAccess
    {
        public bool insertCTHD(ChiTietHoaDon cthd, int MaHoaDon)
        {
            try
            {
                String query = "INSERT INTO DBO.ChiTietHoaDon VALUES(@MaChiTietSanPham,@MaHoaDon,@GiaSanPham,@SoLuong,@ThanhTien)";
                SqlCommand cmd;
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = cthd.MaChiTietSanPham;
                cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = MaHoaDon;
                cmd.Parameters.Add("@GiaSanPham", SqlDbType.Float).Value = cthd.GiaSanPham;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cthd.SoLuong;
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = cthd.ThanhTien;
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }



        }

        public bool updateCTHD(ChiTietHoaDon cthd, int MaHoaDon)
        {
            try
            {
                String query = "update DBO.ChiTietHoaDon" +
                    "\n\rset MaChiTietSanPham =  @MaChiTietSanPham,MaHoaDon = @MaHoaDon,GiaSanPham = @GiaSanPham,SoLuong = @SoLuong,ThanhTien = @ThanhTien" +
                    "\n\r where MaChiTietHoaDon  =  " + cthd.MaChiTietHoaDon;
                SqlCommand cmd;
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = cthd.MaChiTietSanPham;
                cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = MaHoaDon;
                cmd.Parameters.Add("@GiaSanPham", SqlDbType.Float).Value = cthd.GiaSanPham;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cthd.SoLuong;
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = cthd.ThanhTien;
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }



        }


        public bool deleteCTHD(ChiTietHoaDon cthd)
        {
            try
            {
                String query = "update DBO.ChiTietHoaDon" +
                    "\n\rset MaChiTietSanPham =  @MaChiTietSanPham,MaHoaDon = @MaHoaDon,GiaSanPham = @GiaSanPham,SoLuong = @SoLuong,ThanhTien = @ThanhTien" +
                    "\n\r where MaChiTietHoaDon  =  " + cthd.MaChiTietHoaDon;
                SqlCommand cmd = new SqlCommand(query, conn);
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }



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

        public DataTable pushCTHDFromHD(String MaHoaDon)
        {
            SqlCommand cmd;
            ArrayList list = new ArrayList();
            String query = "SELECT cthd.MaHoaDon,sp.TenSanPham,cthd.SoLuong,cthd.GiaSanPham, cthd.ThanhTien FROM ChiTietHoaDon as cthd, ChiTietSanPham as ctsp, SanPham as sp \r\nwhere cthd.MaHoaDon = " + MaHoaDon + "\r\nand cthd.MaChiTietSanPham = ctsp.MaChiTietSanPham\r\nand ctsp.MaSanPham = sp.MaSanPham";
            return select(ref query);



        }









        //////////////////////////////
        ///

    }
}
