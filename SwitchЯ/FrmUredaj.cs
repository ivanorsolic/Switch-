using HotspotTest;
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
    public partial class FrmUredaj : SForm
    {
        public bool isHotspot = false;
        public korisnici Korisnik;
        private SwitchRMenu switchRMenu1 = null;
        public FrmUredaj(korisnici korisnik)
        {
            Korisnik = korisnik;
            InitializeComponent();

            switchRMenu1 = new SwitchRMenu();
            switchRMenu1.Location = new Point(-50, 80);
            switchRMenu1.Korisnik = korisnik;
            switchRMenu1.dodavanjeUredjaja = true;
            switchRMenu1.DodajGumbe();
            this.Controls.Add(switchRMenu1);
        }

            

        private void btnHotspot_Click(object sender, EventArgs e)
        {
            if (!isHotspot)
            {
                Hotspot.GoHotspot(true);
                btnHotspot.BackColor = Color.FromArgb(39, 174, 96);
                isHotspot = true;
            }
            else
            {
                Hotspot.GoHotspot(false);
                btnHotspot.BackColor = Color.FromArgb(192, 57, 43);
                isHotspot = false;
            }
            
        }

        private void btnBazna_Click(object sender, EventArgs e)
        {
            string ip = Hotspot.ARP();
            string command = "sudo wpa_passphrase " + textSSID.Text + " " + textLozinka.Text + " > /etc/wpa_supplicant/wpa_supplicant.conf";
            command += "; sudo reboot";
            Hotspot.SSH(ip, command);
            MessageBox.Show("Molimo pričekajte minutu dok se bazna stanice ponovno pokrene.");
            Thread.Sleep(60 * 1000);
            MessageBox.Show("Bazna stanica se ponovno pokrenula.");
            SwitchRRequest upit = new SwitchRRequest();
            upit.Get("http://192.168.1.6:8000/api/Bazna/" + Korisnik.id_korisnika + "/" + textJedinstveni.Text, new uredaji());
            Hotspot.GoHotspot(false);
        }

        private void btnUređaj_Click(object sender, EventArgs e)
        {
            uredaj_korisnici uredaj = new uredaj_korisnici();
            uredaj.id_korisnika = Korisnik.id_korisnika;
            uredaj.datum_registracije_uredaja = DateTime.Now;
            uredaj.naziv_uredaja = txtNazivUredaja.Text;
            uredaji tUredaj = new uredaji();
            tUredaj.uniqe_code = txtJedinstveniUredaja.Text;
            uredaj.uredaji = tUredaj;

            SwitchRRequest upit = new SwitchRRequest();
            upit.Post(Resources.RequestURL + "UserDevice/", uredaj);
        }
    }
}
