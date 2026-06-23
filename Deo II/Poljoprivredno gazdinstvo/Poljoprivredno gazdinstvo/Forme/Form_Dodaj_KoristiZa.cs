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
    public partial class Form_Dodaj_KoristiZa : Form
    {
        public Form_Dodaj_KoristiZa()
        {
            InitializeComponent();

            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            //Reset();
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

        private void PonistiIzbor_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Form_Dodaj_KoristiZa_Load(object sender, EventArgs e)
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

            cBoxTrkatori.Enabled = true;
            cBoxTrkatori.SelectedIndex = -1;

            cBoxMasina.Enabled = true;
            cBoxMasina.SelectedIndex = -1;
        }

        private void cBoxTrkatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxTrkatori.SelectedIndex != -1)
            {
                cBoxMasina.Enabled = false;
                cBoxMasina.SelectedIndex = -1; // Ocisti izbor mašina
            }
        }

        private void cBoxMasina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxMasina.SelectedIndex != -1)
            {
                cBoxTrkatori.Enabled = false;
                cBoxTrkatori.SelectedIndex = -1; // Ocisti izbor traktora
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            // Provera da li korisnik izabrao prinos
            if (cBoxPrinos.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo izaberite prinos iz liste.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Provera da li je izabrn traktor ili masina:
            int izabraniIdMehanizacije = -1;
         
            if (cBoxTrkatori.Enabled && cBoxTrkatori.SelectedIndex != -1)
            {
                izabraniIdMehanizacije = (int)cBoxTrkatori.SelectedValue;
            }
            else if (cBoxMasina.Enabled && cBoxMasina.SelectedIndex != -1)
            {
                izabraniIdMehanizacije = (int)cBoxMasina.SelectedValue;
            }
            
            // Da li je nesto izabrano uopste:
            if (izabraniIdMehanizacije == -1)
            {
                MessageBox.Show("Morate izabrati ili traktor ili mašinu za povezivanje sa prinosom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idPrinosa = (int)cBoxPrinos.SelectedValue;

            DTOManager.PoveziMehanizacijuIPrinos(izabraniIdMehanizacije, idPrinosa, dateTimePickerDatumOd.Value);

            MessageBox.Show("Uspešno povezano!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
