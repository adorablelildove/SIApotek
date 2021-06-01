
namespace SIApotek
{
    partial class Obat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuMaterialTextboxNamaObat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextboxHargaBeli = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextboxHargaJual = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextboxJumlah = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridViewObat = new System.Windows.Forms.DataGridView();
            this.labelStokObat = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerTglExp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboBoxPerusahaan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObat)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuMaterialTextboxNamaObat
            // 
            this.bunifuMaterialTextboxNamaObat.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxNamaObat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxNamaObat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxNamaObat.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNamaObat.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNamaObat.HintText = "";
            this.bunifuMaterialTextboxNamaObat.isPassword = false;
            this.bunifuMaterialTextboxNamaObat.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxNamaObat.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNamaObat.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxNamaObat.LineThickness = 3;
            this.bunifuMaterialTextboxNamaObat.Location = new System.Drawing.Point(13, 65);
            this.bunifuMaterialTextboxNamaObat.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxNamaObat.Name = "bunifuMaterialTextboxNamaObat";
            this.bunifuMaterialTextboxNamaObat.Size = new System.Drawing.Size(174, 31);
            this.bunifuMaterialTextboxNamaObat.TabIndex = 2;
            this.bunifuMaterialTextboxNamaObat.Text = "Nama Obat";
            this.bunifuMaterialTextboxNamaObat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxNamaObat.Enter += new System.EventHandler(this.bunifuMaterialTextboxNamaObat_Enter);
            // 
            // bunifuMaterialTextboxHargaBeli
            // 
            this.bunifuMaterialTextboxHargaBeli.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxHargaBeli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxHargaBeli.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxHargaBeli.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxHargaBeli.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxHargaBeli.HintText = "";
            this.bunifuMaterialTextboxHargaBeli.isPassword = false;
            this.bunifuMaterialTextboxHargaBeli.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxHargaBeli.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxHargaBeli.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxHargaBeli.LineThickness = 3;
            this.bunifuMaterialTextboxHargaBeli.Location = new System.Drawing.Point(13, 108);
            this.bunifuMaterialTextboxHargaBeli.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxHargaBeli.Name = "bunifuMaterialTextboxHargaBeli";
            this.bunifuMaterialTextboxHargaBeli.Size = new System.Drawing.Size(174, 31);
            this.bunifuMaterialTextboxHargaBeli.TabIndex = 3;
            this.bunifuMaterialTextboxHargaBeli.Text = "Harga Beli";
            this.bunifuMaterialTextboxHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxHargaBeli.Enter += new System.EventHandler(this.bunifuMaterialTextboxHargaBeli_Enter);
            this.bunifuMaterialTextboxHargaBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextboxHargaBeli_KeyPress);
            // 
            // bunifuMaterialTextboxHargaJual
            // 
            this.bunifuMaterialTextboxHargaJual.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxHargaJual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxHargaJual.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxHargaJual.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxHargaJual.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxHargaJual.HintText = "";
            this.bunifuMaterialTextboxHargaJual.isPassword = false;
            this.bunifuMaterialTextboxHargaJual.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxHargaJual.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxHargaJual.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxHargaJual.LineThickness = 3;
            this.bunifuMaterialTextboxHargaJual.Location = new System.Drawing.Point(13, 152);
            this.bunifuMaterialTextboxHargaJual.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxHargaJual.Name = "bunifuMaterialTextboxHargaJual";
            this.bunifuMaterialTextboxHargaJual.Size = new System.Drawing.Size(174, 31);
            this.bunifuMaterialTextboxHargaJual.TabIndex = 4;
            this.bunifuMaterialTextboxHargaJual.Text = "Harga Jual";
            this.bunifuMaterialTextboxHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxHargaJual.Enter += new System.EventHandler(this.bunifuMaterialTextboxHargaJual_Enter);
            this.bunifuMaterialTextboxHargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextboxHargaBeli_KeyPress);
            // 
            // bunifuMaterialTextboxJumlah
            // 
            this.bunifuMaterialTextboxJumlah.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxJumlah.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxJumlah.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxJumlah.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxJumlah.HintText = "";
            this.bunifuMaterialTextboxJumlah.isPassword = false;
            this.bunifuMaterialTextboxJumlah.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxJumlah.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxJumlah.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxJumlah.LineThickness = 3;
            this.bunifuMaterialTextboxJumlah.Location = new System.Drawing.Point(13, 194);
            this.bunifuMaterialTextboxJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxJumlah.Name = "bunifuMaterialTextboxJumlah";
            this.bunifuMaterialTextboxJumlah.Size = new System.Drawing.Size(174, 31);
            this.bunifuMaterialTextboxJumlah.TabIndex = 5;
            this.bunifuMaterialTextboxJumlah.Text = "Jumlah";
            this.bunifuMaterialTextboxJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxJumlah.Enter += new System.EventHandler(this.bunifuMaterialTextboxJumlah_Enter);
            this.bunifuMaterialTextboxJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextboxHargaBeli_KeyPress);
            // 
            // dataGridViewObat
            // 
            this.dataGridViewObat.AccessibleName = "dataGridViewObat";
            this.dataGridViewObat.AllowUserToOrderColumns = true;
            this.dataGridViewObat.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewObat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObat.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewObat.Location = new System.Drawing.Point(204, 65);
            this.dataGridViewObat.Name = "dataGridViewObat";
            this.dataGridViewObat.Size = new System.Drawing.Size(743, 383);
            this.dataGridViewObat.TabIndex = 1;
            this.dataGridViewObat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObat_CellClick);
            // 
            // labelStokObat
            // 
            this.labelStokObat.AutoSize = true;
            this.labelStokObat.BackColor = System.Drawing.Color.DarkGreen;
            this.labelStokObat.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStokObat.ForeColor = System.Drawing.Color.White;
            this.labelStokObat.Location = new System.Drawing.Point(39, 21);
            this.labelStokObat.Name = "labelStokObat";
            this.labelStokObat.Size = new System.Drawing.Size(117, 23);
            this.labelStokObat.TabIndex = 6;
            this.labelStokObat.Text = "Stok Obat";
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
            this.buttonAdd.Location = new System.Drawing.Point(16, 361);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 30);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePickerTglExp
            // 
            this.dateTimePickerTglExp.Location = new System.Drawing.Point(13, 261);
            this.dateTimePickerTglExp.Name = "dateTimePickerTglExp";
            this.dateTimePickerTglExp.Size = new System.Drawing.Size(174, 20);
            this.dateTimePickerTglExp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tanggal Expired :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Perusahaan :";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 2;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(108, 361);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 30);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(108, 404);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 30);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.buttonKembali.Location = new System.Drawing.Point(16, 404);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(0);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(82, 30);
            this.buttonKembali.TabIndex = 13;
            this.buttonKembali.Text = "< Back";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleName = "btnLoad";
            this.btnLoad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(204, 35);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 27);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Refresh Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // comboBoxPerusahaan
            // 
            this.comboBoxPerusahaan.BackColor = System.Drawing.Color.DarkGreen;
            this.comboBoxPerusahaan.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxPerusahaan.FormattingEnabled = true;
            this.comboBoxPerusahaan.Location = new System.Drawing.Point(13, 310);
            this.comboBoxPerusahaan.Name = "comboBoxPerusahaan";
            this.comboBoxPerusahaan.Size = new System.Drawing.Size(174, 21);
            this.comboBoxPerusahaan.TabIndex = 36;
            // 
            // Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(961, 460);
            this.Controls.Add(this.comboBoxPerusahaan);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerTglExp);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelStokObat);
            this.Controls.Add(this.bunifuMaterialTextboxJumlah);
            this.Controls.Add(this.bunifuMaterialTextboxHargaJual);
            this.Controls.Add(this.bunifuMaterialTextboxHargaBeli);
            this.Controls.Add(this.bunifuMaterialTextboxNamaObat);
            this.Controls.Add(this.dataGridViewObat);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Obat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Obat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxNamaObat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxHargaBeli;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxHargaJual;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxJumlah;
        private System.Windows.Forms.DataGridView dataGridViewObat;
        private System.Windows.Forms.Label labelStokObat;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox comboBoxPerusahaan;
    }
}