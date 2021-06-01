
namespace SIApotek
{
    partial class Supplier
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
            this.buttonKembali = new System.Windows.Forms.Button();
            this.richTextBoxAlamat = new System.Windows.Forms.RichTextBox();
            this.bunifuMaterialTextboxNama = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelStokObat = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxFax = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.bunifuMaterialTextboxNoTelp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
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
            this.buttonKembali.Location = new System.Drawing.Point(25, 334);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(0);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(82, 30);
            this.buttonKembali.TabIndex = 50;
            this.buttonKembali.Text = "< Back";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // richTextBoxAlamat
            // 
            this.richTextBoxAlamat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAlamat.Location = new System.Drawing.Point(15, 224);
            this.richTextBoxAlamat.Name = "richTextBoxAlamat";
            this.richTextBoxAlamat.Size = new System.Drawing.Size(305, 54);
            this.richTextBoxAlamat.TabIndex = 49;
            this.richTextBoxAlamat.Text = "";
            // 
            // bunifuMaterialTextboxNama
            // 
            this.bunifuMaterialTextboxNama.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxNama.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxNama.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNama.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNama.HintText = "";
            this.bunifuMaterialTextboxNama.isPassword = false;
            this.bunifuMaterialTextboxNama.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxNama.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNama.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxNama.LineThickness = 3;
            this.bunifuMaterialTextboxNama.Location = new System.Drawing.Point(15, 88);
            this.bunifuMaterialTextboxNama.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxNama.Name = "bunifuMaterialTextboxNama";
            this.bunifuMaterialTextboxNama.Size = new System.Drawing.Size(141, 31);
            this.bunifuMaterialTextboxNama.TabIndex = 46;
            this.bunifuMaterialTextboxNama.Text = "Nama Perusahaan";
            this.bunifuMaterialTextboxNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxNama.Enter += new System.EventHandler(this.bunifuMaterialTextboxNama_Enter);
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleName = "btnLoad";
            this.btnLoad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(340, 30);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 27);
            this.btnLoad.TabIndex = 45;
            this.btnLoad.Text = "Refresh Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(226, 297);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 30);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 2;
            this.buttonUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(126, 297);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 30);
            this.buttonUpdate.TabIndex = 43;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 42;
            this.label2.Text = "Alamat :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(25, 297);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 30);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelStokObat
            // 
            this.labelStokObat.AutoSize = true;
            this.labelStokObat.BackColor = System.Drawing.Color.DarkGreen;
            this.labelStokObat.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStokObat.ForeColor = System.Drawing.Color.White;
            this.labelStokObat.Location = new System.Drawing.Point(58, 33);
            this.labelStokObat.Name = "labelStokObat";
            this.labelStokObat.Size = new System.Drawing.Size(216, 23);
            this.labelStokObat.TabIndex = 38;
            this.labelStokObat.Text = "Data Supplier Obat";
            // 
            // bunifuMaterialTextboxFax
            // 
            this.bunifuMaterialTextboxFax.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxFax.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxFax.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxFax.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxFax.HintText = "";
            this.bunifuMaterialTextboxFax.isPassword = false;
            this.bunifuMaterialTextboxFax.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxFax.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxFax.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxFax.LineThickness = 3;
            this.bunifuMaterialTextboxFax.Location = new System.Drawing.Point(179, 140);
            this.bunifuMaterialTextboxFax.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxFax.Name = "bunifuMaterialTextboxFax";
            this.bunifuMaterialTextboxFax.Size = new System.Drawing.Size(141, 31);
            this.bunifuMaterialTextboxFax.TabIndex = 37;
            this.bunifuMaterialTextboxFax.Text = "Fax";
            this.bunifuMaterialTextboxFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxFax.Enter += new System.EventHandler(this.bunifuMaterialTextboxFax_Enter);
            this.bunifuMaterialTextboxFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextboxFax_KeyPress);
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.AccessibleName = "dataGridViewObat";
            this.dataGridViewSupplier.AllowUserToOrderColumns = true;
            this.dataGridViewSupplier.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(340, 63);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.Size = new System.Drawing.Size(563, 337);
            this.dataGridViewSupplier.TabIndex = 36;
            this.dataGridViewSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellClick);
            // 
            // bunifuMaterialTextboxNoTelp
            // 
            this.bunifuMaterialTextboxNoTelp.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxNoTelp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxNoTelp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxNoTelp.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNoTelp.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNoTelp.HintText = "";
            this.bunifuMaterialTextboxNoTelp.isPassword = false;
            this.bunifuMaterialTextboxNoTelp.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxNoTelp.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxNoTelp.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxNoTelp.LineThickness = 3;
            this.bunifuMaterialTextboxNoTelp.Location = new System.Drawing.Point(15, 140);
            this.bunifuMaterialTextboxNoTelp.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxNoTelp.Name = "bunifuMaterialTextboxNoTelp";
            this.bunifuMaterialTextboxNoTelp.Size = new System.Drawing.Size(141, 31);
            this.bunifuMaterialTextboxNoTelp.TabIndex = 48;
            this.bunifuMaterialTextboxNoTelp.Text = "No Telepon";
            this.bunifuMaterialTextboxNoTelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxNoTelp.Enter += new System.EventHandler(this.bunifuMaterialTextboxNoTelp_Enter);
            this.bunifuMaterialTextboxNoTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextboxFax_KeyPress);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(915, 412);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.richTextBoxAlamat);
            this.Controls.Add(this.bunifuMaterialTextboxNoTelp);
            this.Controls.Add(this.bunifuMaterialTextboxNama);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelStokObat);
            this.Controls.Add(this.bunifuMaterialTextboxFax);
            this.Controls.Add(this.dataGridViewSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.RichTextBox richTextBoxAlamat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxNama;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelStokObat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxFax;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxNoTelp;
    }
}