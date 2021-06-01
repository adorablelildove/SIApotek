using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using System.Configuration;

namespace SIApotek
{
    public partial class Login : Form
    {
        private String ConnString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextboxUsername_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextboxUsername.Text = "";
        }

        private void bunifuMaterialTextboxPassword_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextboxPassword.Text = "";
            if (bunifuMaterialTextboxUsername.Text == "Username" || bunifuMaterialTextboxUsername.Text == "")
            {
                MessageBox.Show("Isi Username terlebih dahulu.");
                bunifuMaterialTextboxPassword.Text = "Password";
            }
        }

        public void check()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_pegawai WHERE Username=@Username AND Password=@Password", conn))
                {
                    cmd.Parameters.AddWithValue("Username", bunifuMaterialTextboxUsername.Text);
                    cmd.Parameters.AddWithValue("Password", bunifuMaterialTextboxPassword.Text);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password atau Username salah.");
                        bunifuMaterialTextboxUsername.Text = "Username";
                        bunifuMaterialTextboxPassword.Text = "Password";
                    }
                    conn.Close();
                }
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            check();
        }
    }
}
