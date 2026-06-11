using System.Transactions;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    // Usevi ne mogu biti instancirani, već samo nasleđene klase
    // (disjoint u EER modelu)
    public abstract class Usevi
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string Vrsta { get; set; }
        public virtual double Povrsina { get; set; }
        public virtual string KvalitetZemljista { get; set; }
        public virtual DateTime DatumSetve {  get; set; }
        public virtual DateTime DatumZetvePlanirani { get; set; }
        public virtual DateTime DatumZetveStvarni { get; set; }
        public virtual string Status { get; set; }
        public virtual string Komentar { get; set; }

        // referenca na kategoriju nije obavezna, možda se entitet ne prodaje
        public virtual UseviZivotinje? Kategorija { get; set; }

        public Usevi() { }
    }
}
