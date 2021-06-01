
namespace SIApotek
{
    partial class Pembayaran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStokTersedia = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelFormPembayaran = new System.Windows.Forms.Label();
            this.dataGridViewObat = new System.Windows.Forms.DataGridView();
            this.NamaObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownJumlah = new System.Windows.Forms.NumericUpDown();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBoxPilih = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.Red;
            this.buttonKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKembali.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonKembali.FlatAppearance.BorderSize = 2;
            this.buttonKembali.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.buttonKembali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKembali.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.ForeColor = System.Drawing.Color.White;
            this.buttonKembali.Location = new System.Drawing.Point(23, 321);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(0);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(82, 30);
            this.buttonKembali.TabIndex = 28;
            this.buttonKembali.Text = "< Back";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCetak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCetak.FlatAppearance.BorderSize = 2;
            this.buttonCetak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonCetak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCetak.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.White;
            this.buttonCetak.Location = new System.Drawing.Point(312, 321);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(82, 30);
            this.buttonCetak.TabIndex = 27;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "Jumlah :";
            // 
            // labelStokTersedia
            // 
            this.labelStokTersedia.AutoSize = true;
            this.labelStokTersedia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStokTersedia.ForeColor = System.Drawing.Color.DarkGray;
            this.labelStokTersedia.Location = new System.Drawing.Point(21, 151);
            this.labelStokTersedia.Name = "labelStokTersedia";
            this.labelStokTersedia.Size = new System.Drawing.Size(100, 14);
            this.labelStokTersedia.TabIndex = 24;
            this.labelStokTersedia.Text = "Stok tersedia :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(24, 249);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 30);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelFormPembayaran
            // 
            this.labelFormPembayaran.AutoSize = true;
            this.labelFormPembayaran.BackColor = System.Drawing.Color.DarkGreen;
            this.labelFormPembayaran.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormPembayaran.ForeColor = System.Drawing.Color.White;
            this.labelFormPembayaran.Location = new System.Drawing.Point(46, 33);
            this.labelFormPembayaran.Name = "labelFormPembayaran";
            this.labelFormPembayaran.Size = new System.Drawing.Size(205, 23);
            this.labelFormPembayaran.TabIndex = 21;
            this.labelFormPembayaran.Text = "Form Pembayaran";
            // 
            // dataGridViewObat
            // 
            this.dataGridViewObat.AccessibleName = "dataGridViewObat";
            this.dataGridViewObat.AllowUserToOrderColumns = true;
            this.dataGridViewObat.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewObat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaObat,
            this.Qty,
            this.HargaSatuan,
            this.TotalHarga});
            this.dataGridViewObat.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewObat.Location = new System.Drawing.Point(310, 77);
            this.dataGridViewObat.Name = "dataGridViewObat";
            this.dataGridViewObat.Size = new System.Drawing.Size(444, 212);
            this.dataGridViewObat.TabIndex = 16;
            // 
            // NamaObat
            // 
            this.NamaObat.HeaderText = "Nama Obat";
            this.NamaObat.Name = "NamaObat";
            this.NamaObat.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Jumlah";
            this.Qty.Name = "Qty";
            // 
            // HargaSatuan
            // 
            this.HargaSatuan.HeaderText = "Harga Satuan";
            this.HargaSatuan.Name = "HargaSatuan";
            this.HargaSatuan.ReadOnly = true;
            // 
            // TotalHarga
            // 
            this.TotalHarga.HeaderText = "Total Harga";
            this.TotalHarga.Name = "TotalHarga";
            this.TotalHarga.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "Pilih Obat :";
            // 
            // numericUpDownJumlah
            // 
            this.numericUpDownJumlah.BackColor = System.Drawing.Color.DarkGreen;
            this.numericUpDownJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownJumlah.ForeColor = System.Drawing.SystemColors.Info;
            this.numericUpDownJumlah.Location = new System.Drawing.Point(24, 207);
            this.numericUpDownJumlah.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownJumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownJumlah.Name = "numericUpDownJumlah";
            this.numericUpDownJumlah.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownJumlah.TabIndex = 33;
            this.numericUpDownJumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.DarkGreen;
            this.labelTotal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(306, 292);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(196, 18);
            this.labelTotal.TabIndex = 34;
            this.labelTotal.Text = "Total Pembayaran : Rp";
            // 
            // comboBoxPilih
            // 
            this.comboBoxPilih.BackColor = System.Drawing.Color.DarkGreen;
            this.comboBoxPilih.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxPilih.FormattingEnabled = true;
            this.comboBoxPilih.Location = new System.Drawing.Point(24, 117);
            this.comboBoxPilih.Name = "comboBoxPilih";
            this.comboBoxPilih.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPilih.TabIndex = 35;
            this.comboBoxPilih.SelectedIndexChanged += new System.EventHandler(this.comboBoxPilih_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(771, 362);
            this.crystalReportViewer1.TabIndex = 36;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 20);
            this.button1.TabIndex = 37;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(775, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.comboBoxPilih);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.numericUpDownJumlah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStokTersedia);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFormPembayaran);
            this.Controls.Add(this.dataGridViewObat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.Pembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStokTersedia;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelFormPembayaran;
        private System.Windows.Forms.DataGridView dataGridViewObat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownJumlah;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxPilih;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHarga;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
    }
}