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
    public partial class Form_Dodaj_Prodaju : Form
    {
        private int _idPrinosa;
        public Form_Dodaj_Prodaju(int idPrinosa, string naziv, string jedinica)
        {
            InitializeComponent();

            _idPrinosa = idPrinosa;

            cBoxJedinicaMere.SelectedItem = jedinica;
            cBoxJedinicaMere.Enabled = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            // Provera jedinstvenosti fakture:
            if (DTOManager.ProveriDaLiBrojFakturePostoji(txtBrojFakture.Text))
            {
                MessageBox.Show("Greška: Faktura sa ovim brojem već postoji u sistemu!", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Provera da li je uneta kolicina:
            decimal kolicinaUnos = numKolicina.Value;

            if (kolicinaUnos <= 0)
            {
                MessageBox.Show("Molimo unesite količinu veću od nule.");
                return;
            }

            // Provera da li imamo dovoljno prinosa da prodamo:
            if (!DTOManager.DaLiImaDovoljnoPrinosa(_idPrinosa, kolicinaUnos, cBoxJedinicaMere.Text))
            {
                MessageBox.Show("Greška: Nema dovoljno na stanju za odabranu jedinicu mere!", "Zabrana prodaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProdajaBasic novaProdaja = new ProdajaBasic
            {
                IdPrinosa = _idPrinosa,
                BrojFakture = txtBrojFakture.Text,
                TipPlacanja = cBoxTipPlacanja.Text,
                Komentar = txtKomentar.Text,    
                JedinicaMere = cBoxJedinicaMere.Text,
                Kolicina = kolicinaUnos,
                Datum = DateTime.Now,
                Kupac = txtKupac.Text,
            };

            if (DTOManager.DodajProdaju(novaProdaja))
            {
                MessageBox.Show("Prodaja uspešno zabeležena!");
                this.Close();
            }
        }
    }
}
