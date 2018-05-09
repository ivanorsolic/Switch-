using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SwitchRDesign
{
    public class Crtanja
    {
        public Form Forma { get; set; }
        public Button Button { get; set; }

        public TextBox TextBox { get; set; }

        public ComboBox ComboBox { get; set; }

        #region Konstruktori

        public Crtanja()
        {

        }

        public Crtanja(Form f)
        {
            Forma = f;
        }

        public Crtanja(Button b)
        {
            Button = b;
        }

        public Crtanja(TextBox t)
        {
            TextBox = t;
           
        }

        public Crtanja(ComboBox c)
        {
            ComboBox = c;

        }
        #endregion

        #region MetodeZaCrtanjeKomponenata

        #region Crtanjeforme
        /// <summary>
        /// Metoda koja se bavi frabanjem forme. 
        /// Potrebno ju je pozvati tijekom bojanja forma ondosno na paint
        /// npr. 
        /// form.Paint += FormControlPaint();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FormControlPaint(object sender, PaintEventArgs e)
        {
            GraphicsPath okvir = new GraphicsPath();
            Rectangle trenutniOkvir = Forma.ClientRectangle;

            //Bojanje 
            using (LinearGradientBrush crniGradient = new LinearGradientBrush(trenutniOkvir, Color.FromArgb(34, 34, 34), Color.FromArgb(17, 17, 17), 90F))
            {
                e.Graphics.FillRectangle(crniGradient, trenutniOkvir);
            }

            //Zaokruženi rubovi
            okvir = RoundedRect(trenutniOkvir, 5); // Iz pmocnih metoda.
            Forma.Region = new Region(okvir);

        }
        #endregion

        #region CranjeGumba
        /// <summary>
        /// Metoda za crtanje gumba.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ButtonPaint(object sender, PaintEventArgs e)
        {
            GraphicsPath okvir = new GraphicsPath();
            Rectangle trenutniOkvir = Button.ClientRectangle;
            //Zaokruženi rubovi
            okvir = RoundedRect(trenutniOkvir, 5); // Iz pmocnih metoda.
            Button.Region = new Region(okvir);
        }
        #endregion

        #region CrtanjeTextBoxa
        /// <summary>
        /// Metoda za crtanje text boxa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TextBoxPaint(object sender, PaintEventArgs e)
        {
            GraphicsPath okvir = new GraphicsPath();
            Rectangle trenutniOkvir = TextBox.ClientRectangle;
            okvir = RoundedRect(trenutniOkvir, 5); // Iz pmocnih metoda.
            TextBox.Region = new Region(okvir);

        }
        #endregion

        #region CrtanjeComboBoxa
        /// <summary>
        /// Metoda za crtanje combo boxa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ComboBoxPaint(object sender, PaintEventArgs e)
        {
            GraphicsPath okvir = new GraphicsPath();
            Rectangle trenutniOkvir = ComboBox.ClientRectangle;
            okvir = RoundedRect(trenutniOkvir, 5); // Iz pmocnih metoda.
            ComboBox.Region = new Region(okvir);

        }
        #endregion

        #endregion



        #region PomocneMetode

        #region MetodaZaZaboljenjeKuteve

        /// <summary>
        /// Vraća putanju koja ima zaobljenje rubove. 
        /// Preuzeto i prilagođeno sa: https://stackoverflow.com/questions/33853434/how-to-draw-a-rounded-rectangle-in-c-sharp
        /// </summary>
        /// <param name="bounds">Pravokutnik kojem želimo zaobliti kuteve.</param>
        /// <param name="radius">Koliko kuteve želimo zaobliti.</param>
        /// <returns></returns>
        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        #endregion

        #endregion
    }
}
