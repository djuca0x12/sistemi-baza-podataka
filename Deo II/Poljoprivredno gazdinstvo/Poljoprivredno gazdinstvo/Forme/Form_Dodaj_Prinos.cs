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
    public partial class Form_Dodaj_Prinos : Form
    {
        public Form_Dodaj_Prinos()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string unetiTip = txtTip.Text.Trim();

            if (string.IsNullOrEmpty(unetiTip))
            {
                MessageBox.Show("Tip prinosa je obavezno polje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DTOManager.ProveriDaLiTipPostoji(unetiTip))
            {
                MessageBox.Show("Uneseni tip prinosa već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTip.Focus();
                return;
            }

            PrinosBasic noviPrinos = new PrinosBasic();

            noviPrinos.Tip = unetiTip;
            noviPrinos.Kolicina = numKolicina.Value; 
            noviPrinos.Komentar = txtKomentar.Text;
            noviPrinos.KvalitetProizvoda = cBoxKvalitet.Text;
            noviPrinos.JedinicaMere = cBoxJedinica.Text;

            DTOManager.DodajPrinos(noviPrinos);

            MessageBox.Show("Prinos je uspešno dodat!");

            this.Close();
        }
    }
}
