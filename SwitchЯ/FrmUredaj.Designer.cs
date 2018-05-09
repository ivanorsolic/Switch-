namespace SwitchЯ
{
    partial class FrmUredaj
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
            this.components = new System.ComponentModel.Container();
            this.uredajkorisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uredajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBazna = new SwitchRDesign.SButton();
            this.textJedinstveni = new SwitchRDesign.STextBox();
            this.sLabel1 = new SwitchRDesign.SLabel();
            this.btnHotspot = new SwitchRDesign.SButton();
            this.textSSID = new SwitchRDesign.STextBox();
            this.textLozinka = new SwitchRDesign.STextBox();
            this.sLabel2 = new SwitchRDesign.SLabel();
            this.sLabel3 = new SwitchRDesign.SLabel();
            this.btnUređaj = new SwitchRDesign.SButton();
            this.txtJedinstveniUredaja = new SwitchRDesign.STextBox();
            this.sLabel4 = new SwitchRDesign.SLabel();
            this.txtNazivUredaja = new SwitchRDesign.STextBox();
            this.sLabel5 = new SwitchRDesign.SLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.uredajkorisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uredajiBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uredajkorisniciBindingSource
            // 
            this.uredajkorisniciBindingSource.DataSource = typeof(SwitchRModel.uredaj_korisnici);
            // 
            // receptiBindingSource
            // 
            this.receptiBindingSource.DataSource = typeof(SwitchRModel.recepti);
            // 
            // uredajiBindingSource
            // 
            this.uredajiBindingSource.DataSource = typeof(SwitchRModel.uredaji);
            // 
            // btnBazna
            // 
            this.btnBazna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBazna.FlatAppearance.BorderSize = 0;
            this.btnBazna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBazna.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnBazna.ForeColor = System.Drawing.Color.White;
            this.btnBazna.Location = new System.Drawing.Point(12, 272);
            this.btnBazna.Name = "btnBazna";
            this.btnBazna.Size = new System.Drawing.Size(212, 35);
            this.btnBazna.TabIndex = 5;
            this.btnBazna.Text = "Dodaj baznu stanicu";
            this.btnBazna.UseVisualStyleBackColor = false;
            this.btnBazna.Click += new System.EventHandler(this.btnBazna_Click);
            // 
            // textJedinstveni
            // 
            this.textJedinstveni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textJedinstveni.Font = new System.Drawing.Font("Arial", 11F);
            this.textJedinstveni.Location = new System.Drawing.Point(12, 51);
            this.textJedinstveni.Name = "textJedinstveni";
            this.textJedinstveni.Size = new System.Drawing.Size(212, 35);
            this.textJedinstveni.TabIndex = 6;
            // 
            // sLabel1
            // 
            this.sLabel1.AutoSize = true;
            this.sLabel1.BackColor = System.Drawing.Color.Transparent;
            this.sLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel1.ForeColor = System.Drawing.Color.White;
            this.sLabel1.Location = new System.Drawing.Point(9, 32);
            this.sLabel1.Name = "sLabel1";
            this.sLabel1.Size = new System.Drawing.Size(185, 16);
            this.sLabel1.TabIndex = 7;
            this.sLabel1.Text = "Jedinstveni kod bazne stanice:";
            // 
            // btnHotspot
            // 
            this.btnHotspot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnHotspot.FlatAppearance.BorderSize = 0;
            this.btnHotspot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotspot.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnHotspot.ForeColor = System.Drawing.Color.White;
            this.btnHotspot.Location = new System.Drawing.Point(12, 231);
            this.btnHotspot.Name = "btnHotspot";
            this.btnHotspot.Size = new System.Drawing.Size(212, 35);
            this.btnHotspot.TabIndex = 8;
            this.btnHotspot.Text = "Toggle Hotspot";
            this.btnHotspot.UseVisualStyleBackColor = false;
            this.btnHotspot.Click += new System.EventHandler(this.btnHotspot_Click);
            // 
            // textSSID
            // 
            this.textSSID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSSID.Font = new System.Drawing.Font("Arial", 11F);
            this.textSSID.Location = new System.Drawing.Point(12, 116);
            this.textSSID.Name = "textSSID";
            this.textSSID.Size = new System.Drawing.Size(212, 35);
            this.textSSID.TabIndex = 9;
            // 
            // textLozinka
            // 
            this.textLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLozinka.Font = new System.Drawing.Font("Arial", 11F);
            this.textLozinka.Location = new System.Drawing.Point(12, 178);
            this.textLozinka.Name = "textLozinka";
            this.textLozinka.Size = new System.Drawing.Size(212, 35);
            this.textLozinka.TabIndex = 10;
            // 
            // sLabel2
            // 
            this.sLabel2.AutoSize = true;
            this.sLabel2.BackColor = System.Drawing.Color.Transparent;
            this.sLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel2.ForeColor = System.Drawing.Color.White;
            this.sLabel2.Location = new System.Drawing.Point(9, 97);
            this.sLabel2.Name = "sLabel2";
            this.sLabel2.Size = new System.Drawing.Size(42, 16);
            this.sLabel2.TabIndex = 11;
            this.sLabel2.Text = "SSID:";
            // 
            // sLabel3
            // 
            this.sLabel3.AutoSize = true;
            this.sLabel3.BackColor = System.Drawing.Color.Transparent;
            this.sLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel3.ForeColor = System.Drawing.Color.White;
            this.sLabel3.Location = new System.Drawing.Point(9, 159);
            this.sLabel3.Name = "sLabel3";
            this.sLabel3.Size = new System.Drawing.Size(57, 16);
            this.sLabel3.TabIndex = 12;
            this.sLabel3.Text = "Lozinka:";
            // 
            // btnUređaj
            // 
            this.btnUređaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUređaj.FlatAppearance.BorderSize = 0;
            this.btnUređaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUređaj.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnUređaj.ForeColor = System.Drawing.Color.White;
            this.btnUređaj.Location = new System.Drawing.Point(17, 272);
            this.btnUređaj.Name = "btnUređaj";
            this.btnUređaj.Size = new System.Drawing.Size(212, 35);
            this.btnUređaj.TabIndex = 13;
            this.btnUređaj.Text = "Dodaj uređaj";
            this.btnUređaj.UseVisualStyleBackColor = false;
            this.btnUređaj.Click += new System.EventHandler(this.btnUređaj_Click);
            // 
            // txtJedinstveniUredaja
            // 
            this.txtJedinstveniUredaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJedinstveniUredaja.Font = new System.Drawing.Font("Arial", 11F);
            this.txtJedinstveniUredaja.Location = new System.Drawing.Point(17, 43);
            this.txtJedinstveniUredaja.Name = "txtJedinstveniUredaja";
            this.txtJedinstveniUredaja.Size = new System.Drawing.Size(212, 35);
            this.txtJedinstveniUredaja.TabIndex = 14;
            // 
            // sLabel4
            // 
            this.sLabel4.AutoSize = true;
            this.sLabel4.BackColor = System.Drawing.Color.Transparent;
            this.sLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel4.ForeColor = System.Drawing.Color.White;
            this.sLabel4.Location = new System.Drawing.Point(14, 24);
            this.sLabel4.Name = "sLabel4";
            this.sLabel4.Size = new System.Drawing.Size(146, 16);
            this.sLabel4.TabIndex = 15;
            this.sLabel4.Text = "Jedinstveni kod uređaja:";
            // 
            // txtNazivUredaja
            // 
            this.txtNazivUredaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNazivUredaja.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNazivUredaja.Location = new System.Drawing.Point(17, 108);
            this.txtNazivUredaja.Name = "txtNazivUredaja";
            this.txtNazivUredaja.Size = new System.Drawing.Size(212, 35);
            this.txtNazivUredaja.TabIndex = 16;
            // 
            // sLabel5
            // 
            this.sLabel5.AutoSize = true;
            this.sLabel5.BackColor = System.Drawing.Color.Transparent;
            this.sLabel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel5.ForeColor = System.Drawing.Color.White;
            this.sLabel5.Location = new System.Drawing.Point(14, 89);
            this.sLabel5.Name = "sLabel5";
            this.sLabel5.Size = new System.Drawing.Size(89, 16);
            this.sLabel5.TabIndex = 15;
            this.sLabel5.Text = "Naziv uređaja:";
          
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textJedinstveni);
            this.groupBox1.Controls.Add(this.btnBazna);
            this.groupBox1.Controls.Add(this.sLabel1);
            this.groupBox1.Controls.Add(this.btnHotspot);
            this.groupBox1.Controls.Add(this.textSSID);
            this.groupBox1.Controls.Add(this.textLozinka);
            this.groupBox1.Controls.Add(this.sLabel2);
            this.groupBox1.Controls.Add(this.sLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(397, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 323);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DODAVANJE BAZNE STANICE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtJedinstveniUredaja);
            this.groupBox2.Controls.Add(this.btnUređaj);
            this.groupBox2.Controls.Add(this.sLabel4);
            this.groupBox2.Controls.Add(this.txtNazivUredaja);
            this.groupBox2.Controls.Add(this.sLabel5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(677, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 323);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DODAVANJE UREĐAJA";
            // 
            // FrmUredaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUredaj";
            this.Text = "FrmUredaj";
            
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uredajkorisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uredajiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource receptiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivuređajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uredajkorisniciBindingSource;
        private System.Windows.Forms.BindingSource uredajiBindingSource;
        private SwitchRDesign.SButton btnBazna;
        private SwitchRDesign.STextBox textJedinstveni;
        private SwitchRDesign.SLabel sLabel1;
        private SwitchRDesign.SButton btnHotspot;
        private SwitchRDesign.STextBox textSSID;
        private SwitchRDesign.STextBox textLozinka;
        private SwitchRDesign.SLabel sLabel2;
        private SwitchRDesign.SLabel sLabel3;
        private SwitchRDesign.SButton btnUređaj;
        private SwitchRDesign.STextBox txtJedinstveniUredaja;
        private SwitchRDesign.SLabel sLabel4;
        private SwitchRDesign.STextBox txtNazivUredaja;
        private SwitchRDesign.SLabel sLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}