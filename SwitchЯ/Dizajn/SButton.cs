using System.Drawing;
using System.Windows.Forms;

namespace SwitchRDesign
{
    class SButton : Button
    {
        public SButton()
        {
            base.BackColor = Color.FromArgb(41, 128, 185);
            base.FlatStyle = FlatStyle.Flat;
            base.ForeColor = Color.White;
            base.FlatAppearance.BorderSize = 0;
            base.Size = new Size(300, 35);
            base.Font = new Font("Arial", 11, FontStyle.Bold);
            Crtanja c = new Crtanja(this);
            Paint += c.ButtonPaint;
            MouseEnter += SButton_MouseEnter;
            MouseLeave += SButton_MouseLeave;
        }

        private void SButton_MouseLeave(object sender, System.EventArgs e)
        {
            int r = BackColor.R + 30 <= 255 ? BackColor.R + 30 : 255;
            int g = BackColor.G + 30 <= 255 ? BackColor.G + 30 : 255;
            int b = BackColor.B + 30 <= 255 ? BackColor.B + 30 : 255;
            BackColor = Color.FromArgb(r, g, b);
        }

        private void SButton_MouseEnter(object sender, System.EventArgs e)
        {
            int r = BackColor.R - 30 >= 0 ? BackColor.R - 30 : 0;
            int g = BackColor.G - 30 >= 0 ? BackColor.G - 30 : 0;
            int b = BackColor.B - 30 >= 0 ? BackColor.B - 30 : 0;
            BackColor = Color.FromArgb(r, g, b);
        }
    }
}
