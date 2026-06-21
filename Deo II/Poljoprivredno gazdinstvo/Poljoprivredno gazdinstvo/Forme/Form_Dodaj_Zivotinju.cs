using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Poljoprivredno_gazdinstvo.Forme
{
    public partial class Form_Dodaj_Zivotinju : Form
    {
        ZivotinjeBasic zivotinja;
        public Form_Dodaj_Zivotinju()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            zivotinja = new ZivotinjeBasic();
        }

        private void btnDodajZivotinju_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu životinju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                // pročitaj sve iz kontrola: šta sa kategorijom?
                zivotinja.BrojUha = txtBrojUha.Text;
                zivotinja.Vrsta = txtVrsta.Text;
                zivotinja.Pol = cbxPol.SelectedItem.ToString()[0];
                zivotinja.Rasa = txtRasa.Text;
                zivotinja.BrojJedinki = (int)numBrojJedinki.Value;
                zivotinja.DatumRodjenja = dtpDatumRodjenja.Value;
                zivotinja.DatumUlaska = dtpDatumUlaska.Value;
                zivotinja.Tezina = (double)numTezina.Value;
                zivotinja.Status = cbxStatus.Text;
                zivotinja.Komentar = txtKomentar.Text;

                DTOManager.DodajZivotinju(this.zivotinja);
                MessageBox.Show("Uspesno ste dodali novu životinju!");
                this.Close();
            }
        }
    }
}
