using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Data
{
    public class ClsKetNoi
    {
        SqlConnection con = new SqlConnection();

        string ketnoi = @"data source =10.2.5.23; Initial Catalog=QuanLyTaiSan;Integrated Security=False;User ID=abcselect;Password=123456@Abc"; //Home
        //string ketnoi = @"Data Source=SQL5075.site4now.net;Initial Catalog=db_a84c3a_quanlytaisan;User Id=db_a84c3a_quanlytaisan_admin;Password=HQG2000hn"; //Home

        //Giải phóng bộ nhớ
        public void Close()
        {
            con.Dispose();
        }
        public ClsKetNoi()
        {
            con.ConnectionString = ketnoi;
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public DataTable LayDuLieu(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Dispose();
            adapter.Dispose();
            dt.Dispose();
            return dt;
        }
        public DataTable LayDuLieu(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Dispose();
            adapter.Dispose();
            dt.Dispose();
            return dt;
        }
        public SqlDataReader LayDuLieu_R(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Dispose();
            return command.ExecuteReader();
        }

        public SqlDataReader LayDuLieu_R(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            command.Dispose();
            return command.ExecuteReader();
        }

        public int LayDuLieu_Count(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Dispose();
            adapter.Dispose();
            dt.Dispose();
            return dt.Rows.Count;
        }

        public int LayDuLieu_Count(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Dispose();
            adapter.Dispose();
            dt.Dispose();
            return dt.Rows.Count;
        }
        public int Update(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Dispose();
            return command.ExecuteNonQuery();
        }
        public int Update(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            command.Dispose();
            return command.ExecuteNonQuery();
        }
    }
}
