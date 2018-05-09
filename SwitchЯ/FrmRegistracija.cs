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
    public partial class FrmRegistracija : SForm
    {
        #region Globalne varijable i inicijalizacija
        private bool uspjesnaRegistracija;
        
        public FrmRegistracija()
        {
            InitializeComponent();         
        }
        #endregion

        #region Početne postavke forme i kontrole za rad
        private void FrmRegistracija_Load(object sender, EventArgs e)
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
        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLozinka.PasswordChar = '*';
        }
        #endregion

        #region Metode za registraciju 
        public void OtvoriPrijavu()
        {
            FrmPrijava prijava = new FrmPrijava();
            prijava.ShowDialog(); 
        }

        private void Registracija()
        {
            SwitchRRequest upit = new SwitchRRequest();
            korisnici temp = new korisnici();

            temp.email = txtEmail.Text;
            temp.naziv = txtKorisnickoIme.Text;
            temp.zaporka = txtLozinka.Text;

            korisnici korisnik = upit.Post(Resources.RequestURL + "Users", temp) as korisnici;

            if (korisnik == null)
            {
                uspjesnaRegistracija = false;
            }
            else
            {
                uspjesnaRegistracija = true;
            }

        }
        #endregion

        #region Kontrole za gumbe
        private void sbtnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija();

            if (uspjesnaRegistracija == true)
            {
                OtvoriPrijavu();
                this.Close();
            } 
        }
        #endregion

        #region Pomoć u sustavu (F1)
        private void FrmRegistracija_KeyDown(object sender, KeyEventArgs e)
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
