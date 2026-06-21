using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Poljoprivredno_gazdinstvo.Forme
{
    public partial class Form_Edit_Zivotinja : Form
    {
        ZivotinjeBasic zivotinja;
        public Form_Edit_Zivotinja()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }
        public Form_Edit_Zivotinja(ZivotinjeBasic zivotinja)
        {
            InitializeComponent();
            this.zivotinja = zivotinja;
        }

        private void Form_Edit_Zivotinja_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
            this.Text = $"Izmena životinje: {zivotinja.Vrsta}";
        }

        private void PopuniPodacima()
        {
            // iz objekta u kontrole
            txtBrojUha.Text = zivotinja.BrojUha;
            txtVrsta.Text = zivotinja.Vrsta;
            cbxPol.SelectedItem = zivotinja.Pol.ToString(); // lakši rad, iako je char
            txtRasa.Text = zivotinja.Rasa;
            numBrojJedinki.Value = zivotinja.BrojJedinki;
            dtpDatumRodjenja.Value = zivotinja.DatumRodjenja;
            dtpDatumUlaska.Value = zivotinja.DatumUlaska;
            numTezina.Value = (decimal)zivotinja.Tezina;
            cbxStatus.Text = zivotinja.Status;
            txtKomentar.Text = zivotinja.Komentar;
        }

        private void btnIzmeniZivotinju_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izvršite izmene životinje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                // id i kategorija se ne menjaju
                this.zivotinja.BrojUha = txtBrojUha.Text;
                this.zivotinja.Vrsta = txtVrsta.Text;
                this.zivotinja.Pol = cbxPol.Text[0];
                this.zivotinja.Rasa = txtRasa.Text;
                this.zivotinja.BrojJedinki = (int)numBrojJedinki.Value;
                this.zivotinja.DatumRodjenja = dtpDatumRodjenja.Value;
                this.zivotinja.DatumUlaska = dtpDatumUlaska.Value;
                this.zivotinja.Tezina = (double)numTezina.Value;
                this.zivotinja.Status = cbxStatus.Text;
                this.zivotinja.Komentar = txtKomentar.Text;

                DTOManager.IzmeniZivotinju(this.zivotinja);
                MessageBox.Show("Ažuriranje životinje je uspešno izvršeno!");
                this.Close();
            }
        }
    }
}
