using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;
using System.Data;
using System.Configuration;

namespace SIApotek
{
    class CrudSupplier
    {
        private String ConnString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;

        public string Insert(string Nama, string NoTelp, string Fax, string Alamat)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_supplier (Nama, NoTelp, Fax, Alamat)" + "VALUES (@Nama, @NoTelp, @Fax, @Alamat)", conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", Nama);
                    cmd.Parameters.AddWithValue("@NoTelp", NoTelp);
                    cmd.Parameters.AddWithValue("@Fax", Fax);
                    cmd.Parameters.AddWithValue("@Alamat", Alamat);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
            return result;
        }

        public string Update(int IdSupplier, string Nama, string NoTelp, string Fax, string Alamat)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE tb_supplier SET Nama=@Nama, NoTelp=@NoTelp, Fax=@Fax, Alamat=@Alamat WHERE IdSupplier=@IdSupplier", conn))
                {
                    cmd.Parameters.AddWithValue("IdSupplier", IdSupplier);
                    cmd.Parameters.AddWithValue("@Nama", Nama);
                    cmd.Parameters.AddWithValue("@NoTelp", NoTelp);
                    cmd.Parameters.AddWithValue("@Fax", Fax);
                    cmd.Parameters.AddWithValue("@Alamat", Alamat);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
            return result;
        }

        public string Delete(int IdSupplier)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_supplier WHERE IdSupplier=@IdSupplier", conn))
                {
                    cmd.Parameters.AddWithValue("IdSupplier", IdSupplier);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
            return result;
        }

        public DataTable ReadAll()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_supplier", conn))
                {
                    conn.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
            }
            return dt;
        }
    }
}
