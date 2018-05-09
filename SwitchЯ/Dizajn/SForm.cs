using SwitchЯ.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchRDesign
{
    public class SForm : Form
    {
        Label help = new Label();
        public SForm()
        {
            this.SetStyle(
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.UserPaint |
               ControlStyles.DoubleBuffer,
               true);

            Font = new System.Drawing.Font("Arial", 10);
            Crtanja c = new Crtanja(this);
            FormBorderStyle = FormBorderStyle.None;
            Size = new System.Drawing.Size(1000, 700);
            StartPosition = FormStartPosition.CenterScreen;
            Paint += c.FormControlPaint;

            //Dodavanje Loga
            PictureBox logo = new PictureBox();
            logo.Location = new System.Drawing.Point(10, 10);
            logo.Image = Resources.SwitchRLogo;
            logo.BackColor = System.Drawing.Color.Transparent;
            logo.Size = new System.Drawing.Size(100, 20);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(logo);


            // Dodvanje zatvaranja i minimiziranja
            Label exitApplication = new Label();
            exitApplication.Name = "InputExitApplication";
            exitApplication.Text = "X";
            exitApplication.Location = new System.Drawing.Point((Width-40), 10);
            exitApplication.ForeColor = System.Drawing.Color.FromArgb(200,200,200);
            exitApplication.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            exitApplication.BackColor = System.Drawing.Color.Transparent;
            exitApplication.Click += ExitApplication_Click;
            exitApplication.AutoSize = true;
            exitApplication.Size = new System.Drawing.Size(30, 30);
            exitApplication.Cursor = Cursors.Hand;
           this.Controls.Add(exitApplication);

            Label minApplication = new Label();
            minApplication.Name = "InputMinApplication";
            minApplication.Text = "_";
            minApplication.Location = new System.Drawing.Point((Width - 60), 7);
            minApplication.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            minApplication.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            minApplication.Click += MinApplication_Click;
            minApplication.AutoSize = true;
            minApplication.Size = new System.Drawing.Size(30, 30);
            minApplication.BackColor = System.Drawing.Color.Transparent;
            minApplication.Cursor = Cursors.Hand;
            Controls.Add(minApplication);

            // Dodavanje Help-a
            
            help.Name = "InputHelp";
            help.Text = "Help (F1)";
            help.Location = new System.Drawing.Point((Width - 135), 7);
            help.ForeColor = System.Drawing.Color.FromArgb(14,14,14); // 34
            help.Font = new System.Drawing.Font("Arial", 9);
            help.AutoSize = false;
            help.BackColor = System.Drawing.Color.Transparent;
            help.Size = new Size(65, 20);
            help.Padding = new Padding(5, 3, 0, 0);
            help.Paint += Help_Paint;
            help.Cursor = Cursors.Hand;
            help.Click += Help_Click;
            Controls.Add(help);

            // Klik na F1
            
        }


        /// <summary>
        /// Kada je kliknut Help gumb(label).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Help_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        /// <summary>
        /// Metoda za prikazivanje Help-a. 
        /// Namjenjena za prepisivanje.
        /// </summary>
        public virtual void ShowHelp()
        {
            MessageBox.Show("HELP");
        }

       
        /// <summary>
        /// Bojanje HELP gumba(label-a).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Help_Paint(object sender, PaintEventArgs e)
        {
            Crtanja c = new Crtanja();
            GraphicsPath okvir = new GraphicsPath();
            Rectangle trenutniOkvir = help.ClientRectangle;
            trenutniOkvir.Inflate(-1, -1);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(14, 14, 14)), trenutniOkvir);
            trenutniOkvir.Inflate(2, 2);
            okvir = Crtanja.RoundedRect(trenutniOkvir, 5); // Iz pmocnih metoda.
            help.Region = new Region(okvir);
        }

        /// <summary>
        /// Prilikom klika na taj gumb(label) prozor se treba minimizirati.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinApplication_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Kada se klikne na gumb (label) za zatvaranje u gornjem desnom kutu
        /// potrebno je zatvoriti formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
