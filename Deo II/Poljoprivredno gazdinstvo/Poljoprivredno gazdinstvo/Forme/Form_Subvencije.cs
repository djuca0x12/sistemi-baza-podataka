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
    public partial class Form_Subvencije : Form
    {
        public Form_Subvencije()
        {
            InitializeComponent();

            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            dataGridView1.DataSource = DTOManager.VratiSveSubvencije();
            dataGridView1.Columns["IdSubvencija"].Visible = false;
            dataGridView1.Columns["UseviZivotinjeId"].Visible = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["IdSubvencija"].Value;
                if (MessageBox.Show("Da li ste sigurni?", "Brisanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DTOManager.ObrisiSubvenciju(id);
                    UcitajPodatke();
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da prvo selektujete red u tabeli koji želite da obrišete.", "Nije izvršeno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                // Kreiramo DTO od selektovanog reda
                SubvencijaBasic model = new SubvencijaBasic
                {
                    IdSubvencija = (int)row.Cells["IdSubvencija"].Value, // Ovo ne moze da se menja
                    BrojResenja = (string)row.Cells["BrojResenja"].Value,
                    Vrsta = (string)row.Cells["Vrsta"].Value,
                    Iznos = (decimal)row.Cells["Iznos"].Value,
                    Valuta = (string)row.Cells["Valuta"].Value,
                    DatumPodnosenja = (DateTime)row.Cells["DatumPodnosenja"].Value,
                    // Provera za null kod datuma koji mogu biti prazni
                    DatumOdobrenja = row.Cells["DatumOdobrenja"].Value != DBNull.Value
                                     ? (DateTime?)row.Cells["DatumOdobrenja"].Value
                                     : null,
                    Status = (string)row.Cells["Status"].Value,
                    Komentar = (string)row.Cells["Komentar"].Value,
                    UseviZivotinjeId = (int)row.Cells["UseviZivotinjeId"].Value // Da li ovo moze da se menja
                };

                Form_Edit_Subvencija forma = new Form_Edit_Subvencija(model);

                forma.ShowDialog();
              
                UcitajPodatke();
            }
            else
            {
                MessageBox.Show("Molimo vas da prvo selektujete subvenciju koju želite da izmenite.",
                                "Nije selektovano",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
