using System.Drawing;
using System.Windows.Forms;

namespace SwitchRDesign
{
    class SDataGridView : DataGridView
    {
       public SDataGridView()
        {
           
            BackgroundColor = Color.FromArgb(34,34,34);
            BorderStyle = BorderStyle.None;
            RowHeadersVisible = false;
            EnableHeadersVisualStyles = false;
            ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34,34,34);
            this.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Italic);
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            ReadOnly = true;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34,34,34);
            AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            DefaultCellStyle.BackColor = Color.FromArgb(15,15,15);
            DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            DefaultCellStyle.ForeColor = Color.White;

            
            
        } 
    }
}
