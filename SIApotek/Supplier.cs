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
    public partial class Supplier : Form
    {
        static int IdSupplier;
        public Supplier()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextboxNama_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxNama.Text == "Nama Perusahaan")
            {
                bunifuMaterialTextboxNama.Text = "";
            }
        }

        private void bunifuMaterialTextboxNoTelp_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxNoTelp.Text == "No Telepon")
            {
                bunifuMaterialTextboxNoTelp.Text = "";
            }
        }

        private void bunifuMaterialTextboxFax_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxFax.Text == "Fax")
            {
                bunifuMaterialTextboxFax.Text = "";
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            CrudSupplier load = new CrudSupplier();
            dataGridViewSupplier.DataSource = load.ReadAll();
        }

        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dataGridViewSupplier.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewSupplier.Rows[selectedRowIndex];
            bunifuMaterialTextboxNama.Text = Convert.ToString(selectedRow.Cells["Nama"].Value);
            bunifuMaterialTextboxNoTelp.Text = Convert.ToString(selectedRow.Cells["NoTelp"].Value);
            bunifuMaterialTextboxFax.Text = Convert.ToString(selectedRow.Cells["Fax"].Value);
            richTextBoxAlamat.Text = Convert.ToString(selectedRow.Cells["Alamat"].Value);
            IdSupplier = Convert.ToInt32(selectedRow.Cells["IdSupplier"].Value);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string response;
            CrudSupplier supplier = new CrudSupplier();
            response = supplier.Insert(Nama: bunifuMaterialTextboxNama.Text, NoTelp: bunifuMaterialTextboxNoTelp.Text, Fax: bunifuMaterialTextboxFax.Text, Alamat: richTextBoxAlamat.Text);
            if (response == null) MessageBox.Show("Data Berhasil Ditambahkan!");
            else MessageBox.Show(response);

            FormProcess();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string response;
            CrudSupplier supplier = new CrudSupplier();
            response = supplier.Update(IdSupplier: IdSupplier, Nama: bunifuMaterialTextboxNama.Text, NoTelp: bunifuMaterialTextboxNoTelp.Text, Fax: bunifuMaterialTextboxFax.Text, Alamat: richTextBoxAlamat.Text);
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
                CrudSupplier supplier = new CrudSupplier();
                response = supplier.Delete(IdSupplier: IdSupplier);
                if (response == null) MessageBox.Show("Data Berhasil Dihapus!");
                else MessageBox.Show(response);

                CrudSupplier load = new CrudSupplier();
                dataGridViewSupplier.DataSource = load.ReadAll();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            ResetForm();
        }

        public void ResetForm()
        {
            bunifuMaterialTextboxNama.Text = "Nama";
            bunifuMaterialTextboxNoTelp.Text = "Nomor Telepon";
            bunifuMaterialTextboxFax.Text = "Fax";
            richTextBoxAlamat.Text = "";
        }

        private void FormProcess()
        {
            if (bunifuMaterialTextboxNama.Text == "" || bunifuMaterialTextboxNoTelp.Text == "" || bunifuMaterialTextboxFax.Text == "")
            {
                MessageBox.Show("Data yang dimasukkan tidak boleh kosong.");
            }
            else
            {
                CrudSupplier load = new CrudSupplier();
                dataGridViewSupplier.DataSource = load.ReadAll();
                ResetForm();
            }
        }

        private void bunifuMaterialTextboxFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CrudSupplier load = new CrudSupplier();
            dataGridViewSupplier.DataSource = load.ReadAll();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
