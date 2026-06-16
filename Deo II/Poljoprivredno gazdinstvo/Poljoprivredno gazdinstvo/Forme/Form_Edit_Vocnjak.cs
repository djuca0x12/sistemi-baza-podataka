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
    public partial class Form_Edit_Vocnjak : Form
    {
        VocnjaciBasic vocnjak;
        public Form_Edit_Vocnjak()
        {
            InitializeComponent();
        }
        public Form_Edit_Vocnjak(VocnjaciBasic v)
        {
            InitializeComponent();
            vocnjak = v;
        }

        private void btnIzmeniVocnjak_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izvršite izmene voćnjaka?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                // id i kategorija se ne menjaju
                vocnjak.Naziv = txtNaziv.Text;
                vocnjak.Lokacija = txtLokacija.Text;
                vocnjak.Povrsina = (double)numPovrsina.Value;
                vocnjak.KvalitetZemljista = txtKvalitetZemljista.Text;
                vocnjak.DatumSetve = dtpDatumSetve.Value;
                vocnjak.DatumZetvePlanirani = dtpDatumZetvePlanirani.Value;
                vocnjak.DatumZetveStvarni = dtpDatumZetveStvarni.Value;
                vocnjak.Status = cbxStatus.SelectedItem?.ToString();
                vocnjak.Komentar = txtKomentar.Text;
                vocnjak.GodinaSadnje = (int)numGodinaSadnje.Value;
                vocnjak.BrojStabala = (int)numBrojStabala.Value;
                vocnjak.Sorta = txtSorta.Text;
                vocnjak.DatumRezidbe = dtpDatumRezidbe.Value;
                vocnjak.RodniCiklus = txtRodniCiklus.Text;

                DTOManager.IzmeniVocnjak(this.vocnjak);
                MessageBox.Show("Ažuriranje voćnjaka je uspešno izvršeno!");
                this.Close();
            }
        }

        private void Form_Edit_Vocnjak_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
            this.Text = $"Izmena voćnjaka: {vocnjak.Naziv}";
        }

        private void PopuniPodacima()
        {
            // iz objekta u kontrole
            txtNaziv.Text = vocnjak.Naziv;
            txtLokacija.Text = vocnjak.Lokacija;
            numPovrsina.Value = (decimal)vocnjak.Povrsina;
            txtKvalitetZemljista.Text = vocnjak.KvalitetZemljista;
            dtpDatumSetve.Value = vocnjak.DatumSetve > dtpDatumSetve.MinDate ? vocnjak.DatumSetve : DateTime.Now;
            dtpDatumZetvePlanirani.Value = vocnjak.DatumZetvePlanirani > dtpDatumZetvePlanirani.MinDate ? vocnjak.DatumZetvePlanirani : DateTime.Now;
            dtpDatumZetveStvarni.Value = vocnjak.DatumZetveStvarni > dtpDatumZetveStvarni.MinDate ? vocnjak.DatumZetveStvarni : DateTime.Now;
            cbxStatus.SelectedItem = vocnjak.Status;
            txtKomentar.Text = vocnjak.Komentar;
            numGodinaSadnje.Value = (decimal)vocnjak.GodinaSadnje;
            numBrojStabala.Value = (decimal)vocnjak.BrojStabala;
            txtSorta.Text = vocnjak.Sorta;
            dtpDatumRezidbe.Value = vocnjak.DatumRezidbe > dtpDatumRezidbe.MinDate ? vocnjak.DatumRezidbe : DateTime.Now;
            txtRodniCiklus.Text = vocnjak.RodniCiklus;
        }
    }
}
