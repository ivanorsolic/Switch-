using SwitchRComponents;
using SwitchRDesign;
using SwitchRModel;
using SwitchЯ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchЯ
{
    public partial class FrmRecepti : SForm
    {
        public korisnici korisnik = null;

        private SwitchRMenu switchRMenu1 = null;
        public FrmRecepti(korisnici k)
        {
            InitializeComponent();

            korisnik = k;

            switchRMenu1 = new SwitchRMenu();
            switchRMenu1.Location = new Point(-50, 80);
            switchRMenu1.Korisnik = korisnik;
            switchRMenu1.pregledRecepata = true;
            switchRMenu1.DodajGumbe();

            this.Controls.Add(switchRMenu1);

            OsvjeziRecepte();
        }

        private void OsvjeziRecepte()
        {
            SwitchRRequest upit = new SwitchRRequest();
            List<recepti> recepti = upit.Get(Resources.RequestURL + "Recipes", new List<recepti>()) as List<recepti>;
            sDataGridView1.DataSource = recepti;
        }

        private void buttonDodajRecept_Click(object sender, EventArgs e)
        {
            FrmDodajRecept tempFrm = new FrmDodajRecept(korisnik);
            var result = tempFrm.ShowDialog();
            OsvjeziRecepte();
        }
    }
}
