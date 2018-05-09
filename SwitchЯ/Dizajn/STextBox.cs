using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SwitchRDesign
{
    class STextBox : TextBox
    {
        public STextBox()
        {
           // SetStyle(ControlStyles.UserPaint, true);
            AutoSize = false;
            base.Size = new System.Drawing.Size(300, 35);
            base.BorderStyle = BorderStyle.None;
            Crtanja c = new Crtanja(this);
            Paint += c.TextBoxPaint;
            TextAlign = HorizontalAlignment.Left;
            Font = new Font("Arial", 11);
        }

     
    }
}
