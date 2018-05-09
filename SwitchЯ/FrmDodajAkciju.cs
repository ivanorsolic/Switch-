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
    public partial class FrmDodajAkciju : SForm
    {
        public korisnici Korisnik;
        public uredaji Uredaj;
        private SButton odabranoVrijeme;
        public FrmDodajAkciju(korisnici k, uredaji u)
        {
            Korisnik = k;
            Uredaj = u;
            InitializeComponent();

            SwitchRRequest upit = new SwitchRRequest();
            List<recepti> recepti = upit.Get(Resources.RequestURL + "Recipes", new List<recepti>()) as List<recepti>;
            sDataGridView1.DataSource = recepti;

            sButton1.Click += Vrijeme_Click;
            sButton2.Click += Vrijeme_Click;
            sButton3.Click += Vrijeme_Click;
            sButton4.Click += Vrijeme_Click;
            sButton5.Click += Vrijeme_Click;
        }

        private void Vrijeme_Click(object sender, EventArgs e)
        {
            if(odabranoVrijeme != null)
            {
                odabranoVrijeme.ForeColor = Color.White;
            }
            
            odabranoVrijeme = sender as SButton;
            odabranoVrijeme.ForeColor = Color.FromArgb(243, 156, 18);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int vrijeme = 0;

            switch (odabranoVrijeme.Name)
            {
                case "sButton1": vrijeme = 1; break;
                case "sButton2": vrijeme = 10; break;
                case "sButton3": vrijeme = 30; break;
                case "sButton4": vrijeme = 300; break;
                case "sButton5": vrijeme = 3600; break;
            }

            evidencija temp = new evidencija();
            temp.aktivan = false;
            temp.datum = DateTime.Now.AddSeconds(vrijeme);
            temp.id_recepta = (sDataGridView1.SelectedRows[0].DataBoundItem as recepti).id_recepta;
            temp.id_uredaj_korisnika = Uredaj.uredaj_korisnici.Where(l => l.id_korisnika == Korisnik.id_korisnika).FirstOrDefault().id_uredaja_korisnika;

            SwitchRRequest upit = new SwitchRRequest();
            upit.Post(Resources.RequestURL + "Actions", temp);
            this.Close();
        }
    }
}
