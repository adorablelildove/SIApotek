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
using System.Configuration;

namespace SIApotek
{
    public partial class Obat : Form
    {
        static int IdObat;
        public Obat()
        {
            InitializeComponent();
        }
        private void Obat_Load(object sender, EventArgs e)
        {
            comboboxOption();
            CrudObat load = new CrudObat();
            dataGridViewObat.DataSource = load.ReadAll();
        }

        public void comboboxOption()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;
            MySqlDataReader rdr;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_supplier", conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nama", typeof(string));
                    rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    comboBoxPerusahaan.ValueMember = "Nama";
                    comboBoxPerusahaan.DataSource = dt;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string response;
            CrudObat obat = new CrudObat();
            response = obat.Insert(NamaObat: bunifuMaterialTextboxNamaObat.Text, HBeli: Int32.Parse(bunifuMaterialTextboxHargaBeli.Text), HJual: Int32.Parse(bunifuMaterialTextboxHargaJual.Text), Jumlah: Int32.Parse(bunifuMaterialTextboxJumlah.Text), TglExp: dateTimePickerTglExp.Text, Perusahaan: comboBoxPerusahaan.Text);
            if (response == null) MessageBox.Show("Data Berhasil Ditambahkan!");
            else MessageBox.Show(response);

            FormProcess();
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            CrudObat data = new CrudObat();
            dataGridViewObat.DataSource = data.ReadAll();
        }

        private void dataGridViewObat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dataGridViewObat.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewObat.Rows[selectedRowIndex];
            bunifuMaterialTextboxNamaObat.Text = Convert.ToString(selectedRow.Cells["NamaObat"].Value);
            bunifuMaterialTextboxHargaBeli.Text = Convert.ToString(selectedRow.Cells["HBeli"].Value);
            bunifuMaterialTextboxHargaJual.Text = Convert.ToString(selectedRow.Cells["HJual"].Value);
            bunifuMaterialTextboxJumlah.Text = Convert.ToString(selectedRow.Cells["Jumlah"].Value);
            dateTimePickerTglExp.Text = Convert.ToString(selectedRow.Cells["TglExp"].Value);
            comboBoxPerusahaan.Text = Convert.ToString(selectedRow.Cells["Perusahaan"].Value);
            IdObat = Convert.ToInt32(selectedRow.Cells["IdObat"].Value);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string response;
            CrudObat obat = new CrudObat();
            response = obat.Update(IdObat:IdObat, NamaObat: bunifuMaterialTextboxNamaObat.Text, HBeli: Int32.Parse(bunifuMaterialTextboxHargaBeli.Text), HJual: Int32.Parse(bunifuMaterialTextboxHargaJual.Text), Jumlah: Int32.Parse(bunifuMaterialTextboxJumlah.Text), TglExp: dateTimePickerTglExp.Text, Perusahaan: comboBoxPerusahaan.Text);
            if (response == null) MessageBox.Show("Data Berhasil Diubah!");
            else MessageBox.Show(response);

            FormProcess();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string response;
            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CrudObat obat = new CrudObat();
                response = obat.Delete(IdObat: IdObat);
                if (response == null) MessageBox.Show("Data Berhasil Dihapus!");
                else MessageBox.Show(response);

                CrudObat load = new CrudObat();
                dataGridViewObat.DataSource = load.ReadAll();

            }
            else if (dialogResult == DialogResult.No){
                //do nothing
            }
            ResetForm();
        }

        public void ResetForm()
        {
            DateTime now = DateTime.Now;
            bunifuMaterialTextboxNamaObat.Text = "Nama Obat";
            bunifuMaterialTextboxHargaBeli.Text = "Harga Beli";
            bunifuMaterialTextboxHargaJual.Text = "Harga Jual";
            bunifuMaterialTextboxJumlah.Text = "Jumlah";
            dateTimePickerTglExp.Text = Convert.ToString(now);
            comboBoxPerusahaan.Text = "";
        }

        private void FormProcess()
        {
            if (bunifuMaterialTextboxNamaObat.Text == "" || bunifuMaterialTextboxHargaBeli.Text == "" || bunifuMaterialTextboxHargaJual.Text == "" || bunifuMaterialTextboxJumlah.Text == "" || comboBoxPerusahaan.Text == "")
            {
                MessageBox.Show("Data yang dimasukkan tidak boleh kosong.");
            }
            else
            {
                CrudObat load = new CrudObat();
                dataGridViewObat.DataSource = load.ReadAll();
                ResetForm();
            }
        }

            private void bunifuMaterialTextboxNamaObat_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextboxNamaObat.Text = "";
        }

        private void bunifuMaterialTextboxHargaBeli_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextboxHargaBeli.Text = "";
            if(bunifuMaterialTextboxNamaObat.Text == "Nama Obat" || bunifuMaterialTextboxNamaObat.Text == "")
            {
                MessageBox.Show("Isi Nama Obat terlebih dahulu.");
                bunifuMaterialTextboxHargaBeli.Text = "Harga Beli";
            }
        }

        private void bunifuMaterialTextboxHargaJual_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextboxHargaJual.Text = "";
            if (bunifuMaterialTextboxHargaBeli.Text == "Harga Beli" || bunifuMaterialTextboxHargaBeli.Text == "")
            {
                MessageBox.Show("Isi Harga Beli terlebih dahulu.");
                bunifuMaterialTextboxHargaJual.Text = "Harga Jual";
            }
        }

        private void bunifuMaterialTextboxJumlah_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextboxJumlah.Text = "";
            if (bunifuMaterialTextboxHargaJual.Text == "Harga Jual" || bunifuMaterialTextboxHargaJual.Text == "")
            {
                MessageBox.Show("Isi Harga Jual terlebih dahulu.");
                bunifuMaterialTextboxJumlah.Text = "Jumlah";
            }
        }

        private void bunifuMaterialTextboxHargaBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
