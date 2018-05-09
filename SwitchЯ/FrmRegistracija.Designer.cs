using SwitchRDesign;

namespace SwitchЯ
{
    partial class FrmRegistracija
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
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.sTextBox1 = new STextBox();
            this.sTextBox2 = new STextBox();
            this.sbtnRegistracija = new SButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.sTextBox3 = new STextBox();
            this.sLabel1 = new SLabel();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.BackColor = System.Drawing.Color.White;
            this.txtKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.Black;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(341, 290);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKorisnickoIme.Multiline = true;
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(290, 30);
            this.txtKorisnickoIme.TabIndex = 9;
            this.txtKorisnickoIme.Text = "korisničko ime";
            this.txtKorisnickoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKorisnickoIme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKorisnickoIme_MouseClick);
            // 
            // txtLozinka
            // 
            this.txtLozinka.BackColor = System.Drawing.Color.White;
            this.txtLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLozinka.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtLozinka.ForeColor = System.Drawing.Color.Black;
            this.txtLozinka.Location = new System.Drawing.Point(341, 400);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLozinka.Multiline = true;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(290, 30);
            this.txtLozinka.TabIndex = 10;
            this.txtLozinka.Text = "lozinka";
            this.txtLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLozinka.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLozinka_MouseClick);
            this.txtLozinka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLozinka_KeyPress);
            // 
            // sTextBox1
            // 
            this.sTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sTextBox1.Enabled = false;
            this.sTextBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.sTextBox1.Location = new System.Drawing.Point(336, 285);
            this.sTextBox1.Name = "sTextBox1";
            this.sTextBox1.Size = new System.Drawing.Size(300, 40);
            this.sTextBox1.TabIndex = 11;
            // 
            // sTextBox2
            // 
            this.sTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sTextBox2.Enabled = false;
            this.sTextBox2.Font = new System.Drawing.Font("Arial", 11F);
            this.sTextBox2.Location = new System.Drawing.Point(336, 395);
            this.sTextBox2.Name = "sTextBox2";
            this.sTextBox2.Size = new System.Drawing.Size(300, 40);
            this.sTextBox2.TabIndex = 12;
            // 
            // sbtnRegistracija
            // 
            this.sbtnRegistracija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sbtnRegistracija.FlatAppearance.BorderSize = 0;
            this.sbtnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtnRegistracija.Font = new System.Drawing.Font("Arial", 15F);
            this.sbtnRegistracija.ForeColor = System.Drawing.Color.White;
            this.sbtnRegistracija.Location = new System.Drawing.Point(336, 450);
            this.sbtnRegistracija.Name = "sbtnRegistracija";
            this.sbtnRegistracija.Size = new System.Drawing.Size(300, 40);
            this.sbtnRegistracija.TabIndex = 13;
            this.sbtnRegistracija.Text = "Registracija";
            this.sbtnRegistracija.UseVisualStyleBackColor = false;
            this.sbtnRegistracija.Click += new System.EventHandler(this.sbtnRegistracija_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(341, 345);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 30);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Text = "email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEmail_MouseClick);
            // 
            // sTextBox3
            // 
            this.sTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sTextBox3.Enabled = false;
            this.sTextBox3.Font = new System.Drawing.Font("Arial", 11F);
            this.sTextBox3.Location = new System.Drawing.Point(336, 340);
            this.sTextBox3.Name = "sTextBox3";
            this.sTextBox3.Size = new System.Drawing.Size(300, 40);
            this.sTextBox3.TabIndex = 15;
            // 
            // sLabel1
            // 
            this.sLabel1.AutoSize = true;
            this.sLabel1.BackColor = System.Drawing.Color.Transparent;
            this.sLabel1.Font = new System.Drawing.Font("Verdana", 30F);
            this.sLabel1.ForeColor = System.Drawing.Color.White;
            this.sLabel1.Location = new System.Drawing.Point(210, 193);
            this.sLabel1.Name = "sLabel1";
            this.sLabel1.Size = new System.Drawing.Size(566, 60);
            this.sLabel1.TabIndex = 16;
            this.sLabel1.Text = "Registracija korisnika";
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.sLabel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.sTextBox3);
            this.Controls.Add(this.sbtnRegistracija);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.sTextBox2);
            this.Controls.Add(this.sTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegistracija";
            this.Text = "FrmRegistracija";
            this.Load += new System.EventHandler(this.FrmRegistracija_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRegistracija_KeyDown);
            this.Controls.SetChildIndex(this.sTextBox1, 0);
            this.Controls.SetChildIndex(this.sTextBox2, 0);
            this.Controls.SetChildIndex(this.txtKorisnickoIme, 0);
            this.Controls.SetChildIndex(this.txtLozinka, 0);
            this.Controls.SetChildIndex(this.sbtnRegistracija, 0);
            this.Controls.SetChildIndex(this.sTextBox3, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.sLabel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private STextBox sTextBox1;
        private STextBox sTextBox2;
        private SButton sbtnRegistracija;
        private System.Windows.Forms.TextBox txtEmail;
        private STextBox sTextBox3;
        private SLabel sLabel1;
    }
}