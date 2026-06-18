using Poljoprivredno_gazdinstvo.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poljoprivredno_gazdinstvo.Forme
{
    public partial class Form_Dodaj_Krmu : Form
    {
        KrmnoBiljeBasic krma;
        public Form_Dodaj_Krmu()
        {
            InitializeComponent();
            krma = new KrmnoBiljeBasic();
        }

        private void btnDodajKrmnoBilje_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo krmno bilje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                // pročitaj sve iz kontrola: šta sa kategorijom?
                krma.Naziv = txtNaziv.Text;
                krma.Lokacija = txtLokacija.Text;
                krma.Vrsta = "krmno bilje";
                krma.Povrsina = (double)numPovrsina.Value;
                krma.KvalitetZemljista = txtKvalitetZemljista.Text; // možda cbx?
                krma.DatumSetve = dtpDatumSetve.Value;
                krma.DatumZetvePlanirani = dtpDatumZetvePlanirani.Value;
                krma.DatumZetveStvarni = dtpDatumZetveStvarni.Value;
                krma.Status = cbxStatus.SelectedItem.ToString();
                krma.Komentar = txtKomentar.Text;
                // properties izvedene klase
                krma.VrstaKrme = cbxVrstaKrme.SelectedItem.ToString();
                krma.BrojKosnjiGodisnje = (int)numBrojKosnjiGodisnje.Value;
                krma.ProcenatProteina = (int)numProcenatProteina.Value;
                krma.IshranaStokeFlag = chkZaIshranuStoke.Checked ? 1 : 0;
                krma.ZaProdajuFlag = chkZaProdaju.Checked ? 1 : 0;

                DTOManager.DodajKrmnoBilje(this.krma);
                MessageBox.Show("Uspesno ste dodali novo krmno bilje!");
                this.Close();
            }
        }
    }
}
