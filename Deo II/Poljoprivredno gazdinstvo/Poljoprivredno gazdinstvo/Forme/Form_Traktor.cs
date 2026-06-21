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
    public partial class Form_Traktor : Form
    {
        public Form_Traktor()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
            //UcitajTraktoreUListView();
        }


        private void UcitajTraktore()
        {
            try
            {
                List<TraktorBasic> listaTraktora = DTOManager.UcitajTraktore();

                dataGridViewTraktori.DataSource = listaTraktora;

                // Ne prikazuje podatak na tabeli, ali je i dalje tu!
                if (dataGridViewTraktori.Columns["IdMehanizacija"] != null)
                {
                    dataGridViewTraktori.Columns["IdMehanizacija"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Traktor_Load(object sender, EventArgs e)
        {
            UcitajTraktore();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form DodajTraktor = new Form_Dodaj_Traktor();

            DodajTraktor.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewTraktori.SelectedRows.Count > 0)
            {
                // Uzimamo skriveni ID iz prve kolone
                int idZaIzmenu = (int)dataGridViewTraktori.SelectedRows[0].Cells["IdMehanizacija"].Value;

                
                Form_Edit_Traktor formaIzmena = new Form_Edit_Traktor(idZaIzmenu);
                formaIzmena.ShowDialog(); // Otvaramo modalno

                // Nakon što se forma zatvori, osvežavamo tabelu
                UcitajTraktore();
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete red koji želite da izmenite.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Proveravamo da li je korisnik selektovao red/traktor
            if (dataGridViewTraktori.SelectedRows.Count > 0)
            {
                // Pitamo korisnika za potvrdu pre brisanja
                DialogResult potvrda = MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete selektovani traktor?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (potvrda == DialogResult.Yes)
                {
                    // Uzimamo ID
                    int idZaBrisanje = (int)dataGridViewTraktori.SelectedRows[0].Cells["IdMehanizacija"].Value;

                    DTOManager.ObrisiTraktor(idZaBrisanje);

                    MessageBox.Show("Traktor je uspešno obrisan!");

                    // Osvezavamo tabelu
                    UcitajTraktore();
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da selektujete traktor iz tabele koji želite da obrišete.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
