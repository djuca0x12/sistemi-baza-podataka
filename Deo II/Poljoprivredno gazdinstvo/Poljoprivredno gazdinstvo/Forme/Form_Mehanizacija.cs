using Poljoprivredno_gazdinstvo.Properties;
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
    public partial class Form_Mehanizacija : Form
    {
        public Form_Mehanizacija()
        {
            InitializeComponent();

            imageTraktor.Image = Resources.Traktor2;
            imageMasina.Image = Resources.Masina2;
        }

        private void btnTraktori_Click(object sender, EventArgs e)
        {
            Form traktori = new Form_Traktor();

            traktori.ShowDialog();
        }

        private void btnMasine_Click(object sender, EventArgs e)
        {
            Form masine = new Form_Masine();

            masine.ShowDialog();
        }
    }
}
