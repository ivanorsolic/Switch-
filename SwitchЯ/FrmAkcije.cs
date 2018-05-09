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
    public partial class FrmAkcije : SForm
    {
        public korisnici Korisnik;
        public uredaji Uredaj;
        public FrmAkcije(korisnici k, uredaji u)
        {
            Korisnik = k;
            Uredaj = u;
            InitializeComponent();
            OsvjeziListuEvidencija();
            labelNazivUredaja.Text = Uredaj.uredaj_korisnici.Where(l => l.id_korisnika == Korisnik.id_korisnika).FirstOrDefault().naziv_uredaja;
        }

        private void OsvjeziListuEvidencija()
        {
            SwitchRRequest upit = new SwitchRRequest();
            List<evidencija> listaEvidencija = upit.Get(Resources.RequestURL + "Actions/" + Uredaj.id_uredaja, new List<evidencija>()) as List<evidencija>;
            sDataGridView1.DataSource = listaEvidencija;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FrmDodajAkciju frm = new FrmDodajAkciju(Korisnik, Uredaj);
            frm.ShowDialog();
            OsvjeziListuEvidencija();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SwitchRRequest upit = new SwitchRRequest();
            int id = (sDataGridView1.SelectedRows[0].DataBoundItem as evidencija).id_loga;
            upit.Delete(Resources.RequestURL + "Actions/" + id);
            OsvjeziListuEvidencija();
        }
    }
}
