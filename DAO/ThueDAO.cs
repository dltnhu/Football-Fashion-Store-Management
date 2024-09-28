using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace DAO
{
    public class ThueDAO : DatabaseAccess
    {
        public List<Thue> LayToanBoThue()
        {
            List<Thue> danhSachThue = new List<Thue>();
            try
            {
                OpenConnection();
                string sql = "select * from Thue where TrangThai = 1";
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Thue thue = new Thue();
                    thue.MaThue = reader.GetInt32(0);
                    thue.TenThue = reader.GetString(1);
                    thue.MucThue = Convert.ToSingle(reader.GetDouble(2));
                    thue.TrangThai = reader.GetInt32(3);
                    danhSachThue.Add(thue);
                }
                CloseConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return danhSachThue;

        }
        public bool ThemThongTinThue(Thue thue)
        {
            OpenConnection();
            string sql = "insert into Thue values(@TenThue,@MucThue,1)";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@TenThue", SqlDbType.NVarChar).Value = thue.TenThue;
            command.Parameters.Add("@MucThue", SqlDbType.Float).Value = thue.MucThue;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool XoaThongTinThue(int MaThue)
        {
            OpenConnection();
            string sql = "update Thue  set TrangThai = 0 where MaThue=@MaThue";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaThue", SqlDbType.Int).Value = MaThue;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }



        public List<Thue> TimKiemThue(string text)
        {
            List<Thue> danhSachTimKiem = new List<Thue>();
            string sql = "select * from Thue where concat(MaThue,TenThue, MucThue)  like N'%" + text + "%'";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                double dt;
                Thue thue = new Thue();
                thue.MaThue = reader.GetInt32(0);
                thue.TenThue = reader.GetString(1);
                dt = reader.GetDouble(2);
                thue.MucThue = Convert.ToSingle(dt);
                thue.TrangThai = reader.GetInt32(3);
                danhSachTimKiem.Add(thue);
            }
            CloseConnection();
            return danhSachTimKiem;
        }

        public ArrayList getAllListThue()
        {
            ArrayList list = new ArrayList();
            SqlCommand cmd;
            string query = "select * from Thue where TrangThai=1";
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Thue t = new Thue();
                    t.MaThue = reader.GetInt32(0);
                    t.TenThue = reader.GetString(1);
                    t.MucThue = Convert.ToSingle(reader.GetDouble(2));
                    list.Add(t);
                }

            }
            CloseConnection();
            return list;
        }

        public bool removeFromMa(int MaThue)
        {

            try
            {
                OpenConnection();
                SqlCommand cmd;
                String query = "update Thue set TrangThai = 1 where MaThue = " + MaThue;
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public bool update(int MaThue, String tenThue, float MucThue)
        {

            try
            {
                OpenConnection();
                SqlCommand cmd;
                String query = "update Thue set TenThue = N'" + tenThue + "', MucThue = " + MucThue + " where MaThue = " + MaThue;
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }



    }
}
