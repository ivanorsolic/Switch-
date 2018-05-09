using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchRDesign
{
    public partial class SIzbornik : UserControl
    {
        private int currentItem = 2;
        Func<int> tempMetodaZaClick = null;
        public SIzbornik()
        {
            InitializeComponent();
            pictureBox1.SendToBack();
        }

        public void AddItem(string name, string text, EventHandler metodaZaClick, bool active)
        {
            Button tempButton = new Button();
            tempButton.Name = name;
            tempButton.Text = text;
            tempButton.Width = 250;
            tempButton.Height = 45;
            tempButton.Location = new Point(57, (currentItem * 50));
            tempButton.FlatStyle = FlatStyle.Flat;
            tempButton.Font = new Font("Arial", 12, FontStyle.Bold);
            tempButton.TextAlign = ContentAlignment.MiddleCenter;
            tempButton.FlatAppearance.BorderSize = 0;

            if (active)
            {
                tempButton.BackColor = Color.FromArgb(231, 76, 60);
                tempButton.ForeColor = Color.White;
            }
            else
            {
                tempButton.BackColor = Color.Transparent;
                tempButton.ForeColor = Color.FromArgb(150,150,150);
                tempButton.MouseEnter += TempButton_MouseEnter;
                tempButton.MouseLeave += TempButton_MouseLeave;
            }
            
            tempButton.Click += metodaZaClick;
    
            this.Controls.Add(tempButton);
            tempButton.BringToFront();
            currentItem++;
        }

        private void TempButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.FromArgb(150, 150, 150);
            (sender as Button).BackColor = Color.Transparent;
            
        }

        private void TempButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.White;
            (sender as Button).BackColor = Color.Transparent;
            
        }
    }
}
