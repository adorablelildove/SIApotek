
namespace SIApotek
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.bunifuMaterialTextboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextboxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.bunifuMaterialTextboxPassword);
            this.panel1.Controls.Add(this.bunifuMaterialTextboxUsername);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 342);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(47, 262);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(208, 44);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // bunifuMaterialTextboxPassword
            // 
            this.bunifuMaterialTextboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxPassword.HintText = "";
            this.bunifuMaterialTextboxPassword.isPassword = true;
            this.bunifuMaterialTextboxPassword.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxPassword.LineIdleColor = System.Drawing.Color.DarkOliveGreen;
            this.bunifuMaterialTextboxPassword.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.bunifuMaterialTextboxPassword.LineThickness = 3;
            this.bunifuMaterialTextboxPassword.Location = new System.Drawing.Point(47, 183);
            this.bunifuMaterialTextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxPassword.Name = "bunifuMaterialTextboxPassword";
            this.bunifuMaterialTextboxPassword.Size = new System.Drawing.Size(208, 33);
            this.bunifuMaterialTextboxPassword.TabIndex = 2;
            this.bunifuMaterialTextboxPassword.Text = "Password";
            this.bunifuMaterialTextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxPassword.Enter += new System.EventHandler(this.bunifuMaterialTextboxPassword_Enter);
            // 
            // bunifuMaterialTextboxUsername
            // 
            this.bunifuMaterialTextboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxUsername.HintText = "";
            this.bunifuMaterialTextboxUsername.isPassword = false;
            this.bunifuMaterialTextboxUsername.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.bunifuMaterialTextboxUsername.LineIdleColor = System.Drawing.Color.DarkOliveGreen;
            this.bunifuMaterialTextboxUsername.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.bunifuMaterialTextboxUsername.LineThickness = 3;
            this.bunifuMaterialTextboxUsername.Location = new System.Drawing.Point(47, 121);
            this.bunifuMaterialTextboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxUsername.Name = "bunifuMaterialTextboxUsername";
            this.bunifuMaterialTextboxUsername.Size = new System.Drawing.Size(206, 33);
            this.bunifuMaterialTextboxUsername.TabIndex = 1;
            this.bunifuMaterialTextboxUsername.Text = "Username";
            this.bunifuMaterialTextboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxUsername.Enter += new System.EventHandler(this.bunifuMaterialTextboxUsername_Enter);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelLogin.Location = new System.Drawing.Point(75, 36);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(145, 42);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(326, 366);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxPassword;
        private System.Windows.Forms.Button buttonLogin;
    }
}