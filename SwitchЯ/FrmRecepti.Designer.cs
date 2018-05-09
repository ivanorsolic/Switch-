namespace SwitchЯ
{
    partial class FrmRecepti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sDataGridView1 = new SwitchRDesign.SDataGridView();
            this.receptiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idreceptaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipovievidnecijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredajkorisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodajRecept = new SwitchRDesign.SButton();
            ((System.ComponentModel.ISupportInitialize)(this.sDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sDataGridView1
            // 
            this.sDataGridView1.AllowUserToAddRows = false;
            this.sDataGridView1.AllowUserToDeleteRows = false;
            this.sDataGridView1.AllowUserToResizeColumns = false;
            this.sDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.sDataGridView1.AutoGenerateColumns = false;
            this.sDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.sDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreceptaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.idkorisnikaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.korisniciDataGridViewTextBoxColumn,
            this.tipovievidnecijeDataGridViewTextBoxColumn,
            this.uredajkorisniciDataGridViewTextBoxColumn});
            this.sDataGridView1.DataSource = this.receptiBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.sDataGridView1.EnableHeadersVisualStyles = false;
            this.sDataGridView1.Location = new System.Drawing.Point(338, 130);
            this.sDataGridView1.Name = "sDataGridView1";
            this.sDataGridView1.ReadOnly = true;
            this.sDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sDataGridView1.RowHeadersVisible = false;
            this.sDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sDataGridView1.Size = new System.Drawing.Size(605, 521);
            this.sDataGridView1.TabIndex = 4;
            // 
            // receptiBindingSource
            // 
            this.receptiBindingSource.DataSource = typeof(SwitchRModel.recepti);
            // 
            // idreceptaDataGridViewTextBoxColumn
            // 
            this.idreceptaDataGridViewTextBoxColumn.DataPropertyName = "id_recepta";
            this.idreceptaDataGridViewTextBoxColumn.HeaderText = "id_recepta";
            this.idreceptaDataGridViewTextBoxColumn.Name = "idreceptaDataGridViewTextBoxColumn";
            this.idreceptaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idreceptaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv recepta";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idkorisnikaDataGridViewTextBoxColumn
            // 
            this.idkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.HeaderText = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.Name = "idkorisnikaDataGridViewTextBoxColumn";
            this.idkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisniciDataGridViewTextBoxColumn
            // 
            this.korisniciDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.korisniciDataGridViewTextBoxColumn.DataPropertyName = "korisnici";
            this.korisniciDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.korisniciDataGridViewTextBoxColumn.Name = "korisniciDataGridViewTextBoxColumn";
            this.korisniciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipovievidnecijeDataGridViewTextBoxColumn
            // 
            this.tipovievidnecijeDataGridViewTextBoxColumn.DataPropertyName = "tipovi_evidnecije";
            this.tipovievidnecijeDataGridViewTextBoxColumn.HeaderText = "tipovi_evidnecije";
            this.tipovievidnecijeDataGridViewTextBoxColumn.Name = "tipovievidnecijeDataGridViewTextBoxColumn";
            this.tipovievidnecijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipovievidnecijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // uredajkorisniciDataGridViewTextBoxColumn
            // 
            this.uredajkorisniciDataGridViewTextBoxColumn.DataPropertyName = "uredaj_korisnici";
            this.uredajkorisniciDataGridViewTextBoxColumn.HeaderText = "uredaj_korisnici";
            this.uredajkorisniciDataGridViewTextBoxColumn.Name = "uredajkorisniciDataGridViewTextBoxColumn";
            this.uredajkorisniciDataGridViewTextBoxColumn.ReadOnly = true;
            this.uredajkorisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // buttonDodajRecept
            // 
            this.buttonDodajRecept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonDodajRecept.FlatAppearance.BorderSize = 0;
            this.buttonDodajRecept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajRecept.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajRecept.ForeColor = System.Drawing.Color.White;
            this.buttonDodajRecept.Location = new System.Drawing.Point(799, 97);
            this.buttonDodajRecept.Name = "buttonDodajRecept";
            this.buttonDodajRecept.Size = new System.Drawing.Size(144, 24);
            this.buttonDodajRecept.TabIndex = 5;
            this.buttonDodajRecept.Text = "Dodaj recept";
            this.buttonDodajRecept.UseVisualStyleBackColor = false;
            this.buttonDodajRecept.Click += new System.EventHandler(this.buttonDodajRecept_Click);
            // 
            // FrmRecepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.buttonDodajRecept);
            this.Controls.Add(this.sDataGridView1);
            this.Name = "FrmRecepti";
            this.Text = "FrmRecepti";
            this.Controls.SetChildIndex(this.sDataGridView1, 0);
            this.Controls.SetChildIndex(this.buttonDodajRecept, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwitchRDesign.SDataGridView sDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipovievidnecijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uredajkorisniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource receptiBindingSource;
        private SwitchRDesign.SButton buttonDodajRecept;
    }
}