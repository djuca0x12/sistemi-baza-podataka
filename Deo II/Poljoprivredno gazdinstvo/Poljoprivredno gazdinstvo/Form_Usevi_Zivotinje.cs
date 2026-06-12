using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poljoprivredno_gazdinstvo
{
    public partial class Form_Usevi_Zivotinje : Form
    {
        Zivotinje zivotinje;
        public Form_Usevi_Zivotinje()
        {
            InitializeComponent();
        }

        public Form_Usevi_Zivotinje(Zivotinje z)
        {
            InitializeComponent();
            zivotinje = z;
        }

        private void Form_Usevi_Zivotinje_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            // todo: treba pozvati DTOManager, koji pokupi sve životinje bez kategorije
            // (očigledno dto treba da izbaci tu vezu?)
            try
            {
                dgv_Zivotinje.DataSource = null;

                using (ISession s = DataLayer.GetSession())
                {
                    List<Zivotinje> sveZivotinje = s.Query<Zivotinje>().ToList();

                    s.Close();

                    dgv_Zivotinje.DataSource = sveZivotinje;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri čitanju podataka: {ec.FormatExceptionMessage()}");
            }
        }

        private void Dodaj_Životinju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // prvo se upiše novi red u tabeli za kategoriju
                //UseviZivotinje uz = new()
                //{
                //    // sekvenca popuni id
                //    KategorijaTip = 'z'
                //};

                //s.Save(uz);
                //s.Flush();

                Zivotinje z = new()
                {
                    BrojUha = "TEST002",
                    Vrsta = "prase",
                    Pol = 'M',
                    Rasa = "test",
                    BrojJedinki = 1,
                    DatumRodjenja = new DateTime(2021, 11, 11),
                    DatumUlaska = new DateTime(2021, 12, 12),
                    Tezina = 750,
                    Status = "aktivna",
                    //Kategorija = uz,
                    Komentar = "Test unos!"
                };

                s.Save(z);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspešno upisana životinja!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void Dodaj_Povrce_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // prvo se upiše novi red u tabeli za kategoriju
                //UseviZivotinje uz = new()
                //{
                //    // sekvenca popuni id
                //    KategorijaTip = 'u'
                //};

                //s.Save(uz);
                //s.Flush();

                Povrce p = new()
                {
                    Naziv = "Kupus 5",
                    Lokacija = "Plastenik 5",
                    Vrsta = "povrce",
                    Povrsina = 500,
                    KvalitetZemljista = "Visok",
                    DatumSetve = DateTime.Now,
                    DatumZetvePlanirani = DateTime.Now.AddDays(45),
                    DatumZetveStvarni = DateTime.Now.AddDays(55),
                    Status = "u toku",
                    Komentar = "Redovno tretirati protiv puževa",
                    //Kategorija = uz,

                    BrojSetviGodisnje = 3,
                    ZastitneMere = "Fizičke mreže",
                    NacinGajenja = "na otvorenom",
                    Tip = "lisnato"
                };

                s.Save(p);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspešno dodavanje povrća!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void Dodaj_Vocnjak_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vocnjaci v = new()
                {
                    Naziv = "Kategorija test",
                    Lokacija = "Niš Kat",
                    Vrsta = "voce",
                    Povrsina = 10000,
                    KvalitetZemljista = "plodno",
                    DatumSetve = new DateTime(2025, 1, 1),
                    DatumZetvePlanirani = new DateTime(2026, 1, 1),
                    DatumZetveStvarni = new DateTime(2026, 5, 5),
                    Status = "zavrseno",
                    Komentar = "test",
                    //Kategorija = s.Load<UseviZivotinje>(3),

                    // atributi izvedene klase
                    GodinaSadnje = 2026,
                    BrojStabala = 15,
                    Sorta = "mandarina",
                    DatumRezidbe = new DateTime(2022, 11, 11),
                    RodniCiklus = "test!"
                };

                s.Save(v);

                // prvo se upiše novi red u tabeli za kategoriju
                UseviZivotinje uz = new()
                {
                    // sekvenca popuni id
                    KategorijaTip = 'u'
                };
                s.Save(uz);

                v.Kategorija = uz;
                s.Save(v);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspešno dodavanje voćnjaka!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void Dodaj_zitarice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zitarice z = new()
                {
                    Naziv = "Nova psenica",
                    Lokacija = "Banat",
                    Vrsta = "zitarice",
                    Povrsina = 12000,
                    KvalitetZemljista = "plodno",
                    DatumSetve = new DateTime(2025, 1, 1),
                    DatumZetvePlanirani = new DateTime(2026, 1, 1),
                    DatumZetveStvarni = new DateTime(2026, 5, 5),
                    Status = "zavrseno",
                    Komentar = "test",
                    Kategorija = s.Load<UseviZivotinje>(3),

                    // atributi izvedene klase
                    GustinaSetve = 135,
                    KolicinaSemenaPoHektaru = 12.0,
                    PrinosPoHektaru = 18.5,
                    TipDjubrenja = "mineralno",
                    Tip = "psenica"
                };

                s.Save(z);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspešno dodavanje žitarice!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void Dodaj_Krmno_Bilje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KrmnoBilje kb = new()
                {
                    Naziv = "Krmno bilje 2",
                    Lokacija = "Srem",
                    Vrsta = "krmno bilje",
                    Povrsina = 17000,
                    KvalitetZemljista = "plodno",
                    DatumSetve = new DateTime(2025, 1, 1),
                    DatumZetvePlanirani = new DateTime(2026, 1, 1),
                    DatumZetveStvarni = new DateTime(2026, 5, 5),
                    Status = "zavrseno",
                    Komentar = "test",
                    Kategorija = s.Load<UseviZivotinje>(3),

                    // atributi izvedene klase
                    VrstaKrme = "detelina",
                    BrojKosnjiGodisnje = 5,
                    ProcenatProteina = 55,
                    IshranaStokeFlag = 0,
                    ZaProdajuFlag = 1
                };

                s.Save(kb);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspešno dodavanje žitarice!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void btn_Izmeni_Zivotinju_Click(object sender, EventArgs e)
        {

        }

        private void btn_Obrisi_Zivotinju_Click(object sender, EventArgs e)
        {

        }
    }
}
