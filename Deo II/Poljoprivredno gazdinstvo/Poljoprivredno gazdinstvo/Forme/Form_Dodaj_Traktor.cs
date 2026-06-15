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
    public partial class Form_Dodaj_Traktor : Form
    {
        public Form_Dodaj_Traktor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // slucajno - mrezlo me da skidam!
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string unetiBrojSasije = txtBrojSasije.Text.Trim();

            // Osnovna provera da li je polje prazno
            if (string.IsNullOrEmpty(unetiBrojSasije))
            {
                MessageBox.Show("Broj šasije je obavezan polje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool postojiUInojBazi = DTOManager.ProveriDaLiBrojSasijePostoji(unetiBrojSasije);

            if (postojiUInojBazi)
            {
                MessageBox.Show("Uneseni broj šasije već postoji u bazi! Molimo vas da promenite broj šasije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrojSasije.Focus();
                return; 
            }

            TraktorBasic noviTraktor = new TraktorBasic();

            noviTraktor.BrojSasije = txtBrojSasije.Text;
            noviTraktor.Status = cBoxStatus.Text;
            noviTraktor.Komentar = txtKomentar.Text;
            noviTraktor.Model = txtModel.Text;
            noviTraktor.DatumKupovine = dateDatumKupovine.Value;
            noviTraktor.GodinaProizvodnje = (int)numGodinaProizvodnje.Value;
            noviTraktor.Snaga = (double)numSnaga.Value;
            noviTraktor.RadniSati = numRadniSati.Value;
            noviTraktor.BrojMotora = txtBrojMotora.Text;

            DTOManager.DodajTraktor(noviTraktor);

            MessageBox.Show("Traktor je uspešno dodat!");

            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
