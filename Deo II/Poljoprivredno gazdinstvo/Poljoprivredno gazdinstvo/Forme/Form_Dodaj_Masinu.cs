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
    public partial class Form_Dodaj_Masinu : Form
    {
        public Form_Dodaj_Masinu()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string unetiBrojSasije = txtBrojSasije.Text.Trim();

            if (string.IsNullOrEmpty(unetiBrojSasije))
            {
                MessageBox.Show("Broj šasije je obavezno polje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DTOManager.ProveriDaLiBrojSasijePostojiZaMasinu(unetiBrojSasije))
            {
                MessageBox.Show("Uneseni broj šasije već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrojSasije.Focus();
                return;
            }

            MasinaBasic novaMasina = new MasinaBasic();
            novaMasina.BrojSasije = unetiBrojSasije;
            novaMasina.Status = cBoxStatus.SelectedItem != null ? cBoxStatus.SelectedItem.ToString() : "";
            novaMasina.Komentar = txtKomentar.Text;
            novaMasina.Model = txtModel.Text;
            novaMasina.DatumKupovine = dateDatumKupovine.Value;
            novaMasina.GodinaProizvodnje = (int)numGodinaProizvodnje.Value;
            novaMasina.BrojTockova = (int)numBrojTockova.Value;

            DTOManager.DodajMasinu(novaMasina);

            MessageBox.Show("Prskalica je uspešno dodata!");

            this.Close();
        }
    }
}
