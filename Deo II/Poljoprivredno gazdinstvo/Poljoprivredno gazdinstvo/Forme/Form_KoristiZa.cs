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

            UcitajPodatke();

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

        }
    }
}
