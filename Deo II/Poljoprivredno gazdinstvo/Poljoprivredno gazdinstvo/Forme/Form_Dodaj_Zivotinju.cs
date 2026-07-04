using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Poljoprivredno_gazdinstvo.Forme
{
    public partial class Form_Dodaj_Zivotinju : Form
    {
        ZivotinjeBasic zivotinja;
        public Form_Dodaj_Zivotinju()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            zivotinja = new ZivotinjeBasic();
        }

        private void btnDodajZivotinju_Click(object sender, EventArgs e)
        {
            string unetiBrojUha = txtBrojUha.Text.Trim();

            if (string.IsNullOrEmpty(unetiBrojUha))
            {
                MessageBox.Show("Broj uha je obavezno polje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBrojUha.Focus();
                return;
            }

            DateTime rodjenje = dtpDatumRodjenja.Value.Date;
            DateTime ulazak = dtpDatumUlaska.Value.Date;
            DateTime danas = DateTime.Today;

            if (rodjenje > danas)
            {
                MessageBox.Show("Datum rođenja ne može biti u budućnosti!", "Greška u datumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDatumRodjenja.Focus();
                return;
            }

            if (ulazak < rodjenje)
            {
                MessageBox.Show("Datum ulaska na gazdinstvo mora biti nakon datuma rođenja životinje!", "Greška u datumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDatumUlaska.Focus();
                return;
            }

            if (DTOManager.DaLiPostojiZivotinjaSaBrojemUha(unetiBrojUha, this.zivotinja.IdZivotinje))
            {
                MessageBox.Show("Druga životinja sa ovim brojem uha već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrojUha.Focus();
                return;
            }

            string poruka = "Da li zelite da dodate novu životinju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                zivotinja.BrojUha = txtBrojUha.Text;
                zivotinja.Vrsta = txtVrsta.Text;
                zivotinja.Pol = cbxPol.SelectedItem.ToString()[0];
                zivotinja.Rasa = txtRasa.Text;
                zivotinja.BrojJedinki = (int)numBrojJedinki.Value;
                zivotinja.DatumRodjenja = dtpDatumRodjenja.Value;
                zivotinja.DatumUlaska = dtpDatumUlaska.Value;
                zivotinja.Tezina = (double)numTezina.Value;
                zivotinja.Status = cbxStatus.Text;
                zivotinja.Komentar = txtKomentar.Text;

                DTOManager.DodajZivotinju(this.zivotinja);
                MessageBox.Show("Uspesno ste dodali novu životinju!");
                this.Close();
            }
        }

        private void Zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
