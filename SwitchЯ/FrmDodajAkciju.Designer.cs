namespace SwitchЯ
{
    partial class FrmDodajAkciju
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
            this.buttonSave = new SwitchRDesign.SButton();
            this.buttonClose = new SwitchRDesign.SButton();
            this.sLabel1 = new SwitchRDesign.SLabel();
            this.receptiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sDataGridView1 = new SwitchRDesign.SDataGridView();
            this.idreceptaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipovievidnecijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredajkorisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLabel2 = new SwitchRDesign.SLabel();
            this.sButton1 = new SwitchRDesign.SButton();
            this.sButton2 = new SwitchRDesign.SButton();
            this.sButton3 = new SwitchRDesign.SButton();
            this.sButton4 = new SwitchRDesign.SButton();
            this.sButton5 = new SwitchRDesign.SButton();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(839, 658);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Spremi";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(688, 658);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(145, 30);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Odustani";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // sLabel1
            // 
            this.sLabel1.AutoSize = true;
            this.sLabel1.BackColor = System.Drawing.Color.Transparent;
            this.sLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sLabel1.ForeColor = System.Drawing.Color.White;
            this.sLabel1.Location = new System.Drawing.Point(38, 70);
            this.sLabel1.Name = "sLabel1";
            this.sLabel1.Size = new System.Drawing.Size(67, 19);
            this.sLabel1.TabIndex = 8;
            this.sLabel1.Text = "Recepti";
            // 
            // receptiBindingSource
            // 
            this.receptiBindingSource.DataSource = typeof(SwitchRModel.recepti);
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
            this.sDataGridView1.Location = new System.Drawing.Point(42, 92);
            this.sDataGridView1.Name = "sDataGridView1";
            this.sDataGridView1.ReadOnly = true;
            this.sDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sDataGridView1.RowHeadersVisible = false;
            this.sDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sDataGridView1.Size = new System.Drawing.Size(605, 521);
            this.sDataGridView1.TabIndex = 9;
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
            // sLabel2
            // 
            this.sLabel2.AutoSize = true;
            this.sLabel2.BackColor = System.Drawing.Color.Transparent;
            this.sLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sLabel2.ForeColor = System.Drawing.Color.White;
            this.sLabel2.Location = new System.Drawing.Point(665, 70);
            this.sLabel2.Name = "sLabel2";
            this.sLabel2.Size = new System.Drawing.Size(76, 19);
            this.sLabel2.TabIndex = 8;
            this.sLabel2.Text = "Vremena";
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(669, 109);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(300, 35);
            this.sButton1.TabIndex = 10;
            this.sButton1.Text = "Odmah";
            this.sButton1.UseVisualStyleBackColor = false;
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Location = new System.Drawing.Point(669, 150);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(300, 35);
            this.sButton2.TabIndex = 11;
            this.sButton2.Text = "+10 sec";
            this.sButton2.UseVisualStyleBackColor = false;
            // 
            // sButton3
            // 
            this.sButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sButton3.FlatAppearance.BorderSize = 0;
            this.sButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.sButton3.ForeColor = System.Drawing.Color.White;
            this.sButton3.Location = new System.Drawing.Point(669, 191);
            this.sButton3.Name = "sButton3";
            this.sButton3.Size = new System.Drawing.Size(300, 35);
            this.sButton3.TabIndex = 11;
            this.sButton3.Text = "+30 sec";
            this.sButton3.UseVisualStyleBackColor = false;
            // 
            // sButton4
            // 
            this.sButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sButton4.FlatAppearance.BorderSize = 0;
            this.sButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.sButton4.ForeColor = System.Drawing.Color.White;
            this.sButton4.Location = new System.Drawing.Point(669, 232);
            this.sButton4.Name = "sButton4";
            this.sButton4.Size = new System.Drawing.Size(300, 35);
            this.sButton4.TabIndex = 11;
            this.sButton4.Text = "+5 min";
            this.sButton4.UseVisualStyleBackColor = false;
            // 
            // sButton5
            // 
            this.sButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sButton5.FlatAppearance.BorderSize = 0;
            this.sButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.sButton5.ForeColor = System.Drawing.Color.White;
            this.sButton5.Location = new System.Drawing.Point(669, 273);
            this.sButton5.Name = "sButton5";
            this.sButton5.Size = new System.Drawing.Size(300, 35);
            this.sButton5.TabIndex = 11;
            this.sButton5.Text = "+60 min";
            this.sButton5.UseVisualStyleBackColor = false;
            // 
            // FrmDodajAkciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.sButton5);
            this.Controls.Add(this.sButton4);
            this.Controls.Add(this.sButton3);
            this.Controls.Add(this.sButton2);
            this.Controls.Add(this.sButton1);
            this.Controls.Add(this.sDataGridView1);
            this.Controls.Add(this.sLabel2);
            this.Controls.Add(this.sLabel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "FrmDodajAkciju";
            this.Text = "FrmDodajAkciju";
            this.Controls.SetChildIndex(this.buttonClose, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.sLabel1, 0);
            this.Controls.SetChildIndex(this.sLabel2, 0);
            this.Controls.SetChildIndex(this.sDataGridView1, 0);
            this.Controls.SetChildIndex(this.sButton1, 0);
            this.Controls.SetChildIndex(this.sButton2, 0);
            this.Controls.SetChildIndex(this.sButton3, 0);
            this.Controls.SetChildIndex(this.sButton4, 0);
            this.Controls.SetChildIndex(this.sButton5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwitchRDesign.SButton buttonSave;
        private SwitchRDesign.SButton buttonClose;
        private SwitchRDesign.SLabel sLabel1;
        private System.Windows.Forms.BindingSource receptiBindingSource;
        private SwitchRDesign.SDataGridView sDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipovievidnecijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uredajkorisniciDataGridViewTextBoxColumn;
        private SwitchRDesign.SLabel sLabel2;
        private SwitchRDesign.SButton sButton1;
        private SwitchRDesign.SButton sButton2;
        private SwitchRDesign.SButton sButton3;
        private SwitchRDesign.SButton sButton4;
        private SwitchRDesign.SButton sButton5;
    }
}