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
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form mehanizacija = new Form_Mehanizacija();

            mehanizacija.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form prinos = new Form_Prinos();

            prinos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProdaje_Click(object sender, EventArgs e)
        {
            Form prodaje = new Form_Prodaja();

            prodaje.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form sub = new Form_Subvencije();

            sub.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form koristiZa = new Form_KoristiZa();

            koristiZa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Zivotinje_Click(object sender, EventArgs e)
        {
            Form zivotinje = new Form_Zivotinje();
            zivotinje.ShowDialog();
        }

        private void btn_Zitarice_Click(object sender, EventArgs e)
        {
            Form zitarice = new Form_Zitarice();
            zitarice.ShowDialog();
        }

        private void btn_Voćnjaci_Click(object sender, EventArgs e)
        {
            Form vocnjaci = new Form_Vocnjaci();
            vocnjaci.ShowDialog();
        }

        private void btn_Povrce_Click(object sender, EventArgs e)
        {
            Form povrce = new Form_Povrce();
            povrce.ShowDialog();
        }

        private void btn_KrmnoBilje_Click(object sender, EventArgs e)
        {
            Form krma = new Form_Krmno_Bilje();
            krma.ShowDialog();
        }
    }
}
