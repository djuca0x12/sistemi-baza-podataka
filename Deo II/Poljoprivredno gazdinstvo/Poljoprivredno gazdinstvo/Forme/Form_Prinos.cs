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
    public partial class Form_Prinos : Form
    {
        public Form_Prinos()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }

        private void UcitajPrinoseUGrid()
        {
            List<PrinosBasic> listaPrinosa = DTOManager.VratiSvePrinose();

            dataGridViewPrinos.DataSource = listaPrinosa;

            if (dataGridViewPrinos.Columns["IdPrinosa"] != null)
            {
                dataGridViewPrinos.Columns["IdPrinosa"].Visible = false;
            }

            dataGridViewPrinos.Refresh();
        }
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Prinos_Load(object sender, EventArgs e)
        {
            UcitajPrinoseUGrid();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Prinos dodajPrinos = new Form_Dodaj_Prinos();

            dodajPrinos.ShowDialog();

            UcitajPrinoseUGrid();
        }

        private void btnPromeniPodatke_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrinos.SelectedRows.Count > 0)
            {
                int idZaIzmenu = (int)dataGridViewPrinos.SelectedRows[0].Cells["IdPrinosa"].Value;

                Form_Edit_Prinos formaIzmena = new Form_Edit_Prinos(idZaIzmenu);
                formaIzmena.ShowDialog();

                UcitajPrinoseUGrid();
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete prinos koji želite da izmenite.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrinos.SelectedRows.Count > 0)
            {
                DialogResult potvrda = MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete selektovani prinos?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (potvrda == DialogResult.Yes)
                {
                    int idBrisanje = (int)dataGridViewPrinos.SelectedRows[0].Cells["IdPrinosa"].Value;

                    DTOManager.ObrisiPrinos(idBrisanje);

                    MessageBox.Show("Prinos je uspešno obrisan!");
                    UcitajPrinoseUGrid();
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete prinos iz tabele koji želite da obrišete.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrinos.SelectedRows.Count > 0)
            {
                int idSelektovanogPrinosa = (int)dataGridViewPrinos.SelectedRows[0].Cells["IdPrinosa"].Value;

                string nazivPrinosa = dataGridViewPrinos.SelectedRows[0].Cells["Tip"].Value.ToString();
                string jedinica = dataGridViewPrinos.SelectedRows[0].Cells["JedinicaMere"].Value.ToString();

                // Otvaramo formu i prosledjujemo joj neophodne parametre
                Form_Dodaj_Prodaju formaProdaja = new Form_Dodaj_Prodaju(idSelektovanogPrinosa, nazivPrinosa, jedinica);
                formaProdaja.ShowDialog();

                UcitajPrinoseUGrid();
            }
            else
            {
                MessageBox.Show("Molimo vas da prvo selektujete prinos koji želite da prodate.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
