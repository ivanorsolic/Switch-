namespace SwitchЯ
{
    partial class FrmDodajRecept
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
            this.buttonClose = new SwitchRDesign.SButton();
            this.buttonSave = new SwitchRDesign.SButton();
            this.sTextBox1 = new SwitchRDesign.STextBox();
            this.labelNaziv = new SwitchRDesign.SLabel();
            this.labelAkcije = new SwitchRDesign.SLabel();
            this.comboBox1 = new SwitchRDesign.SComboBox();
            this.buttonDodajAkciju = new SwitchRDesign.SButton();
            this.sDataGridView1 = new SwitchRDesign.SDataGridView();
            this.tipovievidnecijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidencijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipovievidnecijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(692, 658);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(145, 30);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Odustani";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(843, 658);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 30);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Spremi";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // sTextBox1
            // 
            this.sTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sTextBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.sTextBox1.Location = new System.Drawing.Point(194, 73);
            this.sTextBox1.Name = "sTextBox1";
            this.sTextBox1.Size = new System.Drawing.Size(300, 35);
            this.sTextBox1.TabIndex = 5;
            // 
            // labelNaziv
            // 
            this.labelNaziv.BackColor = System.Drawing.Color.Transparent;
            this.labelNaziv.ForeColor = System.Drawing.Color.White;
            this.labelNaziv.Location = new System.Drawing.Point(38, 73);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(150, 35);
            this.labelNaziv.TabIndex = 6;
            this.labelNaziv.Text = "Naziv recepta: ";
            this.labelNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAkcije
            // 
            this.labelAkcije.BackColor = System.Drawing.Color.Transparent;
            this.labelAkcije.ForeColor = System.Drawing.Color.White;
            this.labelAkcije.Location = new System.Drawing.Point(33, 132);
            this.labelAkcije.Name = "labelAkcije";
            this.labelAkcije.Size = new System.Drawing.Size(150, 35);
            this.labelAkcije.TabIndex = 6;
            this.labelAkcije.Text = "Akcije recepta:";
            this.labelAkcije.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 25);
            this.comboBox1.TabIndex = 7;
            // 
            // buttonDodajAkciju
            // 
            this.buttonDodajAkciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonDodajAkciju.FlatAppearance.BorderSize = 0;
            this.buttonDodajAkciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajAkciju.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.buttonDodajAkciju.ForeColor = System.Drawing.Color.White;
            this.buttonDodajAkciju.Location = new System.Drawing.Point(500, 138);
            this.buttonDodajAkciju.Name = "buttonDodajAkciju";
            this.buttonDodajAkciju.Size = new System.Drawing.Size(166, 25);
            this.buttonDodajAkciju.TabIndex = 8;
            this.buttonDodajAkciju.Text = "+ Dodaj Akciju";
            this.buttonDodajAkciju.UseVisualStyleBackColor = false;
            this.buttonDodajAkciju.Click += new System.EventHandler(this.buttonDodajAkciju_Click);
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
            this.idtipaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.evidencijaDataGridViewTextBoxColumn,
            this.receptiDataGridViewTextBoxColumn});
            this.sDataGridView1.DataSource = this.tipovievidnecijeBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.sDataGridView1.EnableHeadersVisualStyles = false;
            this.sDataGridView1.Location = new System.Drawing.Point(194, 182);
            this.sDataGridView1.Name = "sDataGridView1";
            this.sDataGridView1.ReadOnly = true;
            this.sDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sDataGridView1.RowHeadersVisible = false;
            this.sDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sDataGridView1.Size = new System.Drawing.Size(300, 488);
            this.sDataGridView1.TabIndex = 9;
            // 
            // tipovievidnecijeBindingSource
            // 
            this.tipovievidnecijeBindingSource.DataSource = typeof(SwitchRModel.tipovi_evidnecije);
            // 
            // idtipaDataGridViewTextBoxColumn
            // 
            this.idtipaDataGridViewTextBoxColumn.DataPropertyName = "id_tipa";
            this.idtipaDataGridViewTextBoxColumn.HeaderText = "id_tipa";
            this.idtipaDataGridViewTextBoxColumn.Name = "idtipaDataGridViewTextBoxColumn";
            this.idtipaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv akcije";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evidencijaDataGridViewTextBoxColumn
            // 
            this.evidencijaDataGridViewTextBoxColumn.DataPropertyName = "evidencija";
            this.evidencijaDataGridViewTextBoxColumn.HeaderText = "evidencija";
            this.evidencijaDataGridViewTextBoxColumn.Name = "evidencijaDataGridViewTextBoxColumn";
            this.evidencijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.evidencijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptiDataGridViewTextBoxColumn
            // 
            this.receptiDataGridViewTextBoxColumn.DataPropertyName = "recepti";
            this.receptiDataGridViewTextBoxColumn.HeaderText = "recepti";
            this.receptiDataGridViewTextBoxColumn.Name = "receptiDataGridViewTextBoxColumn";
            this.receptiDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptiDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmDodajRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.sDataGridView1);
            this.Controls.Add(this.buttonDodajAkciju);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelAkcije);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.sTextBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "FrmDodajRecept";
            this.Text = "FrmDodajRecept";
            this.Controls.SetChildIndex(this.buttonClose, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.sTextBox1, 0);
            this.Controls.SetChildIndex(this.labelNaziv, 0);
            this.Controls.SetChildIndex(this.labelAkcije, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.buttonDodajAkciju, 0);
            this.Controls.SetChildIndex(this.sDataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipovievidnecijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwitchRDesign.SButton buttonClose;
        private SwitchRDesign.SButton buttonSave;
        private SwitchRDesign.STextBox sTextBox1;
        private SwitchRDesign.SLabel labelNaziv;
        private SwitchRDesign.SLabel labelAkcije;
        private SwitchRDesign.SComboBox comboBox1;
        private SwitchRDesign.SButton buttonDodajAkciju;
        private SwitchRDesign.SDataGridView sDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidencijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipovievidnecijeBindingSource;
    }
}