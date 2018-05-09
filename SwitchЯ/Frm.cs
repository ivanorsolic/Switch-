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
    public partial class Frm : SForm
    {
        #region Globalne varijable i inicijalizacija
        public korisnici korisnik = null;
        private SwitchRMenu switchRMenu1 = null;

        public Frm(korisnici k)
        {
            InitializeComponent();
            korisnik = k;
            switchRMenu1 = new SwitchRMenu();
            switchRMenu1.Location = new Point(-50, 80);
            switchRMenu1.Korisnik = korisnik;
            switchRMenu1.mojProfil = true;
            switchRMenu1.DodajGumbe();

            this.Controls.Add(switchRMenu1);

            
        }
        #endregion

        #region Metoda za izmjenu korisnika
        public void AzurirajKorisnika()
        {
            lblKorisnik.Text = korisnik.naziv;
        }
        public void IzmjenaKorisnika()
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                MessageBox.Show("Molim unesite korisničko ime.");
            }
            else
            {
                korisnik.naziv = txtKorisnickoIme.Text;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Molim unesite e-mail.");
            }
            else
            {
                korisnik.email = txtEmail.Text;
            }

            if (string.IsNullOrEmpty(txtZaporka.Text))
            {
                korisnik.zaporka = "-1";
            }
            else
            {
                korisnik.zaporka = txtZaporka.Text;
            }

            SwitchRRequest upit = new SwitchRRequest();
            //TODO: pozatvarati forme
            upit.Put(Resources.RequestURL + "Users/" + korisnik.id_korisnika, korisnik);

        }
        #endregion

        #region Početne postavke forme
        private void Frm_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            AzurirajKorisnika();
        }

        private void txtZaporka_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtZaporka.PasswordChar = '*';
        }
        #endregion

        #region Kontrole za gumbe

        private void btnSave_Click(object sender, EventArgs e)
        {
            IzmjenaKorisnika();
            this.DialogResult = DialogResult.OK;
            AzurirajKorisnika();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = "";
            txtEmail.Text = "";
            txtZaporka.Text = "";
        }
        #endregion

        #region Pomoć u sustavu (F1)
        private void Frm_KeyDown(object sender, KeyEventArgs e)
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
