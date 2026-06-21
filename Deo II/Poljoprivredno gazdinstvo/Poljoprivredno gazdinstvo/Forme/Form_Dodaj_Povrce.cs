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
    public partial class Form_Dodaj_Povrce : Form
    {
        PovrceBasic povrce;
        public Form_Dodaj_Povrce()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            povrce = new PovrceBasic();
        }

        private void btnDodajPovrce_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo povrće?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                // pročitaj sve iz kontrola: šta sa kategorijom?
                povrce.Naziv = txtNaziv.Text;
                povrce.Lokacija = txtLokacija.Text;
                povrce.Vrsta = "povrce";
                povrce.Povrsina = (double)numPovrsina.Value;
                povrce.KvalitetZemljista = txtKvalitetZemljista.Text; // možda cbx?
                povrce.DatumSetve = dtpDatumSetve.Value;
                povrce.DatumZetvePlanirani = dtpDatumZetvePlanirani.Value;
                povrce.DatumZetveStvarni = dtpDatumZetveStvarni.Value;
                povrce.Status = cbxStatus.SelectedItem.ToString();
                povrce.Komentar = txtKomentar.Text;
                // properties izvedene klase
                povrce.BrojSetviGodisnje = (int)numBrojSetviGodisnje.Value;
                povrce.ZastitneMere = txtZastitneMere.Text;
                povrce.NacinGajenja = cbxNacinGajenja.SelectedItem.ToString();
                povrce.Tip = cbxTipPovrca.SelectedItem.ToString();

                DTOManager.DodajPovrce(this.povrce);
                MessageBox.Show("Uspesno ste dodali novo povrće!");
                this.Close();
            }
        }
    }
}
