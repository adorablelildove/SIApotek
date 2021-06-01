
namespace SIApotek
{
    partial class Pegawai
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTglLahir = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelStokObat = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxNama = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridViewPegawai = new System.Windows.Forms.DataGridView();
            this.bunifuMaterialTextboxGaji = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextboxNoTelp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.richTextBoxAlamat = new System.Windows.Forms.RichTextBox();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.bunifuMaterialTextboxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleName = "btnLoad";
            this.btnLoad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(349, 30);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 27);
            this.btnLoad.TabIndex = 30;
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
            this.buttonDelete.Location = new System.Drawing.Point(235, 340);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 30);
            this.buttonDelete.TabIndex = 29;
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
            this.buttonUpdate.Location = new System.Drawing.Point(135, 340);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 30);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "Alamat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tanggal Lahir :";
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(24, 209);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerTglLahir.TabIndex = 23;
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
            this.buttonAdd.Location = new System.Drawing.Point(34, 340);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 30);
            this.buttonAdd.TabIndex = 22;
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
            this.labelStokObat.Location = new System.Drawing.Point(79, 20);
            this.labelStokObat.Name = "labelStokObat";
            this.labelStokObat.Size = new System.Drawing.Size(160, 23);
            this.labelStokObat.TabIndex = 21;
            this.labelStokObat.Text = "Data Pegawai";
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
            this.bunifuMaterialTextboxNama.Location = new System.Drawing.Point(24, 86);
            this.bunifuMaterialTextboxNama.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxNama.Name = "bunifuMaterialTextboxNama";
            this.bunifuMaterialTextboxNama.Size = new System.Drawing.Size(141, 31);
            this.bunifuMaterialTextboxNama.TabIndex = 17;
            this.bunifuMaterialTextboxNama.Text = "Nama Pegawai";
            this.bunifuMaterialTextboxNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxNama.Enter += new System.EventHandler(this.bunifuMaterialTextboxNama_Enter);
            // 
            // dataGridViewPegawai
            // 
            this.dataGridViewPegawai.AccessibleName = "dataGridViewPegawai";
            this.dataGridViewPegawai.AllowUserToOrderColumns = true;
            this.dataGridViewPegawai.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPegawai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPegawai.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewPegawai.Location = new System.Drawing.Point(349, 63);
            this.dataGridViewPegawai.Name = "dataGridViewPegawai";
            this.dataGridViewPegawai.Size = new System.Drawing.Size(635, 366);
            this.dataGridViewPegawai.TabIndex = 16;
            this.dataGridViewPegawai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPegawai_CellClick);
            // 
            // bunifuMaterialTextboxGaji
            // 
            this.bunifuMaterialTextboxGaji.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxGaji.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxGaji.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxGaji.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxGaji.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxGaji.HintText = "";
            this.bunifuMaterialTextboxGaji.isPassword = false;
            this.bunifuMaterialTextboxGaji.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxGaji.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxGaji.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxGaji.LineThickness = 3;
            this.bunifuMaterialTextboxGaji.Location = new System.Drawing.Point(188, 138);
            this.bunifuMaterialTextboxGaji.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxGaji.Name = "bunifuMaterialTextboxGaji";
            this.bunifuMaterialTextboxGaji.Size = new System.Drawing.Size(141, 31);
            this.bunifuMaterialTextboxGaji.TabIndex = 32;
            this.bunifuMaterialTextboxGaji.Text = "Gaji";
            this.bunifuMaterialTextboxGaji.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxGaji.Enter += new System.EventHandler(this.bunifuMaterialTextboxGaji_Enter);
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
            this.bunifuMaterialTextboxNoTelp.Location = new System.Drawing.Point(24, 138);
            this.bunifuMaterialTextboxNoTelp.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxNoTelp.Name = "bunifuMaterialTextboxNoTelp";
            this.bunifuMaterialTextboxNoTelp.Size = new System.Drawing.Size(141, 31);
            this.bunifuMaterialTextboxNoTelp.TabIndex = 33;
            this.bunifuMaterialTextboxNoTelp.Text = "No Telepon";
            this.bunifuMaterialTextboxNoTelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxNoTelp.Enter += new System.EventHandler(this.bunifuMaterialTextboxNoTelp_Enter);
            // 
            // richTextBoxAlamat
            // 
            this.richTextBoxAlamat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAlamat.Location = new System.Drawing.Point(24, 268);
            this.richTextBoxAlamat.Name = "richTextBoxAlamat";
            this.richTextBoxAlamat.Size = new System.Drawing.Size(305, 54);
            this.richTextBoxAlamat.TabIndex = 34;
            this.richTextBoxAlamat.Text = "";
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
            this.buttonKembali.Location = new System.Drawing.Point(34, 377);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(0);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(82, 30);
            this.buttonKembali.TabIndex = 35;
            this.buttonKembali.Text = "< Back";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // bunifuMaterialTextboxUsername
            // 
            this.bunifuMaterialTextboxUsername.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxUsername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxUsername.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxUsername.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxUsername.HintText = "";
            this.bunifuMaterialTextboxUsername.isPassword = false;
            this.bunifuMaterialTextboxUsername.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxUsername.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxUsername.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxUsername.LineThickness = 3;
            this.bunifuMaterialTextboxUsername.Location = new System.Drawing.Point(188, 189);
            this.bunifuMaterialTextboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxUsername.Name = "bunifuMaterialTextboxUsername";
            this.bunifuMaterialTextboxUsername.Size = new System.Drawing.Size(141, 31);
            this.bunifuMaterialTextboxUsername.TabIndex = 37;
            this.bunifuMaterialTextboxUsername.Text = "Username";
            this.bunifuMaterialTextboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxUsername.Enter += new System.EventHandler(this.bunifuMaterialTextboxUsername_Enter);
            // 
            // bunifuMaterialTextboxPassword
            // 
            this.bunifuMaterialTextboxPassword.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxPassword.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxPassword.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxPassword.HintText = "";
            this.bunifuMaterialTextboxPassword.isPassword = false;
            this.bunifuMaterialTextboxPassword.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxPassword.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxPassword.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextboxPassword.LineThickness = 3;
            this.bunifuMaterialTextboxPassword.Location = new System.Drawing.Point(188, 86);
            this.bunifuMaterialTextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxPassword.Name = "bunifuMaterialTextboxPassword";
            this.bunifuMaterialTextboxPassword.Size = new System.Drawing.Size(141, 31);
            this.bunifuMaterialTextboxPassword.TabIndex = 38;
            this.bunifuMaterialTextboxPassword.Text = "Password";
            this.bunifuMaterialTextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxPassword.Enter += new System.EventHandler(this.bunifuMaterialTextboxPassword_Enter);
            // 
            // Pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 445);
            this.Controls.Add(this.bunifuMaterialTextboxPassword);
            this.Controls.Add(this.bunifuMaterialTextboxUsername);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.richTextBoxAlamat);
            this.Controls.Add(this.bunifuMaterialTextboxNoTelp);
            this.Controls.Add(this.bunifuMaterialTextboxGaji);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerTglLahir);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelStokObat);
            this.Controls.Add(this.bunifuMaterialTextboxNama);
            this.Controls.Add(this.dataGridViewPegawai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pegawai";
            this.Load += new System.EventHandler(this.Pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPegawai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglLahir;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelStokObat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxNama;
        private System.Windows.Forms.DataGridView dataGridViewPegawai;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxGaji;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxNoTelp;
        private System.Windows.Forms.RichTextBox richTextBoxAlamat;
        private System.Windows.Forms.Button buttonKembali;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxPassword;
    }
}