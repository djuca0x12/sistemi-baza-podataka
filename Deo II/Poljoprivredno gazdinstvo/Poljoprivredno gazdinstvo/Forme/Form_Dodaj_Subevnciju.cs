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
    public partial class Form_Dodaj_Subevnciju : Form
    {
        private int idKategorije;
        public Form_Dodaj_Subevnciju(int idKategorije)
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            this.idKategorije = idKategorije;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            // Provera jedinstvenosti:
            if (DTOManager.DaLiBrojResenjaPostoji(txtBrojResenja.Text))
            {
                MessageBox.Show("Broj rešenja već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Objekat:
            SubvencijaBasic novaSubvencija = new SubvencijaBasic
            {
                BrojResenja = txtBrojResenja.Text,
                Vrsta = cmbVrsta.SelectedItem.ToString(),
                Iznos = numIznos.Value,
                Valuta = cmbValuta.SelectedItem.ToString(),
                DatumPodnosenja = dateTimePickerPodnosenja.Value,
                DatumOdobrenja = null, 
                Status = "podneseno",
                Komentar = txtKomentar.Text,
                UseviZivotinjeId = idKategorije
            };

            DTOManager.DodajSubvenciju(novaSubvencija);

            MessageBox.Show("Subvencija uspešno dodata.");
            this.Close();
        }
    }
}
