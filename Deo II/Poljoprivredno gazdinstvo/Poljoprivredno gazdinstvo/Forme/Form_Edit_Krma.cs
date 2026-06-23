using Poljoprivredno_gazdinstvo.Entiteti;
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
    public partial class Form_Edit_Krma : Form
    {
        KrmnoBiljeBasic krma;
        public Form_Edit_Krma()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }

        public Form_Edit_Krma(KrmnoBiljeBasic k)
        {
            InitializeComponent();
            krma = k;

            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }

        private void Form_Edit_Krma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
            this.Text = $"Izmena krmnog bilja: {krma.Naziv}";
        }

        private void PopuniPodacima()
        {
            // iz objekta u kontrole
            txtNaziv.Text = krma.Naziv;
            txtLokacija.Text = krma.Lokacija;
            numPovrsina.Value = (decimal)krma.Povrsina;
            txtKvalitetZemljista.Text = krma.KvalitetZemljista;
            dtpDatumSetve.Value = krma.DatumSetve > dtpDatumSetve.MinDate ? krma.DatumSetve : DateTime.Now;
            dtpDatumZetvePlanirani.Value = krma.DatumZetvePlanirani > dtpDatumZetvePlanirani.MinDate ? krma.DatumZetvePlanirani : DateTime.Now;
            dtpDatumZetveStvarni.Value = krma.DatumZetveStvarni > dtpDatumZetveStvarni.MinDate ? krma.DatumZetveStvarni : DateTime.Now;
            cbxStatus.SelectedItem = krma.Status;
            txtKomentar.Text = krma.Komentar;
            cbxVrstaKrme.SelectedItem = krma.VrstaKrme;
            numBrojKosnjiGodisnje.Value = (decimal)krma.BrojKosnjiGodisnje;
            numProcenatProteina.Value = (decimal)krma.ProcenatProteina;
            chkZaIshranuStoke.Checked = krma.IshranaStokeFlag == 1;
            chkZaProdaju.Checked = krma.ZaProdajuFlag == 1;
        }

        private void btnIzmeniKrmnoBilje_Click(object sender, EventArgs e)
        {

            string poruka = "Da li želite da izvršite izmene krmnog bilja?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                // id i kategorija se ne menjaju
                krma.Naziv = txtNaziv.Text;
                krma.Lokacija = txtLokacija.Text;
                krma.Povrsina = (double)numPovrsina.Value;
                krma.KvalitetZemljista = txtKvalitetZemljista.Text;
                krma.DatumSetve = dtpDatumSetve.Value;
                krma.DatumZetvePlanirani = dtpDatumZetvePlanirani.Value;
                krma.DatumZetveStvarni = dtpDatumZetveStvarni.Value;
                krma.Status = cbxStatus.SelectedItem?.ToString();
                krma.Komentar = txtKomentar.Text;
                krma.VrstaKrme = cbxVrstaKrme.SelectedItem?.ToString();
                krma.BrojKosnjiGodisnje = (int)numBrojKosnjiGodisnje.Value;
                krma.ProcenatProteina = (int)numProcenatProteina.Value;
                krma.IshranaStokeFlag = chkZaIshranuStoke.Checked ? 1 : 0;
                krma.ZaProdajuFlag = chkZaProdaju.Checked ? 1 : 0;

                DTOManager.IzmeniKrmnoBilje(this.krma);
                MessageBox.Show("Ažuriranje krmnog bilja je uspešno izvršeno!");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
