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
    public partial class Form_Edit_Subvencija : Form
    {
        private SubvencijaBasic _izmena;

        public Form_Edit_Subvencija(SubvencijaBasic izmena)
        {
            InitializeComponent();
            _izmena = izmena;
            PopuniFormu();
        }

        private void PopuniFormu()
        {
            txtBrojResenja.Text = _izmena.BrojResenja;
            cmbVrsta.SelectedItem = _izmena.Vrsta;
            numIznos.Value = (decimal)_izmena.Iznos;
            cmbValuta.SelectedItem = _izmena.Valuta;
            dateTimePickerPodnosenja.Value = _izmena.DatumPodnosenja;
            
            if (_izmena.DatumOdobrenja.HasValue)
            {
                checkBoxDatum.Checked = true;
                dateTimePickerOdobrenja.Value = _izmena.DatumOdobrenja.Value;
                dateTimePickerOdobrenja.Enabled = true;
            }
            else
            {
                checkBoxDatum.Checked = false;
                dateTimePickerOdobrenja.Enabled = false;
            }

            cmbStatus.SelectedItem = _izmena.Status;
            txtKomentar.Text = _izmena.Komentar;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxDatum_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerOdobrenja.Enabled = checkBoxDatum.Checked;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            // Validacija unique kolone!
            if (DTOManager.DaLiBrojResenjaPostoji(txtBrojResenja.Text, _izmena.IdSubvencija))
            {
                MessageBox.Show("Broj rešenja već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ažuriramo postojeći objekat
            _izmena.BrojResenja = txtBrojResenja.Text;
            _izmena.Vrsta = cmbVrsta.SelectedItem.ToString();
            _izmena.Iznos = numIznos.Value;
            _izmena.Valuta = cmbValuta.SelectedItem.ToString();
            _izmena.DatumPodnosenja = dateTimePickerPodnosenja.Value;

            _izmena.DatumOdobrenja = checkBoxDatum.Checked ? (DateTime?)dateTimePickerOdobrenja.Value : null;

            _izmena.Status = cmbStatus.SelectedItem.ToString();
            _izmena.Komentar = txtKomentar.Text;

            // Pozivamo DTOManager
            DTOManager.AzurirajSubvenciju(_izmena);

            MessageBox.Show("Izmene su uspešno sačuvane.");
            this.Close();
        }
    }
}
