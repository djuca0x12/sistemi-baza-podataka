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
    public partial class Form_Edit_Zitarice : Form
    {
        ZitariceBasic zitarice;
        public Form_Edit_Zitarice()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }
        public Form_Edit_Zitarice(ZitariceBasic z)
        {
            InitializeComponent();
            zitarice = z;

            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }
        private void Form_Edit_Zitarice_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
            this.Text = $"Izmena žitarice: {zitarice.Naziv}";
        }
        private void PopuniPodacima()
        {
            // iz objekta u kontrole
            txtNaziv.Text = zitarice.Naziv;
            txtLokacija.Text = zitarice.Lokacija;
            numPovrsina.Value = (decimal)zitarice.Povrsina;
            txtKvalitetZemljista.Text = zitarice.KvalitetZemljista;
            dtpDatumSetve.Value = zitarice.DatumSetve > dtpDatumSetve.MinDate ? zitarice.DatumSetve : DateTime.Now;
            dtpDatumZetvePlanirani.Value = zitarice.DatumZetvePlanirani > dtpDatumZetvePlanirani.MinDate ? zitarice.DatumZetvePlanirani : DateTime.Now;
            dtpDatumZetveStvarni.Value = zitarice.DatumZetveStvarni > dtpDatumZetveStvarni.MinDate ? zitarice.DatumZetveStvarni : DateTime.Now;
            cbxStatus.SelectedItem = zitarice.Status;
            txtKomentar.Text = zitarice.Komentar;
            numGustinaSetve.Value = (decimal)zitarice.GustinaSetve;
            numKolicinaSemenaPoHektaru.Value = (decimal)zitarice.KolicinaSemenaPoHektaru;
            numPrinosPoHektaru.Value = (decimal)zitarice.PrinosPoHektaru;
            cbxTipZitarice.SelectedItem = zitarice.Tip;
            cbxTipDjubrenja.SelectedItem = zitarice.TipDjubrenja;
        }

        private void btnIzmeniZitaricu_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izvršite izmene žitarice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                // id i kategorija se ne menjaju
                zitarice.Naziv = txtNaziv.Text;
                zitarice.Lokacija = txtLokacija.Text;
                zitarice.Povrsina = (double)numPovrsina.Value;
                zitarice.KvalitetZemljista = txtKvalitetZemljista.Text;
                zitarice.DatumSetve = dtpDatumSetve.Value;
                zitarice.DatumZetvePlanirani = dtpDatumZetvePlanirani.Value;
                zitarice.DatumZetveStvarni = dtpDatumZetveStvarni.Value;
                zitarice.Status = cbxStatus.SelectedItem?.ToString();
                zitarice.Komentar = txtKomentar.Text;
                zitarice.GustinaSetve = (double)numGustinaSetve.Value;
                zitarice.KolicinaSemenaPoHektaru = (double)numKolicinaSemenaPoHektaru.Value;
                zitarice.PrinosPoHektaru = (double)numPrinosPoHektaru.Value;
                zitarice.Tip = cbxTipZitarice.SelectedItem.ToString();
                zitarice.TipDjubrenja = cbxTipDjubrenja.SelectedItem.ToString();

                DTOManager.IzmeniZitaricu(this.zitarice);
                MessageBox.Show("Ažuriranje žitarice je uspešno izvršeno!");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
