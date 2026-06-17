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
    public partial class Form_Edit_KoristiZa : Form
    {
        private KoristiZaBasic _izmena;
        private bool _ucitavanje = true;
        public Form_Edit_KoristiZa(KoristiZaBasic koristiZa)
        {
            InitializeComponent();

            _izmena = koristiZa;

            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            // Postavi prinos
            cBoxPrinos.SelectedValue = _izmena.IdPrinos;

            // Proveri da li je u pitanju traktor ili masina i postavi            
            string tip = DTOManager.VratiTipMehanizacije(_izmena.IdMehanizacija);

            if (tip == "Traktor")
            {
                cBoxTrkatori.Enabled = true;
                cBoxTrkatori.SelectedValue = _izmena.IdMehanizacija;

                cBoxMasina.Enabled = false;
                cBoxMasina.SelectedIndex = -1;
            }
            else
            {
                cBoxMasina.Enabled = true;
                cBoxMasina.SelectedValue = _izmena.IdMehanizacija;

                cBoxTrkatori.Enabled = false;
                cBoxTrkatori.SelectedIndex = -1;
            }

            // Datumi
            dateTimePickerDatumOd.Value = _izmena.DatumOd;

            dateTimePickerDatumOd.Value = _izmena.DatumOd;

            if (_izmena.DatumDo.HasValue)
            {
                checkBoxDatum.Checked = true;
                dateTimePickerDatumDo.Value = _izmena.DatumDo.Value;
                dateTimePickerDatumDo.Enabled = true;
            }
            else
            {
                checkBoxDatum.Checked = false;
                dateTimePickerDatumDo.Enabled = false; // Onemogući kad nije završeno
            }

            _ucitavanje = false;
        }


        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset()
        {
            cBoxTrkatori.Enabled = true;
            cBoxTrkatori.SelectedIndex = -1;

            cBoxMasina.Enabled = true;
            cBoxMasina.SelectedIndex = -1;
        }

        private void Form_Edit_KoristiZa_Load(object sender, EventArgs e)
        {
            var prinosi = DTOManager.VratiSvePrinose();
            cBoxPrinos.DataSource = prinosi;
            cBoxPrinos.DisplayMember = "Tip"; // Ono sto korisnik vidi
            cBoxPrinos.ValueMember = "IdPrinosa"; // Ono sto koristimo za bazu

            var traktori = DTOManager.UcitajTraktore();
            cBoxTrkatori.DataSource = traktori;
            cBoxTrkatori.DisplayMember = "Model"; // Ono sto korisnik vidi
            cBoxTrkatori.ValueMember = "IdMehanizacija"; // Ono sto koristimo za bazu

            var masine = DTOManager.VratiSvePrskalice();
            cBoxMasina.DataSource = masine;
            cBoxMasina.DisplayMember = "Model"; // Ono sto korisnik vidi
            cBoxMasina.ValueMember = "IdMehanizacija"; // Ono sto koristimo za bazu

            UcitajPodatke();
        }

        private void cBoxTrkatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ucitavanje) return;

            if (cBoxTrkatori.SelectedIndex != -1) cBoxMasina.Enabled = false;
        }

        private void cBoxMasina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ucitavanje) return;

            if (cBoxMasina.SelectedIndex != -1) cBoxTrkatori.Enabled = false;
        }

        private void PonistiIzbor_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cBoxTrkatori.SelectedIndex == -1 && cBoxMasina.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo izaberite mehanizaciju.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Odredjivanje novog ID-ja mehanizacije
            int noviIdMehanizacije = cBoxTrkatori.Enabled ? (int)cBoxTrkatori.SelectedValue : (int)cBoxMasina.SelectedValue;

            // Da li je podesavan datum?
            DateTime? noviDatumDo = checkBoxDatum.Checked ? (DateTime?)dateTimePickerDatumDo.Value : null;          

            DTOManager.AzurirajKoriscenje(
                _izmena.IdMehanizacija,
                _izmena.IdPrinos,
                _izmena.DatumOd,
                noviIdMehanizacije,
                noviDatumDo
            );

            MessageBox.Show("Izmene su uspešno sačuvane.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
            

        private void checkBoxDatum_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDatumDo.Enabled = checkBoxDatum.Checked;
        }
    }
}
