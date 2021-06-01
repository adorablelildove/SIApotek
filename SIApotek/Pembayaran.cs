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
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;
using MySqlDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;
using System.Configuration;

namespace SIApotek
{

    public partial class Pembayaran : Form
    {
        int x, hjual;
        public Pembayaran()
        {
            InitializeComponent();
        }

        private String ConnString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            comboboxOption();
            button1.Visible = false;
        }

        public void comboboxOption()
        {
            MySqlDataReader rdr;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_obat", conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("NamaObat", typeof(string));
                    rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    comboBoxPilih.ValueMember = "NamaObat";
                    comboBoxPilih.DataSource = dt;
                }
            }
        }

        public void jumlah()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_obat WHERE NamaObat = '" + comboBoxPilih.SelectedValue.ToString() + "'", conn))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            x = Convert.ToInt32(dr["Jumlah"].ToString());
                            hjual = Convert.ToInt32(dr["HJual"].ToString());
                            labelStokTersedia.Text = "Stok tersedia : " + dr["Jumlah"].ToString();
                            labelStokTersedia.Visible = true;
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void comboBoxPilih_SelectedIndexChanged(object sender, EventArgs e)
        {
            jumlah();
        }

        public void updateJumlah()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                int newJum = x - Convert.ToInt32(numericUpDownJumlah.Value);
                using (MySqlCommand cmd = new MySqlCommand("UPDATE tb_obat SET  Jumlah = " + newJum + " WHERE NamaObat='" + comboBoxPilih.SelectedValue.ToString() + "';", conn))
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDownJumlah.Text) > x)
            {
                MessageBox.Show("Jumlah melebihi stok yang tersedia.");
            }
            else
            {
                int total = Convert.ToInt32(numericUpDownJumlah.Value) * hjual;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewObat);
                newRow.Cells[0].Value = comboBoxPilih.SelectedValue.ToString();
                newRow.Cells[1].Value = numericUpDownJumlah.Value;
                newRow.Cells[2].Value = hjual;
                newRow.Cells[3].Value = hjual * Convert.ToInt32(numericUpDownJumlah.Value);
                dataGridViewObat.Rows.Add(newRow);
                updateJumlah();
                int GrdTotal = 0;
                for (int i = 0; i < dataGridViewObat.Rows.Count; ++i)
                {
                    GrdTotal += Convert.ToInt32(dataGridViewObat.Rows[i].Cells[3].Value);
                }
                labelTotal.Text = "Total Pembayaran : Rp " + GrdTotal;
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("Nama Obat", typeof(String));
            dt.Columns.Add("Jumlah", typeof(String));
            dt.Columns.Add("Harga Satuan", typeof(String));
            dt.Columns.Add("Total", typeof(Int32));
            dt.Columns.Add("Total Pembayaran", typeof(Int32));

            int GrdTotal = 0;
            for (int i = 0; i < dataGridViewObat.Rows.Count; ++i)
            {
                GrdTotal += Convert.ToInt32(dataGridViewObat.Rows[i].Cells[3].Value);
            }

            foreach (DataGridViewRow dgv in dataGridViewObat.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, GrdTotal);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("Sample.xml");

            crystalReportViewer1.Visible = true;
            button1.Visible = true;
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
            button1.Visible = false;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
