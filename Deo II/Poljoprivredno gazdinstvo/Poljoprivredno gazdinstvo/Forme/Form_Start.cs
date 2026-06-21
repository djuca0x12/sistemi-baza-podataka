using NHibernate.Type;
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

            // stilizovanje forme
            ApplyStardewStyle(this);
            this.BackColor = Color.FromArgb(243, 208, 144);
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
            Form proizvode = new Form_Proizvode();

            proizvode.ShowDialog();
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

        public static void ApplyStardewStyle(Control parent)
        {
            Color earthyParchment = Color.FromArgb(243, 208, 144); // #F3D090 (Main BG)
            Color darkWoodenBrown = Color.FromArgb(92, 49, 25);   // #5C3119 (Borders / Lines)
            Color buttonWood = Color.FromArgb(230, 176, 108); // #E6B06C (Buttons)
            Color softCreamText = Color.FromArgb(255, 240, 208); // #FFF0D0 (Highlights)
            Color deepText = Color.FromArgb(70, 31, 10);    // #461F0A (Main Text)
            Color gridRowAlt = Color.FromArgb(235, 195, 130); // Slightly darker parchment for alternating rows

            Font retroFont = new Font("Courier New", 10, FontStyle.Bold);
            Font headerFont = new Font("Courier New", 11, FontStyle.Bold);

            foreach (Control c in parent.Controls)
            {
                c.Font = retroFont;

                if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = earthyParchment;
                    dgv.RowsDefaultCellStyle.ForeColor = deepText;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = deepText;
                    dgv.RowHeadersDefaultCellStyle.ForeColor = deepText;
                    dgv.GridColor = darkWoodenBrown;
                    dgv.BorderStyle = BorderStyle.FixedSingle;

                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.RowTemplate.Height = 32;

                    dgv.EnableHeadersVisualStyles = false;

                    dgv.RowsDefaultCellStyle.BackColor = earthyParchment;
                    dgv.RowsDefaultCellStyle.ForeColor = deepText;
                    dgv.RowsDefaultCellStyle.SelectionBackColor = softCreamText;
                    dgv.RowsDefaultCellStyle.SelectionForeColor = deepText;
                    dgv.RowsDefaultCellStyle.Font = retroFont;

                    dgv.AlternatingRowsDefaultCellStyle.BackColor = gridRowAlt;

                    dgv.ColumnHeadersDefaultCellStyle.BackColor = buttonWood;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = deepText;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = buttonWood;
                    dgv.ColumnHeadersDefaultCellStyle.Font = headerFont;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    dgv.ColumnHeadersHeight = 35;

                    dgv.RowHeadersDefaultCellStyle.BackColor = buttonWood;
                    dgv.RowHeadersDefaultCellStyle.ForeColor = deepText;
                    dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                }
                else if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = buttonWood;
                    btn.ForeColor = deepText;
                    btn.FlatAppearance.BorderColor = darkWoodenBrown;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.FlatAppearance.MouseOverBackColor = softCreamText;
                }
                else if (c is Panel || c is GroupBox)
                {
                    c.BackColor = earthyParchment;
                    c.ForeColor = deepText;
                }
                else if (c is Label lbl)
                {
                    lbl.ForeColor = deepText;
                }
                else if (c is TextBox || c is ComboBox)
                {
                    c.BackColor = softCreamText;
                    c.ForeColor = deepText;
                }

                if (c.HasChildren)
                {
                    ApplyStardewStyle(c);
                }
            }
        }
    }
}
