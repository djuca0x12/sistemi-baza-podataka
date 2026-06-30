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
    public partial class Form_KoristiZa : Form
    {
        public Form_KoristiZa()
        {
            InitializeComponent();

            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            UcitajPodatke();

            this.MinimumSize = new Size(1095, 520);
            this.MaximumSize = new Size(1095, 520);
            this.Size = new Size(1095, 520);

            dataGridViewPrikaz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void UcitajPodatke()
        {
            var lista = DTOManager.VratiPregledKoriscenja();

            dataGridViewPrikaz.DataSource = lista;

            dataGridViewPrikaz.Columns["IdMehanizacija"].Visible = false;
            dataGridViewPrikaz.Columns["IdPrinos"].Visible = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dodajKoristiZa = new Form_Dodaj_KoristiZa();

            dodajKoristiZa.ShowDialog();

            UcitajPodatke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrikaz.SelectedRows.Count > 0)
            {
                // Uzimamo ceo red
                DataGridViewRow row = dataGridViewPrikaz.SelectedRows[0];

                object datumDoObj = row.Cells["DatumDo"].Value;

                KoristiZaBasic podaciZaIzmenu = new KoristiZaBasic
                {                    
                    IdMehanizacija = (int)row.Cells["IdMehanizacija"].Value,
                    IdPrinos = (int)row.Cells["IdPrinos"].Value,
                    DatumOd = (DateTime)row.Cells["DatumOd"].Value,
                    DatumDo = (datumDoObj == DBNull.Value || datumDoObj == null) ? (DateTime?)null : (DateTime)datumDoObj,
                    BrojSasije = (string)row.Cells["BrojSasije"].Value,
                    ModelMehanizacije = (string)row.Cells["ModelMehanizacije"].Value,
                    TipPrinos = (string)row.Cells["TipPrinos"].Value
                };

                Form_Edit_KoristiZa formaIzmena = new Form_Edit_KoristiZa(podaciZaIzmenu);

                formaIzmena.ShowDialog();

                UcitajPodatke();
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete prinos koji želite da izmenite.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Provera da li je red izabran
            if (dataGridViewPrikaz.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas da selektujete zapis koji želite da obrišete.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preuzimanje podataka iz selektovanog reda
            DataGridViewRow row = dataGridViewPrikaz.SelectedRows[0];
            int idMehanizacija = (int)row.Cells["IdMehanizacija"].Value;
            int idPrinos = (int)row.Cells["IdPrinos"].Value;
            DateTime datumOd = (DateTime)row.Cells["DatumOd"].Value;

            // Potvrda brisanja
            DialogResult dr = MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj zapis?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    // Poziv metode
                    DTOManager.ObrisiKoriscenje(idMehanizacija, idPrinos, datumOd);

                    // Osvezavanje prikaza
                    UcitajPodatke();

                    MessageBox.Show("Zapis uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
