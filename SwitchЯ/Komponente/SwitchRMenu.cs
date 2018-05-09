using SwitchRDesign;
using SwitchRModel;
using SwitchЯ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchRComponents
{
    class SwitchRMenu : SIzbornik
    {
        public korisnici Korisnik = null;
        public bool mojiUredaji = false;
        public bool mojProfil = false;
        public bool pregledKorisnika = false;
        public bool pregledRecepata = false;
        public bool dodavanjeUredjaja = false;


        public SwitchRMenu()
        {
            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer,
            true);
        }


        public void DodajGumbe()
        {
            this.AddItem("mojiUredaji", "Moji uređaji", mojiUredaji_Click, mojiUredaji);

            this.AddItem("dodavanjeUredjaja", "Dodavanje uređaja", dodavanjeUredjaja_Click, dodavanjeUredjaja);

            this.AddItem("pregledRecepata", "Recepti", pregledRecepata_Click, pregledRecepata);
            this.AddItem("mojProfil", "Moj profil", mojProfil_Click, mojProfil);

            if (Korisnik.administrator)
            {
               this.AddItem("pregledKorisnika", "Pregled korisnika", pregledKorisnika_Click, pregledKorisnika);
            }
        }

        #region Eventovi klika na gumbe navigacije
        public void mojProfil_Click(object sender, EventArgs e)
        {

            Frm tempFrm = new Frm(Korisnik);
      
            tempFrm.Show();
            ZatvoriTrenutnu();
        }

        public void mojiUredaji_Click(object sender, EventArgs e)
        {
            FrmStart tempFrm = new FrmStart();
            tempFrm.korisnik = Korisnik;
            tempFrm.Show();
            ZatvoriTrenutnu();
        }

        public void pregledKorisnika_Click(object sender, EventArgs e)
        {
            FrmAdmin tempFrm = new FrmAdmin();
            tempFrm.korisnik = Korisnik;
            tempFrm.Show();
            ZatvoriTrenutnu();
        }


        public void dodavanjeUredjaja_Click(object sender, EventArgs e)
        {
            FrmUredaj tempFrm = new FrmUredaj(Korisnik);
            tempFrm.Show();
            ZatvoriTrenutnu();
        }


        public void pregledRecepata_Click(object sender, EventArgs e)
        {
            FrmRecepti tempFrm = new FrmRecepti(Korisnik);
 
            tempFrm.Show();
            ZatvoriTrenutnu();
        }
        #endregion



        #region PomocneMetode 
        private static void ZatvoriTrenutnu()
        {
            Form trenutno = Application.OpenForms[0];
            trenutno.Close();
        }

        #endregion

    }
}
