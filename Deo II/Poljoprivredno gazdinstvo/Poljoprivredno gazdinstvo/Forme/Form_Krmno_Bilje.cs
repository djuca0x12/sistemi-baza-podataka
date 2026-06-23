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
    public partial class Form_Krmno_Bilje : Form
    {
        KrmnoBiljeBasic krma;
        public Form_Krmno_Bilje()
        {
            InitializeComponent();

            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);

            dgvKrmnoBilje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public Form_Krmno_Bilje(KrmnoBiljeBasic k)
        {
            InitializeComponent();
            krma = k;
        }

        private void Form_Krmno_Bilje_Load(object sender, EventArgs e)
        {
            PopuniPodacima();

            dgvKrmnoBilje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void PopuniPodacima()
        {
            dgvKrmnoBilje.DataSource = null;
            dgvKrmnoBilje.Rows.Clear();
            dgvKrmnoBilje.DataSource = DTOManager.VratiSvoKrmnoBilje();
            dgvKrmnoBilje.Refresh();
        }

        private void btnDodajKrmnoBilje_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Krmu form = new();
            form.ShowDialog();
            this.PopuniPodacima();
        }

        private void btnIzmeniKrmnoBilje_Click(object sender, EventArgs e)
        {
            if (dgvKrmnoBilje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite krmno bilje čije podatke želite da izmenite!");
                return;
            }

            int idKrme = Int32.Parse(dgvKrmnoBilje.SelectedRows[0].Cells["Id"].Value.ToString());
            KrmnoBiljeBasic k = DTOManager.VratiKrmnoBilje(idKrme);

            Form_Edit_Krma formUpdate = new(k);
            formUpdate.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnObrisiKrmnoBilje_Click(object sender, EventArgs e)
        {
            if (dgvKrmnoBilje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite krmno bilje čije podatke želite da obrišete!");
                return;
            }

            int idKrme = Int32.Parse(dgvKrmnoBilje.SelectedRows[0].Cells["Id"].Value.ToString());

            string poruka = "Da li želite da obrišete izabrano krmno bilje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiKrmnoBilje(idKrme);
                MessageBox.Show("Brisanje krmnog bilja je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void btnProdajKrmnoBilje_Click(object sender, EventArgs e)
        {
            if (dgvKrmnoBilje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate prvo selektovati krmno bilje iz tabele!",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntiteta = (int)dgvKrmnoBilje.SelectedRows[0].Cells["id"].Value;

            //MessageBox.Show(idEntiteta.ToString()); // Koristio sam radi testiranja

            Form_Dodaj_Prinos forma = new Form_Dodaj_Prinos(idEntiteta, "KRMNO_BILJE");

            forma.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnSubvencija_Click(object sender, EventArgs e)
        {
            if (dgvKrmnoBilje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate prvo selektovati krmno bilje iz tabele!",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntiteta = (int)dgvKrmnoBilje.SelectedRows[0].Cells["id"].Value;

            int idKategorije = DTOManager.DohvatiIdKategorije(idEntiteta, "KRMNO_BILJE");

            Form subvencije = new Form_Dodaj_Subevnciju(idKategorije);

            subvencije.ShowDialog();
        }
    }
}
