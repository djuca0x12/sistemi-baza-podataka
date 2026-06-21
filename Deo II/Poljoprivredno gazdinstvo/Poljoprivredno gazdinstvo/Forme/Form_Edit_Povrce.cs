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
    public partial class Form_Edit_Povrce : Form
    {
        PovrceBasic povrce;
        public Form_Edit_Povrce()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }
        public Form_Edit_Povrce(PovrceBasic p)
        {
            InitializeComponent();
            povrce = p;
        }

        private void Form_Edit_Povrce_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
            this.Text = $"Izmena povrća: {povrce.Naziv}";
        }
        private void PopuniPodacima()
        {
            // iz objekta u kontrole
            txtNaziv.Text = povrce.Naziv;
            txtLokacija.Text = povrce.Lokacija;
            numPovrsina.Value = (decimal)povrce.Povrsina;
            txtKvalitetZemljista.Text = povrce.KvalitetZemljista;
            dtpDatumSetve.Value = povrce.DatumSetve > dtpDatumSetve.MinDate ? povrce.DatumSetve : DateTime.Now;
            dtpDatumZetvePlanirani.Value = povrce.DatumZetvePlanirani > dtpDatumZetvePlanirani.MinDate ? povrce.DatumZetvePlanirani : DateTime.Now;
            dtpDatumZetveStvarni.Value = povrce.DatumZetveStvarni > dtpDatumZetveStvarni.MinDate ? povrce.DatumZetveStvarni : DateTime.Now;
            cbxStatus.SelectedItem = povrce.Status;
            txtKomentar.Text = povrce.Komentar;
            numBrojSetviGodisnje.Value = (decimal)povrce.BrojSetviGodisnje;
            txtZastitneMere.Text = povrce.ZastitneMere;
            cbxNacinGajenja.SelectedItem = povrce.NacinGajenja;
            cbxTipPovrca.SelectedItem = povrce.Tip;
        }

        private void btnIzmeniPovrce_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izvršite izmene povrća?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                // id i kategorija se ne menjaju
                povrce.Naziv = txtNaziv.Text;
                povrce.Lokacija = txtLokacija.Text;
                povrce.Povrsina = (double)numPovrsina.Value;
                povrce.KvalitetZemljista = txtKvalitetZemljista.Text;
                povrce.DatumSetve = dtpDatumSetve.Value;
                povrce.DatumZetvePlanirani = dtpDatumZetvePlanirani.Value;
                povrce.DatumZetveStvarni = dtpDatumZetveStvarni.Value;
                povrce.Status = cbxStatus.SelectedItem?.ToString();
                povrce.Komentar = txtKomentar.Text;
                povrce.BrojSetviGodisnje = (int)numBrojSetviGodisnje.Value;
                povrce.ZastitneMere = txtZastitneMere.Text;
                povrce.NacinGajenja = cbxNacinGajenja.SelectedItem?.ToString();
                povrce.Tip = cbxTipPovrca.SelectedItem?.ToString();

                DTOManager.IzmeniPovrce(this.povrce);
                MessageBox.Show("Ažuriranje povrća je uspešno izvršeno!");
                this.Close();
            }
        }
    }
}