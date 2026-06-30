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
    public partial class Form_Vocnjaci : Form
    {
        VocnjaciBasic vocnjak;
        public Form_Vocnjaci()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }
        public Form_Vocnjaci(VocnjaciBasic v)
        {
            InitializeComponent();
            vocnjak = v;

            dgvVocnjaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void Form_Vocnjaci_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        private void PopuniPodacima()
        {
            dgvVocnjaci.DataSource = null;
            dgvVocnjaci.Rows.Clear();
            dgvVocnjaci.DataSource = DTOManager.VratiSveVocnjake();
            dgvVocnjaci.Refresh();

            if (dgvVocnjaci.Columns["Id"] != null)
            {
                dgvVocnjaci.Columns["Id"].Visible = false;
            }
        }

        private void btnDodajVocnjak_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Vocnjak form = new();
            form.ShowDialog();
            this.PopuniPodacima();
        }

        private void btnIzmeniVocnjak_Click(object sender, EventArgs e)
        {
            if (dgvVocnjaci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite voćnjak čije podatke želite da izmenite!");
                return;
            }

            int idVocnjak = Int32.Parse(dgvVocnjaci.SelectedRows[0].Cells["Id"].Value.ToString());
            VocnjaciBasic v = DTOManager.VratiVocnjak(idVocnjak);

            Form_Edit_Vocnjak formUpdate = new(v);
            formUpdate.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnObrisiVocnjak_Click(object sender, EventArgs e)
        {
            if (dgvVocnjaci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite voćnjak čije podatke želite da obrišete!");
                return;
            }

            int idVocnjak = Int32.Parse(dgvVocnjaci.SelectedRows[0].Cells["Id"].Value.ToString());

            string poruka = "Da li želite da obrišete izabrani voćnjak?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiVocnjak(idVocnjak);
                MessageBox.Show("Brisanje voćnjaka je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void btnProdajVoćnjak_Click(object sender, EventArgs e)
        {
            if (dgvVocnjaci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate prvo selektovati životinju iz tabele!",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntiteta = (int)dgvVocnjaci.SelectedRows[0].Cells["id"].Value;

            //MessageBox.Show(idEntiteta.ToString()); // Koristio sam radi testiranja

            Form_Dodaj_Prinos forma = new Form_Dodaj_Prinos(idEntiteta, "VOCNJACI");

            forma.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnSubvencije_Click(object sender, EventArgs e)
        {
            if (dgvVocnjaci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate prvo selektovati krmno bilje iz tabele!",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntiteta = (int)dgvVocnjaci.SelectedRows[0].Cells["id"].Value;

            int idKategorije = DTOManager.DohvatiIdKategorije(idEntiteta, "VOCNJACI");

            Form subvencije = new Form_Dodaj_Subevnciju(idKategorije);

            subvencije.ShowDialog();
        }
    }
}
