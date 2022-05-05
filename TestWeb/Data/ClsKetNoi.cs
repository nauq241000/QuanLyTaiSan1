using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Security.Cryptography;

namespace Data
{
    public class ClsKetNoi
    {
        SqlConnection con = new SqlConnection(Decrypt(ConfigurationManager.ConnectionStrings["con"].ConnectionString,"Uneti"));

        //Giải phóng bộ nhớ
        public void Close()
        {
            con.Dispose();
        }
        public ClsKetNoi()
        {
            //con.ConnectionString = ketnoi;
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

        public DataTable LayDuLieuASP(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
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

        public SqlDataReader LayDuLieuASP_R(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
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

        private static string Encrypt(string text, string key)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        private static string Decrypt(string cipher, string key)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
    }
}
