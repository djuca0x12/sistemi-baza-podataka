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
    public partial class Form_Prodaja : Form
    {
        public Form_Prodaja()
        {
            InitializeComponent();
        }

        private void UcitajProdajeUGrid()
        {
            List<ProdajaBasic> listaProdaja = DTOManager.VratiSveProdaje();
          
            dataGridViewProdaja.DataSource = listaProdaja;

            if (dataGridViewProdaja.Columns["IdProdaja"] != null)
                dataGridViewProdaja.Columns["IdProdaja"].Visible = false;

            if (dataGridViewProdaja.Columns["IdPrinosa"] != null)
                dataGridViewProdaja.Columns["IdPrinosa"].Visible = false;

            dataGridViewProdaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProdaja.Refresh();
        }

        private void Form_Prodaja_Load(object sender, EventArgs e)
        {
            UcitajProdajeUGrid();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdaja.SelectedRows.Count > 0)
            {
                DialogResult potvrda = MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete selektovanu prodaju?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (potvrda == DialogResult.Yes)
                {
                    int idBrisanje = (int)dataGridViewProdaja.SelectedRows[0].Cells["IdProdaja"].Value;

                    DTOManager.ObrisiProdaju(idBrisanje);

                    MessageBox.Show("Prodaja je uspešno obrisana!");

                    UcitajProdajeUGrid();
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete prodaju iz tabele koju želite da obrišete.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdaja.SelectedRows.Count > 0)
            {
                int idZaIzmenu = (int)dataGridViewProdaja.SelectedRows[0].Cells["IdProdaja"].Value;

                Form_Edit_Prodaju formaIzmena = new Form_Edit_Prodaju(idZaIzmenu);

                formaIzmena.ShowDialog();

                UcitajProdajeUGrid();
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete prodaju koju želite da izmenite.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
