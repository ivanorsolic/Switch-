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
    public partial class FrmDodajRecept : SForm
    {
        public korisnici Korisnik;
        private List<tipovi_evidnecije> akcije;
        private List<tipovi_evidnecije> odabraneAkcije = new List<tipovi_evidnecije>();
        public FrmDodajRecept(korisnici korisnik)
        {
            Korisnik = korisnik;
            InitializeComponent();

            Label closeWindowsLabel = Controls.Find("InputExitApplication", true).FirstOrDefault() as Label;
            closeWindowsLabel.Visible = false;
            Label minWindowsLabel = Controls.Find("InputMinApplication", true).FirstOrDefault() as Label;
            minWindowsLabel.Visible = false;

            SwitchRRequest upit = new SwitchRRequest();
            akcije = upit.Get(Resources.RequestURL + "Actions", new List<tipovi_evidnecije>()) as List<tipovi_evidnecije>;
            comboBox1.DataSource = akcije;
            comboBox1.ValueMember = "id_tipa";
            comboBox1.DisplayMember = "naziv";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajAkciju_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            tipovi_evidnecije temp = akcije[selectedIndex];
            odabraneAkcije.Add(temp);
            OsvjeziOdabraneAkcije();
        }

        private void OsvjeziOdabraneAkcije()
        {
            sDataGridView1.DataSource = null;
            sDataGridView1.Refresh();
            sDataGridView1.DataSource = odabraneAkcije;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(odabraneAkcije.Count > 0 && !String.IsNullOrEmpty(sTextBox1.Text))
            {
                recepti noviRecept = new recepti();
                noviRecept.datum = DateTime.Now;
                noviRecept.id_korisnika = Korisnik.id_korisnika;
                noviRecept.naziv = sTextBox1.Text;

                List<recepti_akcije> listaAkcija = new List<recepti_akcije>();

                foreach(tipovi_evidnecije t in odabraneAkcije)
                {
                    recepti_akcije temp = new recepti_akcije();
                    temp.id_tipa_loga = t.id_tipa;
                    listaAkcija.Add(temp);
                }

                noviRecept.recepti_akcije = listaAkcija;


                SwitchRRequest upit = new SwitchRRequest();
                upit.Post(Resources.RequestURL + "Recipes", noviRecept);

                this.Close();

            }
            else
            {
                MessageBox.Show("Molimo vas da uneste naziv recepta i odaberte barem jednu akciju.");
            }
        }
    }
}
