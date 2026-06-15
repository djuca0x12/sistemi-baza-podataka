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
            //DTOManager.DodajKupceIzSkripte();
        }
    }
}
