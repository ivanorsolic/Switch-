using SwitchRDesign;

namespace SwitchЯ
{
    partial class FrmPrijava
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
            this.btnPrijava = new SwitchRDesign.SButton();
            this.inputPassword = new SwitchRDesign.STextBox();
            this.inputUsername = new SwitchRDesign.STextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.sLabel1 = new SwitchRDesign.SLabel();
            this.lblRegistracija = new SwitchRDesign.SLabel();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrijava.ForeColor = System.Drawing.Color.White;

            this.btnPrijava.Location = new System.Drawing.Point(302, 345);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(266, 34);

            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "PRIJAVA";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPassword.Enabled = false;
            this.inputPassword.Font = new System.Drawing.Font("Arial", 11F);

            this.inputPassword.Location = new System.Drawing.Point(302, 295);
            this.inputPassword.Multiline = true;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(266, 34);

            this.inputPassword.TabIndex = 1;
            // 
            // inputUsername
            // 
            this.inputUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUsername.Enabled = false;
            this.inputUsername.Font = new System.Drawing.Font("Arial", 11F);

            this.inputUsername.Location = new System.Drawing.Point(302, 244);
            this.inputUsername.Multiline = true;
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(266, 34);

            this.inputUsername.TabIndex = 0;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.BackColor = System.Drawing.Color.White;
            this.txtKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.Black;

            this.txtKorisnickoIme.Location = new System.Drawing.Point(306, 248);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(258, 23);

            this.txtKorisnickoIme.TabIndex = 10;
            this.txtKorisnickoIme.Text = "email";
            this.txtKorisnickoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKorisnickoIme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKorisnickoIme_MouseClick);
            // 
            // txtLozinka
            // 
            this.txtLozinka.BackColor = System.Drawing.Color.White;
            this.txtLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLozinka.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.ForeColor = System.Drawing.Color.Black;

            this.txtLozinka.Location = new System.Drawing.Point(306, 299);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(258, 23);

            this.txtLozinka.TabIndex = 11;
            this.txtLozinka.Text = "lozinka";
            this.txtLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLozinka.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLozinka_MouseClick);
            this.txtLozinka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLozinka_KeyPress);
            // 
            // sLabel1
            // 
            this.sLabel1.AutoSize = true;
            this.sLabel1.BackColor = System.Drawing.Color.Transparent;

            this.sLabel1.Font = new System.Drawing.Font("Verdana", 20F);
            this.sLabel1.ForeColor = System.Drawing.Color.White;
            this.sLabel1.Location = new System.Drawing.Point(323, 185);
            this.sLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sLabel1.Name = "sLabel1";
            this.sLabel1.Size = new System.Drawing.Size(237, 32);

            this.sLabel1.TabIndex = 12;
            this.sLabel1.Text = "Prijava korisnika";
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistracija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistracija.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblRegistracija.ForeColor = System.Drawing.Color.White;

            this.lblRegistracija.Location = new System.Drawing.Point(459, 382);
            this.lblRegistracija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(101, 17);

            this.lblRegistracija.TabIndex = 13;
            this.lblRegistracija.Text = "Registriraj se";
            this.lblRegistracija.Click += new System.EventHandler(this.lblRegistracija_Click);
            // 
            // FrmPrijava
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 589);

            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.sLabel1);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);

            this.Font = new System.Drawing.Font("Arial", 10.2F);

            this.Name = "FrmPrijava";
            this.Text = "SwitchЯ";
            this.Load += new System.EventHandler(this.FrmPrijava_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrijava_KeyDown);
            this.Controls.SetChildIndex(this.inputUsername, 0);
            this.Controls.SetChildIndex(this.inputPassword, 0);
            this.Controls.SetChildIndex(this.btnPrijava, 0);
            this.Controls.SetChildIndex(this.txtKorisnickoIme, 0);
            this.Controls.SetChildIndex(this.txtLozinka, 0);
            this.Controls.SetChildIndex(this.sLabel1, 0);
            this.Controls.SetChildIndex(this.lblRegistracija, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SButton btnPrijava;
        private STextBox inputPassword;
        private STextBox inputUsername;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private SLabel sLabel1;
        private SLabel lblRegistracija;
    }
}

