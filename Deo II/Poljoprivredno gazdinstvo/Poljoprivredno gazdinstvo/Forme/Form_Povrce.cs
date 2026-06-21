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
    public partial class Form_Povrce : Form
    {
        PovrceBasic povrce;
        public Form_Povrce()
        {
            InitializeComponent();
            // stilizovanje forme
            Form_Start.ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
        }
        public Form_Povrce(PovrceBasic p)
        {
            InitializeComponent();
            povrce = p;
        }

        private void Form_Povrce_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        private void PopuniPodacima()
        {
            dgvPovrce.DataSource = null;
            dgvPovrce.Rows.Clear();
            dgvPovrce.DataSource = DTOManager.VratiSvoPovrce();
            dgvPovrce.Refresh();
        }
        private void btnDodajPovrce_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Povrce form = new();
            form.ShowDialog();
            this.PopuniPodacima();
        }

        private void btnIzmeniPovrce_Click(object sender, EventArgs e)
        {
            if (dgvPovrce.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite povrće čije podatke želite da izmenite!");
                return;
            }

            int idPovrca = Int32.Parse(dgvPovrce.SelectedRows[0].Cells["Id"].Value.ToString());
            PovrceBasic p = DTOManager.VratiPovrce(idPovrca);

            Form_Edit_Povrce formUpdate = new(p);
            formUpdate.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnObrisiPovrce_Click(object sender, EventArgs e)
        {
            if (dgvPovrce.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite povrće čije podatke želite da obrišete!");
                return;
            }

            int idPovrce = Int32.Parse(dgvPovrce.SelectedRows[0].Cells["Id"].Value.ToString());

            string poruka = "Da li želite da obrišete izabrano povrće?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiPovrce(idPovrce);
                MessageBox.Show("Brisanje povrća je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void btnProdajPovrce_Click(object sender, EventArgs e)
        {
            // todo: povezati sa formom za prodaju/prinos
            Form_Prinos form = new Form_Prinos();
            form.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
