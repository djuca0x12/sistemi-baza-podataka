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
            zitarica = new ZitariceBasic();
        }

        private void btnDodajZitaricu_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu žitaricu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                // pročitaj sve iz kontrola: šta sa kategorijom?
                zitarica.Naziv = txtNaziv.Text;
                zitarica.Lokacija = txtLokacija.Text;
                zitarica.Vrsta = "zitarice";    // ili se nekako prenosi od useva idk?
                zitarica.Povrsina = (double)numPovrsina.Value;
                zitarica.KvalitetZemljista = txtKvalitetZemljista.Text; // možda cbx?
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
    }
}
