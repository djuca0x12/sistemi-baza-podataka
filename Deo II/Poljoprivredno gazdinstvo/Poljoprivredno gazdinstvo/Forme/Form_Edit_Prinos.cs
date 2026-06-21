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
    public partial class Form_Edit_Prinos : Form
    {
        private int selektovaniId;
        public Form_Edit_Prinos(int idPrinosa)
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            selektovaniId = idPrinosa;
            UcitajPodatkePrinosa();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UcitajPodatkePrinosa()
        {
            PrinosBasic p = DTOManager.VratiPrinosPoId(selektovaniId);

            if (p != null)
            {
                txtTip.Text = p.Tip;
                numKolicina.Value = p.Kolicina;
                txtKomentar.Text = p.Komentar;
                cBoxKvalitet.SelectedItem = p.KvalitetProizvoda;
                cBoxJedinica.SelectedItem = p.JedinicaMere;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string unetiTip = txtTip.Text.Trim();

            if (DTOManager.ProveriDaLiTipPostoji(unetiTip, selektovaniId))
            {
                MessageBox.Show("Uneseni tip prinosa već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrinosBasic izmenjenPrinos = new PrinosBasic();
            izmenjenPrinos.IdPrinosa = selektovaniId;
            izmenjenPrinos.Tip = unetiTip;
            izmenjenPrinos.Kolicina = numKolicina.Value;
            izmenjenPrinos.Komentar = txtKomentar.Text;
            izmenjenPrinos.KvalitetProizvoda = cBoxKvalitet.SelectedItem != null ? cBoxKvalitet.SelectedItem.ToString() : "";
            izmenjenPrinos.JedinicaMere = cBoxJedinica.SelectedItem != null ? cBoxJedinica.SelectedItem.ToString() : "";

            DTOManager.IzmeniPrinos(izmenjenPrinos);

            MessageBox.Show("Podaci o prinosu su uspešno izmenjeni!");

            this.Close();
        }
    }
}
