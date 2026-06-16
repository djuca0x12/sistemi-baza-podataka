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
    public partial class Form_Zivotinje : Form
    {
        ZivotinjeBasic zivotinje;
        public Form_Zivotinje()
        {
            InitializeComponent();
        }

        public Form_Zivotinje(ZivotinjeBasic z)
        {
            InitializeComponent();
            zivotinje = z;
        }

        private void btnDodajZivotinju_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Zivotinju form = new Form_Dodaj_Zivotinju();
            form.ShowDialog();
            this.PopuniPodacima();
        }

        private void btnIzmeniZivotinju_Click(object sender, EventArgs e)
        {
            if (dgvZivotinje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite životinju čije podatke želite da izmenite!");
                return;
            }

            int idZivotinje = Int32.Parse(dgvZivotinje.SelectedRows[0].Cells[0].Value.ToString());
            ZivotinjeBasic z = DTOManager.VratiZivotinju(idZivotinje);

            Form_Edit_Zivotinja formUpdate = new Form_Edit_Zivotinja(z);
            formUpdate.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnObrisiZivotinju_Click(object sender, EventArgs e)
        {
            if (dgvZivotinje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite životinju čije podatke želite da obrišete!");
                return;
            }

            int idZivotinje = Int32.Parse(dgvZivotinje.SelectedRows[0].Cells[0].Value.ToString());

            string poruka = "Da li želite da obrišete izabranu životinju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiZivotinju(idZivotinje);
                MessageBox.Show("Brisanje životinje je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void btnProdajZivotinju_Click(object sender, EventArgs e)
        {
            // todo: povezati sa formom za prodaju/prinos
            Form_Prinos form = new Form_Prinos();
            form.ShowDialog();
            this.PopuniPodacima();
        }

        private void Form_Zivotinje_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        private void PopuniPodacima()
        {
            dgvZivotinje.DataSource = null;
            dgvZivotinje.Rows.Clear();
            dgvZivotinje.DataSource = DTOManager.VratiSveZivotinje();
            dgvZivotinje.Refresh();

        }
    }
}
