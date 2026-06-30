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
    public partial class Form_Proizvode : Form
    {
        public Form_Proizvode()
        {
            InitializeComponent();

            UcitajPodatke();

            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            dataGridViewProizvode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewProizvode.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molim vas, selektujte red koji želite da obrišete!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idZaBrisanje = Int32.Parse(dataGridViewProizvode.SelectedRows[0].Cells["Id"].Value.ToString());

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu stavku?",
                                                  "Potvrda brisanja",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    
                    DTOManager.ObrisiProizvodnuVezu(idZaBrisanje);

                    MessageBox.Show("Uspešno obrisano!");

                    
                    this.UcitajPodatke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja: " + ex.Message,
                                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UcitajPodatke()
        {
            dataGridViewProizvode.DataSource = DTOManager.VratiSveProizvodneIzvestaje();

            if (dataGridViewProizvode.Columns["Id"] != null)
                dataGridViewProizvode.Columns["Id"].Visible = false;

           if (dataGridViewProizvode.Columns["KategorijaTip"] != null)
                dataGridViewProizvode.Columns["KategorijaTip"].Visible = false;
        }
    }
}
