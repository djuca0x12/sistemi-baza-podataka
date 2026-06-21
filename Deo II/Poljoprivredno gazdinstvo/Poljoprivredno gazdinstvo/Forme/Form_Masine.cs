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
    public partial class Form_Masine : Form
    {
        public Form_Masine()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Masine_Load(object sender, EventArgs e)
        {
            UcitajPrskaliceUGrid();
        }

        private void UcitajPrskaliceUGrid()
        {
            List<MasinaBasic> listaPrskalica = DTOManager.VratiSvePrskalice();

            dataGridViewMasin.DataSource = listaPrskalica;

            if (dataGridViewMasin.Columns["IdMehanizacija"] != null)
            {
                dataGridViewMasin.Columns["IdMehanizacija"].Visible = false;
            }
        }

        private void btnDodajMasinu_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Masinu dodajMasinu = new Form_Dodaj_Masinu();

            dodajMasinu.ShowDialog();
        }

        private void btnObrisiMasinu_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasin.SelectedRows.Count > 0)
            {
                DialogResult potvrda = MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete selektovanu masinu?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (potvrda == DialogResult.Yes)
                {
                    int idBrisanje = (int)dataGridViewMasin.SelectedRows[0].Cells["IdMehanizacija"].Value;
                    DTOManager.ObrisiMasinu(idBrisanje);

                    MessageBox.Show("Masina je uspešno obrisana!");

                    UcitajPrskaliceUGrid();
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete masinu iz tabele.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPromeniMasinu_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasin.SelectedRows.Count > 0)
            {           
                int idZaIzmenu = (int)dataGridViewMasin.SelectedRows[0].Cells["IdMehanizacija"].Value;

                Form_Edit_Masina formaIzmena = new Form_Edit_Masina(idZaIzmenu);

                formaIzmena.ShowDialog();

                UcitajPrskaliceUGrid();
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete masinu koju želite da izmenite.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
