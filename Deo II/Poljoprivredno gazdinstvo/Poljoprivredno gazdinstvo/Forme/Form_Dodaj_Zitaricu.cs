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
    public partial class Form_Dodaj_Zitaricu : Form
    {
        ZitariceBasic zitarica;
        public Form_Dodaj_Zitaricu()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            zitarica = new ZitariceBasic();
        }

        private void btnDodajZitaricu_Click(object sender, EventArgs e)
        {            
            string unetiNaziv = txtNaziv.Text.Trim();
            string unetaLokacija = txtLokacija.Text.Trim();

            if (string.IsNullOrEmpty(unetiNaziv) || string.IsNullOrEmpty(unetaLokacija))
            {
                MessageBox.Show("Naziv i lokacija su obavezna polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // provera jedinstvenosti, jer moraju da budu unique u bazi
            if (DTOManager.DaLiPostojiUsevSaNazivomILokacijom(unetiNaziv, unetaLokacija, zitarica.Id))
            {
                MessageBox.Show("Naziv i lokacija useva moraju da budu jedinstveni u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string poruka = "Da li zelite da dodate novu žitaricu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                zitarica.Naziv = txtNaziv.Text;
                zitarica.Lokacija = txtLokacija.Text;
                zitarica.Vrsta = "zitarice";    
                zitarica.Povrsina = (double)numPovrsina.Value;
                zitarica.KvalitetZemljista = txtKvalitetZemljista.Text; 
                zitarica.DatumSetve = dtpDatumSetve.Value;
                zitarica.DatumZetvePlanirani = dtpDatumZetvePlanirani.Value;
                zitarica.DatumZetveStvarni = dtpDatumZetveStvarni.Value;
                zitarica.Status = cbxStatus.SelectedItem.ToString();
                zitarica.Komentar = txtKomentar.Text;
                // properties izvedene klase
                zitarica.GustinaSetve = (double)numGustinaSetve.Value;
                zitarica.KolicinaSemenaPoHektaru = (double)numKolicinaSemenaPoHektaru.Value;
                zitarica.PrinosPoHektaru = (double)numPrinosPoHektaru.Value;
                zitarica.Tip = cbxTipZitarice.SelectedItem.ToString();
                zitarica.TipDjubrenja = cbxTipDjubrenja.SelectedItem.ToString();

                DTOManager.DodajZitaricu(this.zitarica);
                MessageBox.Show("Uspesno ste dodali novu žitaricu!");
                this.Close();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
