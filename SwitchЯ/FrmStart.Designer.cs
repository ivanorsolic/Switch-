using SwitchRDesign;

namespace SwitchЯ
{
    partial class FrmStart
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
            this.dgvUredaji = new SwitchRDesign.SDataGridView();
            this.iduredajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoviuredajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredajkorisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uredajkorisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUredaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uredajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uredajkorisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUredaji
            // 
            this.dgvUredaji.AllowUserToAddRows = false;
            this.dgvUredaji.AllowUserToDeleteRows = false;
            this.dgvUredaji.AllowUserToResizeColumns = false;
            this.dgvUredaji.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvUredaji.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUredaji.AutoGenerateColumns = false;
            this.dgvUredaji.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dgvUredaji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUredaji.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUredaji.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUredaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUredaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUredaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduredajaDataGridViewTextBoxColumn,
            this.idtipaDataGridViewTextBoxColumn,
            this.uniqecodeDataGridViewTextBoxColumn,
            this.tipoviuredajaDataGridViewTextBoxColumn,
            this.uredajkorisniciDataGridViewTextBoxColumn});
            this.dgvUredaji.DataSource = this.uredajiBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUredaji.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUredaji.EnableHeadersVisualStyles = false;
            this.dgvUredaji.Location = new System.Drawing.Point(415, 175);
            this.dgvUredaji.Name = "dgvUredaji";
            this.dgvUredaji.ReadOnly = true;
            this.dgvUredaji.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUredaji.RowHeadersVisible = false;
            this.dgvUredaji.RowTemplate.Height = 24;
            this.dgvUredaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUredaji.Size = new System.Drawing.Size(649, 479);
            this.dgvUredaji.TabIndex = 7;
            this.dgvUredaji.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUredaji_MouseDoubleClick);
            // 
            // iduredajaDataGridViewTextBoxColumn
            // 
            this.iduredajaDataGridViewTextBoxColumn.DataPropertyName = "id_uredaja";
            this.iduredajaDataGridViewTextBoxColumn.HeaderText = "id_uredaja";
            this.iduredajaDataGridViewTextBoxColumn.Name = "iduredajaDataGridViewTextBoxColumn";
            this.iduredajaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iduredajaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idtipaDataGridViewTextBoxColumn
            // 
            this.idtipaDataGridViewTextBoxColumn.DataPropertyName = "id_tipa";
            this.idtipaDataGridViewTextBoxColumn.HeaderText = "id_tipa";
            this.idtipaDataGridViewTextBoxColumn.Name = "idtipaDataGridViewTextBoxColumn";
            this.idtipaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipaDataGridViewTextBoxColumn.Visible = false;
            // 
            // uniqecodeDataGridViewTextBoxColumn
            // 
            this.uniqecodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uniqecodeDataGridViewTextBoxColumn.DataPropertyName = "uniqe_code";
            this.uniqecodeDataGridViewTextBoxColumn.HeaderText = "Kod uređaja";
            this.uniqecodeDataGridViewTextBoxColumn.Name = "uniqecodeDataGridViewTextBoxColumn";
            this.uniqecodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoviuredajaDataGridViewTextBoxColumn
            // 
            this.tipoviuredajaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoviuredajaDataGridViewTextBoxColumn.DataPropertyName = "tipovi_uredaja";
            this.tipoviuredajaDataGridViewTextBoxColumn.HeaderText = "Tip uređaja";
            this.tipoviuredajaDataGridViewTextBoxColumn.Name = "tipoviuredajaDataGridViewTextBoxColumn";
            this.tipoviuredajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uredajkorisniciDataGridViewTextBoxColumn
            // 
            this.uredajkorisniciDataGridViewTextBoxColumn.DataPropertyName = "uredaj_korisnici";
            this.uredajkorisniciDataGridViewTextBoxColumn.HeaderText = "uredaj_korisnici";
            this.uredajkorisniciDataGridViewTextBoxColumn.Name = "uredajkorisniciDataGridViewTextBoxColumn";
            this.uredajkorisniciDataGridViewTextBoxColumn.ReadOnly = true;
            this.uredajkorisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // uredajiBindingSource
            // 
            this.uredajiBindingSource.DataSource = typeof(SwitchRModel.uredaji);
            // 
            // uredajkorisniciBindingSource
            // 
            this.uredajkorisniciBindingSource.DataSource = typeof(SwitchRModel.uredaj_korisnici);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.dgvUredaji);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStart";
            this.Text = "SwitchЯ";
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.Shown += new System.EventHandler(this.FrmStart_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStart_KeyDown);
            this.Controls.SetChildIndex(this.dgvUredaji, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUredaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uredajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uredajkorisniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SDataGridView dgvUredaji;
        private System.Windows.Forms.BindingSource uredajiBindingSource;
        private System.Windows.Forms.BindingSource uredajkorisniciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduredajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoviuredajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uredajkorisniciDataGridViewTextBoxColumn;


    }
}