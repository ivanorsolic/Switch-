namespace SwitchЯ
{
    partial class Frm
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
            this.txtKorisnickoIme = new SwitchRDesign.STextBox();
            this.txtEmail = new SwitchRDesign.STextBox();
            this.txtZaporka = new SwitchRDesign.STextBox();
            this.sLabel1 = new SwitchRDesign.SLabel();
            this.sLabel2 = new SwitchRDesign.SLabel();
            this.sLabel3 = new SwitchRDesign.SLabel();
            this.btnSave = new SwitchRDesign.SButton();
            this.btnOdustani = new SwitchRDesign.SButton();
            this.sLabel4 = new SwitchRDesign.SLabel();
            this.lblKorisnik = new SwitchRDesign.SLabel();
            this.sLabel5 = new SwitchRDesign.SLabel();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Arial", 11F);
            this.txtKorisnickoIme.Location = new System.Drawing.Point(589, 298);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(300, 35);
            this.txtKorisnickoIme.TabIndex = 4;
            this.txtKorisnickoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 11F);
            this.txtEmail.Location = new System.Drawing.Point(589, 356);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 35);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZaporka
            // 
            this.txtZaporka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZaporka.Font = new System.Drawing.Font("Arial", 11F);
            this.txtZaporka.Location = new System.Drawing.Point(589, 412);
            this.txtZaporka.Name = "txtZaporka";
            this.txtZaporka.Size = new System.Drawing.Size(300, 35);
            this.txtZaporka.TabIndex = 6;
            this.txtZaporka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZaporka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZaporka_KeyPress_1);
            // 
            // sLabel1
            // 
            this.sLabel1.BackColor = System.Drawing.Color.Transparent;
            this.sLabel1.ForeColor = System.Drawing.Color.White;
            this.sLabel1.Location = new System.Drawing.Point(473, 305);
            this.sLabel1.Name = "sLabel1";
            this.sLabel1.Size = new System.Drawing.Size(130, 20);
            this.sLabel1.TabIndex = 11;
            this.sLabel1.Text = "Korisničko ime:";
            this.sLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sLabel2
            // 
            this.sLabel2.BackColor = System.Drawing.Color.Transparent;
            this.sLabel2.ForeColor = System.Drawing.Color.White;
            this.sLabel2.Location = new System.Drawing.Point(473, 364);
            this.sLabel2.Name = "sLabel2";
            this.sLabel2.Size = new System.Drawing.Size(130, 20);
            this.sLabel2.TabIndex = 12;
            this.sLabel2.Text = "Email:";
            this.sLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sLabel3
            // 
            this.sLabel3.BackColor = System.Drawing.Color.Transparent;
            this.sLabel3.ForeColor = System.Drawing.Color.White;
            this.sLabel3.Location = new System.Drawing.Point(473, 419);
            this.sLabel3.Name = "sLabel3";
            this.sLabel3.Size = new System.Drawing.Size(130, 20);
            this.sLabel3.TabIndex = 13;
            this.sLabel3.Text = "Zaporka*:";
            this.sLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(744, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(589, 465);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(145, 30);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Resetiraj";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // sLabel4
            // 
            this.sLabel4.AutoSize = true;
            this.sLabel4.BackColor = System.Drawing.Color.Transparent;
            this.sLabel4.ForeColor = System.Drawing.Color.White;
            this.sLabel4.Location = new System.Drawing.Point(618, 212);
            this.sLabel4.Name = "sLabel4";
            this.sLabel4.Size = new System.Drawing.Size(116, 16);
            this.sLabel4.TabIndex = 16;
            this.sLabel4.Text = "Trenutni korisnik:";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnik.ForeColor = System.Drawing.Color.White;
            this.lblKorisnik.Location = new System.Drawing.Point(763, 212);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(58, 16);
            this.lblKorisnik.TabIndex = 17;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // sLabel5
            // 
            this.sLabel5.BackColor = System.Drawing.Color.Transparent;
            this.sLabel5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sLabel5.ForeColor = System.Drawing.Color.White;
            this.sLabel5.Location = new System.Drawing.Point(473, 507);
            this.sLabel5.Name = "sLabel5";
            this.sLabel5.Size = new System.Drawing.Size(416, 20);
            this.sLabel5.TabIndex = 13;
            this.sLabel5.Text = "*Ukoliko ne želite mjenjati zaporku ovo polje zaporka ostavite prazno.";
            this.sLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.sLabel4);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.sLabel5);
            this.Controls.Add(this.sLabel3);
            this.Controls.Add(this.sLabel2);
            this.Controls.Add(this.sLabel1);
            this.Controls.Add(this.txtZaporka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Name = "Frm";
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.Frm_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            this.Controls.SetChildIndex(this.txtKorisnickoIme, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtZaporka, 0);
            this.Controls.SetChildIndex(this.sLabel1, 0);
            this.Controls.SetChildIndex(this.sLabel2, 0);
            this.Controls.SetChildIndex(this.sLabel3, 0);
            this.Controls.SetChildIndex(this.sLabel5, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnOdustani, 0);
            this.Controls.SetChildIndex(this.sLabel4, 0);
            this.Controls.SetChildIndex(this.lblKorisnik, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwitchRDesign.STextBox txtKorisnickoIme;
        private SwitchRDesign.STextBox txtEmail;
        private SwitchRDesign.STextBox txtZaporka;
        private SwitchRDesign.SLabel sLabel1;
        private SwitchRDesign.SLabel sLabel2;
        private SwitchRDesign.SLabel sLabel3;
        private SwitchRDesign.SButton btnSave;
        private SwitchRDesign.SButton btnOdustani;
        private SwitchRDesign.SLabel sLabel4;
        private SwitchRDesign.SLabel lblKorisnik;
        private SwitchRDesign.SLabel sLabel5;
    }
}