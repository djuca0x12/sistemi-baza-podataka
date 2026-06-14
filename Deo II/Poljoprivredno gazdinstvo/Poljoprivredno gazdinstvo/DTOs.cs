using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
