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
    public partial class Form_Edit_Masina : Form
    {
        private int selektovaniId;
        public Form_Edit_Masina(int selektovaniId)
        {
            InitializeComponent();
            this.selektovaniId = selektovaniId;
            UcitajPodatkePrskalice();
        }

        private void UcitajPodatkePrskalice()
        {
            MasinaBasic p = DTOManager.VratiMasinuPoId(selektovaniId);

            if (p != null)
            {
                txtBrojSasije.Text = p.BrojSasije;
                cBoxStatus.SelectedItem = p.Status;
                txtKomentar.Text = p.Komentar;
                txtModel.Text = p.Model;
                dateDatumKupovine.Value = (DateTime)p.DatumKupovine;
                numGodinaProizvodnje.Value = (decimal)p.GodinaProizvodnje;
                numBrojTockova.Value = (int)p.BrojTockova;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string unetiBrojSasije = txtBrojSasije.Text.Trim();

            if (DTOManager.ProveriDaLiBrojSasijePostojiZaMasinu(unetiBrojSasije, selektovaniId))
            {
                MessageBox.Show("Uneseni broj šasije već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MasinaBasic izmenjenaMasina = new MasinaBasic();
            izmenjenaMasina.IdMehanizacija = selektovaniId;
            izmenjenaMasina.BrojSasije = unetiBrojSasije;
            izmenjenaMasina.Status = cBoxStatus.SelectedItem != null ? cBoxStatus.SelectedItem.ToString() : "";
            izmenjenaMasina.Komentar = txtKomentar.Text;
            izmenjenaMasina.Model = txtModel.Text;
            izmenjenaMasina.DatumKupovine = dateDatumKupovine.Value;
            izmenjenaMasina.GodinaProizvodnje = (int)numGodinaProizvodnje.Value;
            izmenjenaMasina.BrojTockova = (int)numBrojTockova.Value;

            DTOManager.IzmeniMasinu(izmenjenaMasina);

            MessageBox.Show("Podaci o prskalici su uspešno izmenjeni!");

            this.Close();
        }
    }
}
