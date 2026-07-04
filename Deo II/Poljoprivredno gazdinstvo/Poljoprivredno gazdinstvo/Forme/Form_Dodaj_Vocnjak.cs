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
    public partial class Form_Dodaj_Vocnjak : Form
    {
        VocnjaciBasic vocnjak;
        public Form_Dodaj_Vocnjak()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            vocnjak = new VocnjaciBasic();
        }

        private void btnDodajVocnjak_Click(object sender, EventArgs e)
        {

            string unetiNaziv = txtNaziv.Text.Trim();
            string unetaLokacija = txtLokacija.Text.Trim();

            if (string.IsNullOrEmpty(unetiNaziv) || string.IsNullOrEmpty(unetaLokacija))
            {
                MessageBox.Show("Naziv i lokacija su obavezna polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DTOManager.DaLiPostojiUsevSaNazivomILokacijom(unetiNaziv, unetaLokacija, vocnjak.Id))
            {
                MessageBox.Show("Druga žitarica (usev) sa ovim nazivom na datoj lokaciji već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // da li su uneti validni datumi?
            if (dtpDatumSetve.Value > dtpDatumZetvePlanirani.Value)
            {
                MessageBox.Show("Datum setve mora biti pre datuma žetve!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumSetve.Focus();
                return;
            }

            if (dtpDatumSetve.Value > dtpDatumZetveStvarni.Value)
            {
                MessageBox.Show("Datum setve mora biti pre stvarnog datuma žetve!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumZetveStvarni.Focus();
                return;
            }

            if (dtpDatumZetvePlanirani.Value > dtpDatumZetveStvarni.Value)
            {
                MessageBox.Show("Planirani datum žetve mora biti pre stvarnog datuma žetve!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumZetvePlanirani.Focus();
                return;
            }

            string poruka = "Da li zelite da dodate novi voćnjak?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                
                vocnjak.Naziv = txtNaziv.Text;
                vocnjak.Lokacija = txtLokacija.Text;
                vocnjak.Vrsta = "voce";   
                vocnjak.Povrsina = (double)numPovrsina.Value;
                vocnjak.KvalitetZemljista = txtKvalitetZemljista.Text;
                vocnjak.DatumSetve = dtpDatumSetve.Value;
                vocnjak.DatumZetvePlanirani = dtpDatumZetvePlanirani.Value;
                vocnjak.DatumZetveStvarni = dtpDatumZetveStvarni.Value;
                vocnjak.Status = cbxStatus.SelectedItem.ToString();
                vocnjak.Komentar = txtKomentar.Text;
                // properties izvedene klase
                vocnjak.GodinaSadnje = (int)numGodinaSadnje.Value;
                vocnjak.BrojStabala = (int)numBrojStabala.Value;
                vocnjak.Sorta = txtSorta.Text;
                vocnjak.DatumRezidbe = dtpDatumRezidbe.Value;
                vocnjak.RodniCiklus = txtRodniCiklus.Text;

                DTOManager.DodajVocnjak(this.vocnjak);
                MessageBox.Show("Uspesno ste dodali novi voćnjak!");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}