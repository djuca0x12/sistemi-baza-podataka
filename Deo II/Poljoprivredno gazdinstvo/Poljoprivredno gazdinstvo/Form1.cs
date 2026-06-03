using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Linq;
using Poljoprivredno_gazdinstvo.Entiteti;

namespace Poljoprivredno_gazdinstvo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Traktor probniTraktor = new Traktor
                {
                    BrojSasije = "SAS-TRAKTOR-2027",
                    Status = "u upotrebi",
                    Model = "IMT 539",
                    Komentar = "u dobrom stanju",
                    DatumKupovine = DateTime.Now,
                    GodinaProizvodnje = 2020,

                    Snaga = 39,
                    RadniSati = 12,
                    BrojMotora = "MOT-12345"
                };

                s.Save(probniTraktor);
                s.Flush();

                Masina probnaMasina = new Masina
                {
                    BrojSasije = "SAS-MASINA-2028",
                    Status = "u upotrebi",
                    Komentar = "u dobrom stanju",
                    Model = "Sejalica S-100",
                    DatumKupovine = DateTime.Now,
                    GodinaProizvodnje = 2023,

                    BrojTockova = 4
                };

                s.Save(probnaMasina);
                s.Flush();

                s.Close();

                MessageBox.Show("Upesno upisani traktor i masina!?");
            }
            catch (Exception ex)
            {
                string stvarnaGreska = ex.Message;
                if (ex.InnerException != null)
                {
                    stvarnaGreska += "\nDetalji: " + ex.InnerException.Message;
                }

                MessageBox.Show($"Greška prilikom upisa: {stvarnaGreska}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prinos noviPrinos = new Prinos
                {
                    Tip = "Eko Pšenica 2026",
                    Kolicina = 1500.50,
                    JedinicaMere = "kg",
                    KvalitetProizvoda = "Prva klasa",
                    Komentar = "Izuzetno suva i čista"
                };

                s.Save(noviPrinos);

                Prodaja novaProdaja = new Prodaja
                {
                    BrojFakture = "FAK-2026-001",
                    TipPlacanja = "Preko računa",
                    CenaPoJedinici = 24.50,
                    Kolicina = 1000,
                    JedinicaMere = "kg",
                    Datum = DateTime.Now,
                    Komentar = "Isporuka kupcu odmah",
                    Prinos = noviPrinos
                };

                s.Save(novaProdaja);

                s.Close();

                MessageBox.Show("Upesno upisani prinos i prodaja!?");
            }
            catch (Exception ex)
            {
                string stvarnaGreska = ex.Message;
                if (ex.InnerException != null)
                {
                    stvarnaGreska += "\nDetalji: " + ex.InnerException.Message;
                }

                MessageBox.Show($"Greška prilikom upisa: {stvarnaGreska}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodaja postojecaProdaja = s.Load<Prodaja>(1);
                Prinos postojeciPrinos = postojecaProdaja.Prinos;

                if(postojeciPrinos != null && postojecaProdaja != null)
                {
                    Kupac kupac = new Kupac
                    {
                        KupacIme = "Filip Stevanovic",
                        Prinos = postojeciPrinos,
                        Prodaja = postojecaProdaja
                    };

                    s.Save(kupac);
                    s.Flush();

                    MessageBox.Show("Upesno upisani kupac!?");
                }

                s.Close();

                
            }
            catch (Exception ex)
            {
                string stvarnaGreska = ex.Message;
                if (ex.InnerException != null)
                {
                    stvarnaGreska += "\nDetalji: " + ex.InnerException.Message;
                }

                MessageBox.Show($"Greška prilikom upisa: {stvarnaGreska}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Mehanizacija m = s.Load<Mehanizacija>(1);
                Prinos p = s.Load<Prinos>(1);

                if (m != null && p != null)
                {
                    KoristiZa k = new KoristiZa
                    {
                        Mehanizacija = m,
                        Prinos = p,
                        DatumOd = DateTime.Now.AddDays(-5),
                        DatumDo = DateTime.Now
                    };

                    s.Save(k);
                    s.Flush();

                    MessageBox.Show("Upesno upisano koristi_za!?");
                }

                s.Close();


            }
            catch (Exception ex)
            {
                string stvarnaGreska = ex.Message;
                if (ex.InnerException != null)
                {
                    stvarnaGreska += "\nDetalji: " + ex.InnerException.Message;
                }

                MessageBox.Show($"Greška prilikom upisa: {stvarnaGreska}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                UseviZivotinje uz = s.Load<UseviZivotinje>(1);

                if(uz != null)
                {
                    Subvencija novaSubvencija = new Subvencija
                    {
                        BrojResenja = "SUB-2026-X992",             
                        Vrsta = "podsticaj za setvu",              
                        Iznos = 45000.00,
                        Valuta = "RSD",
                        DatumPodnosenja = DateTime.Now,            
                        DatumOdobrenja = null,                     
                        Status = "U obradi",
                        Komentar = "Zahtev za dizel gorivo i seme za prolećnu setvu.",
                        Kategorija = uz          
                    };

                    s.Save(novaSubvencija);
                    s.Flush();

                    MessageBox.Show("Upesno upisana subvencija!?");
                }

                s.Close();


            }
            catch (Exception ex)
            {
                string stvarnaGreska = ex.Message;
                if (ex.InnerException != null)
                {
                    stvarnaGreska += "\nDetalji: " + ex.InnerException.Message;
                }

                MessageBox.Show($"Greška prilikom upisa: {stvarnaGreska}");
            }
        }
    }
}
