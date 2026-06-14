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
    public partial class Form_Traktor : Form
    {
        public Form_Traktor()
        {
            InitializeComponent();
            //UcitajTraktoreUListView();
        }


        private void UcitajTraktore()
        {
            try
            {
                List<TraktorBasic> listaTraktora = DTOManager.UcitajTraktore();

                dataGridViewTraktori.DataSource = listaTraktora;

                // Ne prikazuje podatak na tabeli, ali je i dalje tu!
                if (dataGridViewTraktori.Columns["IdMehanizacija"] != null)
                {
                    dataGridViewTraktori.Columns["IdMehanizacija"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Traktor_Load(object sender, EventArgs e)
        {
            UcitajTraktore();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form DodajTraktor = new Form_Dodaj_Traktor();

            DodajTraktor.ShowDialog();
        }
    }
}
