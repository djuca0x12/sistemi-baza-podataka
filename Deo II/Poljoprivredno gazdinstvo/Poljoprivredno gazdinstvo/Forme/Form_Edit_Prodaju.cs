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
    public partial class Form_Edit_Prodaju : Form
    {
        private int selektovaniIdProdaje;
        public Form_Edit_Prodaju(int idProdaje)
        {
            InitializeComponent();

            selektovaniIdProdaje = idProdaje;

            UcitajPodatkeProdaje();
        }

        private void UcitajPodatkeProdaje()
        {
            ProdajaBasic p = DTOManager.VratiProdajuPoId(selektovaniIdProdaje);

            if (p != null)
            {
                txtBrojFakture.Text = p.BrojFakture;
                cBoxTipPlacanja.Text = p.TipPlacanja;
                txtKomentar.Text = p.Komentar;
                numCena.Value = p.CenaPoJedinici;
                cBoxJedinicaMere.Text = p.JedinicaMere;
                dateDatum.Value = p.Datum;
                numKolicina.Value = p.Kolicina;

                txtKupac.Text = p.Kupac ?? "Nepoznato";

                cBoxJedinicaMere.Enabled = false;
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string noviBrojFakture = txtBrojFakture.Text.Trim();

            // Provera jedinstvenosti
            if (DTOManager.ProveriDaLiBrojFakturePostoji(noviBrojFakture, selektovaniIdProdaje))
            {
                MessageBox.Show("Uneseni broj fakture već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProdajaBasic izmenjenaProdaja = new ProdajaBasic();
            izmenjenaProdaja.IdProdaja = selektovaniIdProdaje;
            izmenjenaProdaja.BrojFakture = noviBrojFakture;
            izmenjenaProdaja.TipPlacanja = cBoxTipPlacanja.Text;
            izmenjenaProdaja.Komentar = txtKomentar.Text;
            izmenjenaProdaja.CenaPoJedinici = numCena.Value;
            izmenjenaProdaja.JedinicaMere = cBoxJedinicaMere.Text;
            izmenjenaProdaja.Datum = dateDatum.Value;
            izmenjenaProdaja.Kolicina = numKolicina.Value;
            izmenjenaProdaja.Kupac = txtKupac.Text;

            DTOManager.IzmeniProdaju(izmenjenaProdaja);

            MessageBox.Show("Podaci o prodaji su uspešno izmenjeni!");
            this.Close();
        }
    }
}
