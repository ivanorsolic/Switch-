namespace SwitchЯ
{
    partial class FrmAkcije
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sDataGridView1 = new SwitchRDesign.SDataGridView();
            this.idlogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduredajkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idreceptaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredajkorisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidencijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new SwitchRDesign.SButton();
            this.buttonClose = new SwitchRDesign.SButton();
            this.buttonDelete = new SwitchRDesign.SButton();
            this.labelNazivUredaja = new SwitchRDesign.SLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sDataGridView1
            // 
            this.sDataGridView1.AllowUserToAddRows = false;
            this.sDataGridView1.AllowUserToDeleteRows = false;
            this.sDataGridView1.AllowUserToResizeColumns = false;
            this.sDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sDataGridView1.AutoGenerateColumns = false;
            this.sDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlogaDataGridViewTextBoxColumn,
            this.iduredajkorisnikaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.aktivanDataGridViewCheckBoxColumn,
            this.idreceptaDataGridViewTextBoxColumn,
            this.receptiDataGridViewTextBoxColumn,
            this.uredajkorisniciDataGridViewTextBoxColumn});
            this.sDataGridView1.DataSource = this.evidencijaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.sDataGridView1.EnableHeadersVisualStyles = false;
            this.sDataGridView1.Location = new System.Drawing.Point(89, 90);
            this.sDataGridView1.Name = "sDataGridView1";
            this.sDataGridView1.ReadOnly = true;
            this.sDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sDataGridView1.RowHeadersVisible = false;
            this.sDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sDataGridView1.Size = new System.Drawing.Size(824, 493);
            this.sDataGridView1.TabIndex = 4;
            // 
            // idlogaDataGridViewTextBoxColumn
            // 
            this.idlogaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idlogaDataGridViewTextBoxColumn.DataPropertyName = "id_loga";
            this.idlogaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idlogaDataGridViewTextBoxColumn.Name = "idlogaDataGridViewTextBoxColumn";
            this.idlogaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iduredajkorisnikaDataGridViewTextBoxColumn
            // 
            this.iduredajkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "id_uredaj_korisnika";
            this.iduredajkorisnikaDataGridViewTextBoxColumn.HeaderText = "id_uredaj_korisnika";
            this.iduredajkorisnikaDataGridViewTextBoxColumn.Name = "iduredajkorisnikaDataGridViewTextBoxColumn";
            this.iduredajkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iduredajkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idreceptaDataGridViewTextBoxColumn
            // 
            this.idreceptaDataGridViewTextBoxColumn.DataPropertyName = "id_recepta";
            this.idreceptaDataGridViewTextBoxColumn.HeaderText = "id_recepta";
            this.idreceptaDataGridViewTextBoxColumn.Name = "idreceptaDataGridViewTextBoxColumn";
            this.idreceptaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idreceptaDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptiDataGridViewTextBoxColumn
            // 
            this.receptiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptiDataGridViewTextBoxColumn.DataPropertyName = "recepti";
            this.receptiDataGridViewTextBoxColumn.HeaderText = "Recept";
            this.receptiDataGridViewTextBoxColumn.Name = "receptiDataGridViewTextBoxColumn";
            this.receptiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uredajkorisniciDataGridViewTextBoxColumn
            // 
            this.uredajkorisniciDataGridViewTextBoxColumn.DataPropertyName = "uredaj_korisnici";
            this.uredajkorisniciDataGridViewTextBoxColumn.HeaderText = "uredaj_korisnici";
            this.uredajkorisniciDataGridViewTextBoxColumn.Name = "uredajkorisniciDataGridViewTextBoxColumn";
            this.uredajkorisniciDataGridViewTextBoxColumn.ReadOnly = true;
            this.uredajkorisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // evidencijaBindingSource
            // 
            this.evidencijaBindingSource.DataSource = typeof(SwitchRModel.evidencija);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(768, 54);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 30);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj novu";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(843, 658);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(145, 30);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Odustani";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(617, 54);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 30);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Otkaži odabranu";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelNazivUredaja
            // 
            this.labelNazivUredaja.AutoSize = true;
            this.labelNazivUredaja.BackColor = System.Drawing.Color.Transparent;
            this.labelNazivUredaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazivUredaja.ForeColor = System.Drawing.Color.White;
            this.labelNazivUredaja.Location = new System.Drawing.Point(94, 62);
            this.labelNazivUredaja.Name = "labelNazivUredaja";
            this.labelNazivUredaja.Size = new System.Drawing.Size(69, 19);
            this.labelNazivUredaja.TabIndex = 7;
            this.labelNazivUredaja.Text = "sLabel1";
            // 
            // FrmAkcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.labelNazivUredaja);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.sDataGridView1);
            this.Name = "FrmAkcije";
            this.Text = "FrmAkcije";
            this.Controls.SetChildIndex(this.sDataGridView1, 0);
            this.Controls.SetChildIndex(this.buttonClose, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.labelNazivUredaja, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwitchRDesign.SDataGridView sDataGridView1;
        private System.Windows.Forms.BindingSource evidencijaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduredajkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uredajkorisniciDataGridViewTextBoxColumn;
        private SwitchRDesign.SButton buttonAdd;
        private SwitchRDesign.SButton buttonClose;
        private SwitchRDesign.SButton buttonDelete;
        private SwitchRDesign.SLabel labelNazivUredaja;
    }
}