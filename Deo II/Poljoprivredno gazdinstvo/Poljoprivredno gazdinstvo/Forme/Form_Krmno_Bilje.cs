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
        }
        public Form_Krmno_Bilje(KrmnoBiljeBasic k)
        {
            InitializeComponent();
            krma = k;
        }

        private void Form_Krmno_Bilje_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
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
            // todo: povezati sa formom za prodaju/prinos
            Form_Prinos form = new Form_Prinos();
            form.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
