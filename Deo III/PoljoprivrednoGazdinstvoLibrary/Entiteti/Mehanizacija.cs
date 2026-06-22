
namespace PoljoprivrednoGazdinstvoLibrary.Entiteti
{
    // Ne mozemo da instanciramo Mehanizaciju samu za sebe,
    // ali mozemo izvedene klase. Pritom prilikom cuvanja podatka
    // izvedene klase, oni se upisuju u jednu tabelu u bazi (tip C).
    public abstract class Mehanizacija
    {
        public virtual int IdMehanizacija { get; set; }
        public virtual string BrojSasije { get; set; }
        public virtual string Status { get; set; }
        public virtual string Komentar { get; set; }
        public virtual string Model { get; set; }
        public virtual DateTime? DatumKupovine { get; set; }
        public virtual int? GodinaProizvodnje { get; set; }
        //public virtual string TipMehanizacije { get; set; } => Ne pamtimo kao atirbut

        // Veza N:M:
        public virtual IList<KoristiZa> KoriscenjeZaPrinose { get; set; } = new List<KoristiZa>();
    }

    public class Traktor : Mehanizacija
    {
        // Podaci za traktor
        public virtual double? Snaga { get; set; }
        public virtual decimal? RadniSati { get; set; }
        public virtual string BrojMotora { get; set; } // string sam po sebi moze da bude null
    }

    public class Masina : Mehanizacija
    {
        // Podatak za masinu
        public virtual int? BrojTockova { get; set; }
    }
}
