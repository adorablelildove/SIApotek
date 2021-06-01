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
    class CrudPegawai
    {
        private String ConnString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;

        public string Insert(string Username, string Password, string Nama, string TglLahir, string NoTelp, string Alamat, int Gaji)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_pegawai (Username, Password, Nama, TglLahir, NoTelp, Alamat, Gaji)" + "VALUES (@Username, @Password, @Nama, @TglLahir, @NoTelp, @Alamat, @Gaji)", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Nama", Nama);
                    cmd.Parameters.AddWithValue("@TglLahir", TglLahir);
                    cmd.Parameters.AddWithValue("@NoTelp", NoTelp);
                    cmd.Parameters.AddWithValue("@Alamat", Alamat);
                    cmd.Parameters.AddWithValue("@Gaji", Gaji);
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

        public string Update(int IdPegawai, string Username, string Password, string Nama, string TglLahir, string NoTelp, string Alamat, int Gaji)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE tb_pegawai SET Username=@Username, Password=@Password, Nama=@Nama, TglLahir=@TglLahir, NoTelp=@NoTelp, Alamat=@Alamat, Gaji=@Gaji WHERE IdPegawai=@IdPegawai", conn))
                {
                    cmd.Parameters.AddWithValue("IdPegawai", IdPegawai);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Nama", Nama);
                    cmd.Parameters.AddWithValue("@TglLahir", TglLahir);
                    cmd.Parameters.AddWithValue("@NoTelp", NoTelp);
                    cmd.Parameters.AddWithValue("@Alamat", Alamat);
                    cmd.Parameters.AddWithValue("@Gaji", Gaji);
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

        public string Delete(int IdPegawai)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_pegawai WHERE IdPegawai=@IdPegawai", conn))
                {
                    cmd.Parameters.AddWithValue("IdPegawai", IdPegawai);
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
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_pegawai", conn))
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
