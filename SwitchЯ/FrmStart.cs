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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchЯ
{
    public partial class FrmStart : SForm
    {
        #region Globalne varijable i inicijalizacija
        public korisnici korisnik = new korisnici();
        private SwitchRMenu switchRMenu1 = null; 


        public FrmStart()
        {
            InitializeComponent();
        }
        #endregion

        #region Metode za glavnu formu

        private void OtvoriKorisnika()
        {
            Frm tempFrm = new Frm(korisnik);
            
            var result = tempFrm.ShowDialog();

            if (result == DialogResult.OK)
            {
                korisnik = tempFrm.korisnik;
            }

        }
        #endregion

        #region Kontrole za formu, gumbe i labele
        private void btnPregledKorisnika_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.ShowDialog();

        }
        #endregion


        private void FrmStart_Load(object sender, EventArgs e)
        {
            SwitchRRequest upit = new SwitchRRequest();
            List<uredaji> listaUredaja = upit.Get(Resources.RequestURL + "UserDevice/" + korisnik.id_korisnika, new List<uredaji>()) as List<uredaji>;


            dgvUredaji.DataSource = listaUredaja;

        }

        private void DodajMenu()
        {
            switchRMenu1.Korisnik = korisnik;
            switchRMenu1.mojiUredaji = true;
            switchRMenu1.DodajGumbe();
        }


        

       

        #region Pomoć u sustavu (F1)
        /// <summary>
        /// Metoda koja registrira kada korisnik stisne neki gumb na FrmStart
        /// 
        /// Posebni gumbi: 
        /// - F1 -> Otvara pomoć
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStart_KeyDown(object sender, KeyEventArgs e)
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


        private void FrmStart_Shown(object sender, EventArgs e)
        {
            
            switchRMenu1 = new SwitchRMenu();
            switchRMenu1.Location = new Point(-50, 80);
            this.Controls.Add(switchRMenu1);
            DodajMenu();
        }

        private void dgvUredaji_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            uredaji odabraniUredaj = dgvUredaji.SelectedRows[0].DataBoundItem as uredaji;
            FrmAkcije f = new FrmAkcije(korisnik, odabraniUredaj);
            f.ShowDialog();
        }
    }
}
