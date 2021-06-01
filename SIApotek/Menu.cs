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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Obat obat = new Obat();
            obat.Show();
            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
            this.Hide();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Pembayaran pembayaran = new Pembayaran();
            pembayaran.Show();
            this.Hide();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            pegawai.Show();
            this.Hide();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}
