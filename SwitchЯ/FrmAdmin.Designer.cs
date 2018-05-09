using SwitchRDesign;

namespace SwitchЯ
{
    partial class FrmAdmin
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
            this.dgvKorisnici = new SwitchRDesign.SDataGridView();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblKorisnici = new SwitchRDesign.SLabel();
            this.switchRMenu1 = new SwitchRComponents.SwitchRMenu();

            this.idkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaporkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.receptiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredajkorisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();


            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AllowUserToResizeColumns = false;
            this.dgvKorisnici.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvKorisnici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            this.dgvKorisnici.AutoGenerateColumns = false;
            this.dgvKorisnici.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dgvKorisnici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKorisnici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKorisnici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKorisnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkorisnikaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.zaporkaDataGridViewTextBoxColumn,
            this.administratorDataGridViewCheckBoxColumn,
            this.receptiDataGridViewTextBoxColumn,
            this.uredajkorisniciDataGridViewTextBoxColumn});
            this.dgvKorisnici.DataSource = this.korisniciBindingSource;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKorisnici.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKorisnici.EnableHeadersVisualStyles = false;
            this.dgvKorisnici.Location = new System.Drawing.Point(380, 130);

            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKorisnici.RowHeadersVisible = false;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvKorisnici.Size = new System.Drawing.Size(625, 521);

            this.dgvKorisnici.TabIndex = 5;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(SwitchRModel.korisnici);
            // 
            // lblKorisnici
            // 
            this.lblKorisnici.AutoSize = true;
            this.lblKorisnici.BackColor = System.Drawing.Color.Transparent;

            this.lblKorisnici.Font = new System.Drawing.Font("Verdana", 16F);
            this.lblKorisnici.ForeColor = System.Drawing.Color.White;
            this.lblKorisnici.Location = new System.Drawing.Point(500, 80);
            this.lblKorisnici.Name = "lblKorisnici";
            this.lblKorisnici.Size = new System.Drawing.Size(285, 26);
            this.lblKorisnici.TabIndex = 6;
            this.lblKorisnici.Text = "Popis korisnika aplikacije";
            // 
            // switchRMenu1
            // 
            this.switchRMenu1.BackColor = System.Drawing.Color.Transparent;
            this.switchRMenu1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.switchRMenu1.Location = new System.Drawing.Point(-50, 80);
            this.switchRMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.switchRMenu1.Name = "switchRMenu1";
            this.switchRMenu1.Size = new System.Drawing.Size(350, 700);
            this.switchRMenu1.TabIndex = 7;
            // 

            // idkorisnikaDataGridViewTextBoxColumn
            // 
            this.idkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.HeaderText = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.Name = "idkorisnikaDataGridViewTextBoxColumn";
            this.idkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 

            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;

            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;

            // 
            // zaporkaDataGridViewTextBoxColumn
            // 
            this.zaporkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.zaporkaDataGridViewTextBoxColumn.DataPropertyName = "zaporka";
            this.zaporkaDataGridViewTextBoxColumn.HeaderText = "Zaporka";
            this.zaporkaDataGridViewTextBoxColumn.Name = "zaporkaDataGridViewTextBoxColumn";
            this.zaporkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaporkaDataGridViewTextBoxColumn.Visible = false;


            // 
            // administratorDataGridViewCheckBoxColumn
            // 
            this.administratorDataGridViewCheckBoxColumn.DataPropertyName = "administrator";
            this.administratorDataGridViewCheckBoxColumn.HeaderText = "Administrator";
            this.administratorDataGridViewCheckBoxColumn.Name = "administratorDataGridViewCheckBoxColumn";
            this.administratorDataGridViewCheckBoxColumn.ReadOnly = true;
            this.administratorDataGridViewCheckBoxColumn.Width = 120;
            // 
            // receptiDataGridViewTextBoxColumn
            // 
            this.receptiDataGridViewTextBoxColumn.DataPropertyName = "recepti";
            this.receptiDataGridViewTextBoxColumn.HeaderText = "recepti";
            this.receptiDataGridViewTextBoxColumn.Name = "receptiDataGridViewTextBoxColumn";
            this.receptiDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptiDataGridViewTextBoxColumn.Visible = false;
            // 
            // uredajkorisniciDataGridViewTextBoxColumn
            // 
            this.uredajkorisniciDataGridViewTextBoxColumn.DataPropertyName = "uredaj_korisnici";
            this.uredajkorisniciDataGridViewTextBoxColumn.HeaderText = "uredaj_korisnici";
            this.uredajkorisniciDataGridViewTextBoxColumn.Name = "uredajkorisniciDataGridViewTextBoxColumn";
            this.uredajkorisniciDataGridViewTextBoxColumn.ReadOnly = true;
            this.uredajkorisniciDataGridViewTextBoxColumn.Visible = false;
            // 

            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.switchRMenu1);
            this.Controls.Add(this.lblKorisnici);
            this.Controls.Add(this.dgvKorisnici);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAdmin_KeyDown);
            this.Controls.SetChildIndex(this.dgvKorisnici, 0);
            this.Controls.SetChildIndex(this.lblKorisnici, 0);
            this.Controls.SetChildIndex(this.switchRMenu1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SDataGridView dgvKorisnici;
        private SLabel lblKorisnici;
        private System.Windows.Forms.BindingSource korisniciBindingSource;

        private SwitchRComponents.SwitchRMenu switchRMenu1;

        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaporkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn administratorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uredajkorisniciDataGridViewTextBoxColumn;

    }
}