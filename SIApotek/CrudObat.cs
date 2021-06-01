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
    class CrudObat
    {
        private String ConnString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;

        public string Insert(string NamaObat, int HBeli, int HJual, int Jumlah, string TglExp, string Perusahaan)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_obat (NamaObat, HBeli, HJual, Jumlah, TglExp, Perusahaan)" + "VALUES (@NamaObat, @HBeli, @HJual, @Jumlah, @TglExp, @Perusahaan)", conn))
                {
                    cmd.Parameters.AddWithValue("@NamaObat", NamaObat);
                    cmd.Parameters.AddWithValue("@HBeli", HBeli);
                    cmd.Parameters.AddWithValue("@HJual", HJual);
                    cmd.Parameters.AddWithValue("@Jumlah", Jumlah);
                    cmd.Parameters.AddWithValue("@TglExp", TglExp);
                    cmd.Parameters.AddWithValue("@Perusahaan", Perusahaan);
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

        public string Update(int IdObat, string NamaObat, int HBeli, int HJual, int Jumlah, string TglExp, string Perusahaan)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE tb_obat SET NamaObat=@NamaObat, HBeli=@HBeli, HJual=@HJual, Jumlah=@Jumlah, TglExp=@TglExp, Perusahaan=@Perusahaan WHERE IdObat=@IdObat", conn))
                {
                    cmd.Parameters.AddWithValue("IdObat", IdObat);
                    cmd.Parameters.AddWithValue("@NamaObat", NamaObat);
                    cmd.Parameters.AddWithValue("@HBeli", HBeli);
                    cmd.Parameters.AddWithValue("@HJual", HJual);
                    cmd.Parameters.AddWithValue("@Jumlah", Jumlah);
                    cmd.Parameters.AddWithValue("@TglExp", TglExp);
                    cmd.Parameters.AddWithValue("@Perusahaan", Perusahaan);
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

        public string Delete(int IdObat)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_obat WHERE IdObat=@IdObat", conn))
                {
                    cmd.Parameters.AddWithValue("IdObat", IdObat);
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
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_obat", conn))
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
