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
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }
        public Form_Zitarice(ZitariceBasic z)
        {
            InitializeComponent();
            zitarice = z;
        }

        private void Form_Zitarice_Load(object sender, EventArgs e)
        {
            PopuniPodacima();

            dgvZitarice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void PopuniPodacima()
        {
            dgvZitarice.DataSource = null;
            dgvZitarice.Rows.Clear();
            dgvZitarice.DataSource = DTOManager.VratiSveZitarice();
            dgvZitarice.Refresh();

            if (dgvZitarice.Columns["Id"] != null)
            {
                dgvZitarice.Columns["Id"].Visible = false;
            }
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
            if (dgvZitarice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate prvo selektovati životinju iz tabele!",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntiteta = (int)dgvZitarice.SelectedRows[0].Cells["id"].Value;

            //MessageBox.Show(idEntiteta.ToString()); // Koristio sam radi testiranja

            Form_Dodaj_Prinos forma = new Form_Dodaj_Prinos(idEntiteta, "ZITARICE");

            forma.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnSubvencije_Click(object sender, EventArgs e)
        {
            if (dgvZitarice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate prvo selektovati krmno bilje iz tabele!",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntiteta = (int)dgvZitarice.SelectedRows[0].Cells["id"].Value;

            int idKategorije = DTOManager.DohvatiIdKategorije(idEntiteta, "ZITARICE");

            Form subvencije = new Form_Dodaj_Subevnciju(idKategorije);

            subvencije.ShowDialog();
        }
    }
}
