
namespace PoljoprivrednoGazdinstvoLibrary.Entiteti
{
    public class Subvencija
    {
        public virtual int IdSubvencija { get; set; }
        public virtual string BrojResenja { get; set; }
        public virtual string Vrsta { get; set; }
        public virtual double Iznos { get; set; }
        public virtual string Valuta { get; set; }
        public virtual DateTime DatumPodnosenja { get; set; }
        public virtual DateTime? DatumOdobrenja { get; set; } // Moze biti null
        public virtual string Status { get; set; }
        public virtual string Komentar { get; set; }

        // Veza 1:N (slabi tip entiteta)
        public virtual UseviZivotinje Kategorija { get; set; }
    }
}
