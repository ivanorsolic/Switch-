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
    public partial class FrmAdmin : SForm
    {
        #region Inicijalizacija sa prikazom na Data Grid View kontroli
        public korisnici korisnik = null;
        public FrmAdmin()
        {
            InitializeComponent();
            SwitchRRequest upit = new SwitchRRequest();
            List<korisnici> listaKorisnika = upit.Get(Resources.RequestURL + "Users", new List<korisnici>()) as List<korisnici>;
            dgvKorisnici.DataSource = listaKorisnika;
        }
        #endregion

        #region Pomoć u sustavu (F1)
        private void FrmAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.F1)
            {
                ShowHelp();
            }
        }

        public override void ShowHelp()
        {
            MessageBox.Show("Izmjenjanea poruka");
        }
        #endregion

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            switchRMenu1.Korisnik = korisnik;
            switchRMenu1.pregledKorisnika = true;
            switchRMenu1.DodajGumbe();
        }
    }
}
