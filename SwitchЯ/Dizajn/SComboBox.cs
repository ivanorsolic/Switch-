using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SwitchRDesign
{
    class SComboBox : ComboBox
    {
        public SComboBox()
        {
           // SetStyle(ControlStyles.UserPaint, true);
            AutoSize = false;
            base.Size = new System.Drawing.Size(300, 35);
            
            Crtanja c = new Crtanja(this);
            Paint += c.ComboBoxPaint;
           
            Font = new Font("Arial", 11);
        }

     
    }
}
