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
    public partial class Form_Edit_Traktor : Form
    {
        private int selektovaniId;

        public Form_Edit_Traktor(int idMehanizacije)
        {
            InitializeComponent();

            selektovaniId = idMehanizacije;

            UcitajPodatkeTraktora();
        }

        private void UcitajPodatkeTraktora()
        {
            // Povlacimo podatke za ovaj traktor 
            TraktorBasic t = DTOManager.VratiTraktorPoId(selektovaniId);

            if (t != null)
            {
                txtBrojSasije.Text = t.BrojSasije;
                cBoxStatus.SelectedItem = t.Status;
                txtKomentar.Text = t.Komentar;
                txtModel.Text = t.Model;
                dateDatumKupovine.Value = (DateTime)t.DatumKupovine;
                numGodinaProizvodnje.Value = (decimal)t.GodinaProizvodnje;
                numSnaga.Value = (decimal)t.Snaga;
                numRadniSati.Value = (decimal)t.RadniSati;
                txtBrojMotora.Text = t.BrojMotora;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            // Proveravamo da li je broj sasije jedinstven
            string unetiBrojSasije = txtBrojSasije.Text.Trim();

            if (DTOManager.ProveriDaLiBrojSasijePostoji(unetiBrojSasije, selektovaniId))
            {
                MessageBox.Show("Uneseni broj šasije već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            TraktorBasic izmenjenTraktor = new TraktorBasic();
            izmenjenTraktor.IdMehanizacija = selektovaniId; // Moramo da prosledimo id, da bi se znalo sta se menja
            izmenjenTraktor.BrojSasije = unetiBrojSasije;
            izmenjenTraktor.Status = cBoxStatus.SelectedItem != null ? cBoxStatus.SelectedItem.ToString() : "";
            izmenjenTraktor.Komentar = txtKomentar.Text;
            izmenjenTraktor.Model = txtModel.Text;
            izmenjenTraktor.DatumKupovine = dateDatumKupovine.Value;
            izmenjenTraktor.GodinaProizvodnje = (int)numGodinaProizvodnje.Value;
            izmenjenTraktor.Snaga = (double)numSnaga.Value;
            izmenjenTraktor.RadniSati = numRadniSati.Value;
            izmenjenTraktor.BrojMotora = txtBrojMotora.Text;

            // 3. Poziv metode za izmenu
            DTOManager.IzmeniTraktor(izmenjenTraktor);

            MessageBox.Show("Podaci o traktoru su uspešno izmenjeni!");
            this.Close();
        }
    }
}
