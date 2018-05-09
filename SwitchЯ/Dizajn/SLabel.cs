using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchRDesign
{
    class SLabel : Label
    {

        public SLabel()
        {
            BackColor = System.Drawing.Color.Transparent;
            ForeColor = System.Drawing.Color.White;
            AutoSize = false;
            Height = 35;
        }

    }
}
