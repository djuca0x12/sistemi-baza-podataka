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
    public partial class Form_Zitarice : Form
    {
        ZitariceBasic zitarice;
        public Form_Zitarice()
        {
            InitializeComponent();
        }
        public Form_Zitarice(ZitariceBasic z)
        {
            InitializeComponent();
            zitarice = z;
        }

        private void Form_Zitarice_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        private void PopuniPodacima()
        {
            dgvZitarice.DataSource = null;
            dgvZitarice.Rows.Clear();
            dgvZitarice.DataSource = DTOManager.VratiSveZitarice();
            dgvZitarice.Refresh();
        }

        private void btnDodajZitaricu_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Zitaricu form = new();
            form.ShowDialog();
            this.PopuniPodacima();
        }

        private void btnIzmeniZitaricu_Click(object sender, EventArgs e)
        {
            if (dgvZitarice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite žitaricu čije podatke želite da izmenite!");
                return;
            }

            int idZitarice = Int32.Parse(dgvZitarice.SelectedRows[0].Cells["Id"].Value.ToString());
            ZitariceBasic z = DTOManager.VratiZitaricu(idZitarice);

            Form_Edit_Zitarice formUpdate = new(z);
            formUpdate.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnObrisiZitaricu_Click(object sender, EventArgs e)
        {
            if (dgvZitarice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite žitaricu čije podatke želite da obrišete!");
                return;
            }

            int idZitarice = Int32.Parse(dgvZitarice.SelectedRows[0].Cells["Id"].Value.ToString());

            string poruka = "Da li želite da obrišete izabranu žitaricu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiZitaricu(idZitarice);
                MessageBox.Show("Brisanje žitarice je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void btnProdajZitaricu_Click(object sender, EventArgs e)
        {
            // todo: povezati sa formom za prodaju/prinos
            Form_Prinos form = new Form_Prinos();
            form.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
