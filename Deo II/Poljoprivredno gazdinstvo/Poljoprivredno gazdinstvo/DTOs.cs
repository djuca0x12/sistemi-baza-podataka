using FluentNHibernate.Conventions.Inspections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Poljoprivredno_gazdinstvo
{
    #region Mehanizacija  

    public class MehanizacijaPregled
    {
        public int IdMehanizacija { get; set; }
        public string BrojSasije { get; set; }
        public string Status { get; set; }
        public string Model { get; set; }

        public MehanizacijaPregled() { }

        public MehanizacijaPregled(int id, string brojSasije, string status, string model)
        {
            IdMehanizacija = id;
            BrojSasije = brojSasije;
            Status = status;
            Model = model;
        }
    }

    public class MehanizacijaBasic
    {
        public int IdMehanizacija { get; set; }
        public string BrojSasije { get; set; }
        public string Status { get; set; }
        public string Komentar { get; set; }
        public string Model { get; set; }
        public DateTime? DatumKupovine { get; set; }
        public int? GodinaProizvodnje { get; set; }

        public MehanizacijaBasic() { }

        public MehanizacijaBasic(int id, string brojSasije, string status, string komentar, string model, DateTime? datum, int? godina)
        {
            IdMehanizacija = id;
            BrojSasije = brojSasije;
            Status = status;
            Komentar = komentar;
            Model = model;
            DatumKupovine = datum;
            GodinaProizvodnje = godina;
        }
    }

    #endregion

    #region Traktor
    public class TraktorPregled : MehanizacijaPregled
    {
        public double? Snaga { get; set; }
        public decimal? RadniSati { get; set; }

        public TraktorPregled() { }

        public TraktorPregled(int id, string brojSasije, string status, string model, double? snaga, decimal? radniSati)
            : base(id, brojSasije, status, model)
        {
            Snaga = snaga;
            RadniSati = radniSati;
        }
    }

    public class TraktorBasic : MehanizacijaBasic
    {
        public double? Snaga { get; set; }
        public decimal? RadniSati { get; set; }
        public string BrojMotora { get; set; }

        public TraktorBasic() { }

        public TraktorBasic(int id, string brojSasije, string status, string komentar, string model, DateTime? datum, int? godina, double? snaga, decimal? radniSati, string brojMotora)
            : base(id, brojSasije, status, komentar, model, datum, godina)
        {
            Snaga = snaga;
            RadniSati = radniSati;
            BrojMotora = brojMotora;
        }
    }
    #endregion

    #region Masina
    public class MasinaPregled : MehanizacijaPregled
    {
        public int? BrojTockova { get; set; }

        public MasinaPregled() { }

        public MasinaPregled(int id, string brojSasije, string status, string model, int? brojTockova)
            : base(id, brojSasije, status, model)
        {
            BrojTockova = brojTockova;
        }
    }

    public class MasinaBasic : MehanizacijaBasic
    {
        public int? BrojTockova { get; set; }

        public MasinaBasic() { }

        public MasinaBasic(int id, string brojSasije, string status, string komentar, string model, DateTime? datum, int? godina, int? brojTockova)
            : base(id, brojSasije, status, komentar, model, datum, godina)
        {
            BrojTockova = brojTockova;
        }
    }
    #endregion

    #region Prinos

    public class PrinosBasic
    {
        public int IdPrinosa { get; set; }
        public string Tip { get; set; }
        public decimal Kolicina { get; set; }
        public string Komentar { get; set; }
        public string KvalitetProizvoda { get; set; }
        public string JedinicaMere { get; set; }

        public PrinosBasic()
        {
        }

        public PrinosBasic(int idPrinosa, string tip, decimal kolicina, string komentar, string kvalitetProizvoda, string jedinicaMere)
        {
            IdPrinosa = idPrinosa;
            Tip = tip;
            Kolicina = kolicina;
            Komentar = komentar;
            KvalitetProizvoda = kvalitetProizvoda;
            JedinicaMere = jedinicaMere;
        }
    }

    #endregion

    #region Prodaja

    public class ProdajaBasic
    {
        public int IdProdaja { get; set; }
        public string BrojFakture { get; set; }
        public int IdPrinosa { get; set; }
        public string TipPlacanja { get; set; }
        public string Komentar { get; set; }
        public decimal CenaPoJedinici { get; set; }
        public string JedinicaMere { get; set; }
        public DateTime Datum { get; set; }
        public decimal Kolicina { get; set; }
        public string Kupac { get; set; }

        public ProdajaBasic() { }

        public ProdajaBasic(int idProdaja, string brojFakture, int idPrinosa, string tipPlacanja, string komentar, decimal cenaPoJedinici, string jedinicaMere, DateTime datum, decimal kolicina, string kupac)
        {
            IdProdaja = idProdaja;
            BrojFakture = brojFakture;
            IdPrinosa = idPrinosa;
            TipPlacanja = tipPlacanja;
            Komentar = komentar;
            CenaPoJedinici = cenaPoJedinici;
            JedinicaMere = jedinicaMere;
            Datum = datum;
            Kolicina = kolicina;
            Kupac = kupac;
        }
    }

    public class ProdajaPregled
    {
        public int IdProdaja { get; set; }
        public string BrojFakture { get; set; }
        public int IdPrinosa { get; set; }
        public string TipPlacanja { get; set; }
        public string Komentar { get; set; }
        public decimal CenaPoJedinici { get; set; }
        public string JedinicaMere { get; set; }
        public DateTime Datum { get; set; }
        public decimal Kolicina { get; set; }
        public IList<KupacBasic> Kupci { get; set; }

        public ProdajaPregled() { Kupci = new List<KupacBasic>(); }

        public ProdajaPregled(int idProdaja, string brojFakture, int idPrinosa, string tipPlacanja, string komentar, decimal cenaPoJedinici, string jedinicaMere, DateTime datum, decimal kolicina, IList<KupacBasic> Kupci)
        {
            IdProdaja = idProdaja;
            BrojFakture = brojFakture;
            IdPrinosa = idPrinosa;
            TipPlacanja = tipPlacanja;
            Komentar = komentar;
            CenaPoJedinici = cenaPoJedinici;
            JedinicaMere = jedinicaMere;
            Datum = datum;
            Kolicina = kolicina;
            this.Kupci = Kupci;
        }
    }

    #endregion

    #region Kupac

    public class KupacBasic
    {
        public int IdKupac { get; set; }
        public string Kupac { get; set; }

        public KupacBasic() { }

        public KupacBasic(int idKupac, string kupac)
        {
            IdKupac = idKupac;
            Kupac = kupac;
        }
    }

    #endregion

    #region Zivotinje
    public class ZivotinjeBasic
    {
        public int IdZivotinje { get; set; }
        public string BrojUha { get; set; }
        public string Vrsta { get; set; }
        public char Pol { get; set; }
        public string Rasa { get; set; }
        public int BrojJedinki { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumUlaska { get; set; }
        public double Tezina { get; set; }
        public string Status { get; set; }
        public string Komentar { get; set; }

        public ZivotinjeBasic() { }
        public ZivotinjeBasic(int idZivotinje, string brojUha, string vrsta, char pol, string rasa, int brojJedinki, DateTime datumRodjenja, DateTime datumUlaska, double tezina, string status, string komentar)
        {
            IdZivotinje = idZivotinje;
            BrojUha = brojUha;
            Vrsta = vrsta;
            Pol = pol;
            Rasa = rasa;
            BrojJedinki = brojJedinki;
            DatumRodjenja = datumRodjenja;
            DatumUlaska = datumUlaska;
            Tezina = tezina;
            Status = status;
            Komentar = komentar;
        }
    }

    #endregion

    #region Usevi
    public class UseviBasic
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public string Vrsta { get; set; }
        public double Povrsina { get; set; }
        public string KvalitetZemljista { get; set; }
        public DateTime DatumSetve { get; set; }
        public DateTime DatumZetvePlanirani { get; set; }
        public DateTime DatumZetveStvarni { get; set; }
        public string Status { get; set; }
        public string Komentar { get; set; }

        public UseviBasic() { }
        public UseviBasic(int id, string naziv, string lokacija, string vrsta, double povrsina,
            string kvalitetZemljista, DateTime datumSetve, DateTime datumZetvePlanirani,
            DateTime datumZetveStvarni, string status, string komentar)
        {
            Id = id;
            Naziv = naziv;
            Lokacija = lokacija;
            Vrsta = vrsta;
            Povrsina = povrsina;
            KvalitetZemljista = kvalitetZemljista;
            DatumSetve = datumSetve;
            DatumZetvePlanirani = datumZetvePlanirani;
            DatumZetveStvarni = datumZetveStvarni;
            Status = status;
            Komentar = komentar;
        }
    }
    #endregion

    #region Zitarice
    public class ZitariceBasic : UseviBasic
    {
        public double GustinaSetve { get; set; }
        public double KolicinaSemenaPoHektaru { get; set; }
        public double PrinosPoHektaru { get; set; }
        public string TipDjubrenja { get; set; }
        public string Tip { get; set; }

        public ZitariceBasic() : base() { }
        public ZitariceBasic(int id, string naziv, string lokacija, string vrsta, double povrsina,
            string kvalitetZemljista, DateTime datumSetve, DateTime datumZetvePlanirani,
            DateTime datumZetveStvarni, string status, string komentar,
            double gustinaSetve, double kolicinaSemenaPoHektaru,
            double prinosPoHektaru, string tipDjubrenja, string tip)
            : base(id, naziv, lokacija, vrsta, povrsina, kvalitetZemljista, datumSetve,
                  datumZetvePlanirani, datumZetveStvarni, status, komentar)
        {
            GustinaSetve = gustinaSetve;
            KolicinaSemenaPoHektaru = kolicinaSemenaPoHektaru;
            PrinosPoHektaru = prinosPoHektaru;
            TipDjubrenja = tipDjubrenja;
            Tip = tip;
        }
    }
    #endregion

    #region Vocnjaci
    public class VocnjaciBasic : UseviBasic
    {
        public int GodinaSadnje { get; set; }
        public int BrojStabala { get; set; }
        public string Sorta { get; set; }
        public DateTime DatumRezidbe { get; set; }
        public string RodniCiklus { get; set; }

        public VocnjaciBasic() : base() { }
        public VocnjaciBasic(int id, string naziv, string lokacija, string vrsta, double povrsina,
            string kvalitetZemljista, DateTime datumSetve, DateTime datumZetvePlanirani,
            DateTime datumZetveStvarni, string status, string komentar,
            int godinaSadnje, int brojStabala, string sorta,
            DateTime datumRezidbe, string rodniCiklus)
            : base(id, naziv, lokacija, vrsta, povrsina, kvalitetZemljista, datumSetve,
                  datumZetvePlanirani, datumZetveStvarni, status, komentar)
        {
            GodinaSadnje = godinaSadnje;
            BrojStabala = brojStabala;
            Sorta = sorta;
            DatumRezidbe = datumRezidbe;
            RodniCiklus = rodniCiklus;
        }
    }
    #endregion

    #region Povrce
    public class PovrceBasic : UseviBasic
    {
        public int BrojSetviGodisnje { get; set; }
        public string ZastitneMere { get; set; }
        public string NacinGajenja { get; set; }
        public string Tip { get; set; }

        public PovrceBasic() : base() { }
        public PovrceBasic(int id, string naziv, string lokacija, string vrsta, double povrsina,
            string kvalitetZemljista, DateTime datumSetve, DateTime datumZetvePlanirani,
            DateTime datumZetveStvarni, string status, string komentar,
            int brojSetviGodisnje, string zastitneMere, string nacinGajenja, string tip)
            : base(id, naziv, lokacija, vrsta, povrsina, kvalitetZemljista, datumSetve,
                  datumZetvePlanirani, datumZetveStvarni, status, komentar)
        {
            BrojSetviGodisnje = brojSetviGodisnje;
            ZastitneMere = zastitneMere;
            NacinGajenja = nacinGajenja;
            Tip = tip;
        }
    }
    #endregion

    #region KrmnoBilje
    public class KrmnoBiljeBasic : UseviBasic
    {
        public string VrstaKrme { get; set; }
        public int BrojKosnjiGodisnje { get; set; }
        public int ProcenatProteina { get; set; }
        public int IshranaStokeFlag { get; set; }
        public int ZaProdajuFlag { get; set; }
        public KrmnoBiljeBasic() : base() { }
        public KrmnoBiljeBasic(int id, string naziv, string lokacija, string vrsta, double povrsina,
            string kvalitetZemljista, DateTime datumSetve, DateTime datumZetvePlanirani,
            DateTime datumZetveStvarni, string status, string komentar,
            string vrstaKrme, int brojKosnjiGodisnje, int procenatProteina,
            int ishranaStokeFlag, int zaProdajuFlag)
            : base(id, naziv, lokacija, vrsta, povrsina, kvalitetZemljista, datumSetve,
                  datumZetvePlanirani, datumZetveStvarni, status, komentar)
        {
            VrstaKrme = vrstaKrme;
            BrojKosnjiGodisnje = brojKosnjiGodisnje;
            ProcenatProteina = procenatProteina;
            IshranaStokeFlag = ishranaStokeFlag;
            ZaProdajuFlag = zaProdajuFlag;
        }
    }
    #endregion
}
