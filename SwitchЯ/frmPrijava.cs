using SwitchRComponents;
using SwitchRDesign;
using SwitchRModel;
using SwitchЯ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchЯ
{
    public partial class FrmPrijava : SForm
    {
        #region Globalne varijable i inicijalizacija
        private bool uspjesnaPrijava;
        private korisnici korisnik;
        public FrmPrijava()
        {
            InitializeComponent();
        }
        #endregion

        #region Prijava u sustav
        /// <summary>
        /// Metoda zaslužna za prijavu postojećih korisnika u sustav.
        /// </summary>
        private void Prijava()
        {
            SwitchRRequest upit = new SwitchRRequest();

            korisnik = upit.Get(Resources.RequestURL + "Users?email=" + txtKorisnickoIme.Text + "&pass=" + txtLozinka.Text, new korisnici()) as korisnici;

            if (korisnik == null)
            {
                uspjesnaPrijava = false;
            }
            else
            {
                uspjesnaPrijava = true;
            }
        }
        #endregion

        #region Kontrole za gumbe
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Prijava(); 

            if (uspjesnaPrijava == true)
            {
                FrmStart tempFrm = new FrmStart();
                tempFrm.korisnik = korisnik;
                
                this.Close();
                tempFrm.Show();
                
                
            }
            else
            {
                MessageBox.Show("Molim unesite ispravne korisničke podatke!");
            }
        }

        private void lblRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija tempFrm = new FrmRegistracija();
            tempFrm.ShowDialog();

            this.Close();
        }
        #endregion

        #region Početne postavke forme
        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtKorisnickoIme_MouseClick(object sender, MouseEventArgs e)
        {
            txtKorisnickoIme.Text = "";
        }

        private void txtLozinka_MouseClick(object sender, MouseEventArgs e)
        {
            txtLozinka.Text = "";
        }

        private void txtLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLozinka.PasswordChar = '*';
        }
        #endregion

        #region Pomoć u sustavu (F1)
        //TODO: Složiti pomoć na F1
        private void FrmPrijava_KeyDown(object sender, KeyEventArgs e)
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
    }
}
