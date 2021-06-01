using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIApotek
{
    public partial class Pegawai : Form
    {
        static int IdPegawai;
        public Pegawai()
        {
            InitializeComponent();
        }

        private void Pegawai_Load(object sender, EventArgs e)
        {
            CrudPegawai load = new CrudPegawai();
            dataGridViewPegawai.DataSource = load.ReadAll();
        }

        private void bunifuMaterialTextboxNama_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextboxNama.Text == "Nama Pegawai")
            {
                bunifuMaterialTextboxNama.Text = "";
            }
        }

        private void bunifuMaterialTextboxNoTelp_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextboxNoTelp.Text == "No Telepon")
            {
                bunifuMaterialTextboxNoTelp.Text = "";
            }
        }

        private void bunifuMaterialTextboxGaji_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextboxGaji.Text == "Gaji")
            {
                bunifuMaterialTextboxGaji.Text = "";
            }
        }

        private void bunifuMaterialTextboxUsername_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextboxUsername.Text == "Username")
            {
                bunifuMaterialTextboxUsername.Text = "";
            }
        }

        private void bunifuMaterialTextboxPassword_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextboxPassword.Text == "Password")
            {
                bunifuMaterialTextboxPassword.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string response;
            CrudPegawai pegawai = new CrudPegawai();
            response = pegawai.Insert(Username: bunifuMaterialTextboxUsername.Text, Password: bunifuMaterialTextboxPassword.Text, Nama: bunifuMaterialTextboxNama.Text, TglLahir: dateTimePickerTglLahir.Text, NoTelp: bunifuMaterialTextboxNoTelp.Text, Alamat: richTextBoxAlamat.Text, Gaji: Int32.Parse(bunifuMaterialTextboxGaji.Text));
            if (response == null) MessageBox.Show("Data Berhasil Ditambahkan!");
            else MessageBox.Show(response);

            FormProcess();
        }

        private void dataGridViewPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dataGridViewPegawai.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPegawai.Rows[selectedRowIndex];
            bunifuMaterialTextboxUsername.Text = Convert.ToString(selectedRow.Cells["Username"].Value);
            bunifuMaterialTextboxPassword.Text = Convert.ToString(selectedRow.Cells["Password"].Value);
            bunifuMaterialTextboxNama.Text = Convert.ToString(selectedRow.Cells["Nama"].Value);
            dateTimePickerTglLahir.Text = Convert.ToString(selectedRow.Cells["TglLahir"].Value);
            bunifuMaterialTextboxNoTelp.Text = Convert.ToString(selectedRow.Cells["NoTelp"].Value);
            richTextBoxAlamat.Text = Convert.ToString(selectedRow.Cells["Alamat"].Value);
            bunifuMaterialTextboxGaji.Text = Convert.ToString(selectedRow.Cells["Gaji"].Value);
            IdPegawai = Convert.ToInt32(selectedRow.Cells["IdPegawai"].Value);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string response;
            CrudPegawai pegawai = new CrudPegawai();
            response = pegawai.Update(IdPegawai: IdPegawai, Username: bunifuMaterialTextboxUsername.Text, Password: bunifuMaterialTextboxPassword.Text, Nama: bunifuMaterialTextboxNama.Text, TglLahir: dateTimePickerTglLahir.Text, NoTelp: bunifuMaterialTextboxNoTelp.Text, Alamat: richTextBoxAlamat.Text, Gaji: Int32.Parse(bunifuMaterialTextboxGaji.Text));
            if (response == null) MessageBox.Show("Data Berhasil Diubah!");
            else MessageBox.Show(response);

            FormProcess();
        }

        public void ResetForm()
        {
            DateTime now = DateTime.Now;
            bunifuMaterialTextboxNama.Text = "Nama Pegawai";
            bunifuMaterialTextboxUsername.Text = "Username";
            bunifuMaterialTextboxPassword.Text = "Password";
            bunifuMaterialTextboxNoTelp.Text = "No Telepon";
            bunifuMaterialTextboxGaji.Text = "Gaji";
            dateTimePickerTglLahir.Text = Convert.ToString(now);
            richTextBoxAlamat.Text = "";
        }

        private void FormProcess()
        {
            if (bunifuMaterialTextboxNama.Text == "" || bunifuMaterialTextboxUsername.Text == "" || bunifuMaterialTextboxPassword.Text == "" || bunifuMaterialTextboxNoTelp.Text == "" || bunifuMaterialTextboxGaji.Text == "" || richTextBoxAlamat.Text == "")
            {
                MessageBox.Show("Data yang dimasukkan tidak boleh kosong.");
            }
            else
            {
                CrudPegawai load = new CrudPegawai();
                dataGridViewPegawai.DataSource = load.ReadAll();
                ResetForm();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string response;
            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CrudPegawai pegawai = new CrudPegawai();
                response = pegawai.Delete(IdPegawai: IdPegawai);
                if (response == null) MessageBox.Show("Data Berhasil Dihapus!");
                else MessageBox.Show(response);

                CrudPegawai load = new CrudPegawai();
                dataGridViewPegawai.DataSource = load.ReadAll();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            ResetForm();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CrudPegawai data = new CrudPegawai();
            dataGridViewPegawai.DataSource = data.ReadAll();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
