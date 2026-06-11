namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Povrce : Usevi
    {
        // parcijalna disjoint alternativa C (TPH)
        // nasleđuje se pk roditeljske klase
        public virtual int BrojSetviGodisnje { get; set; }
        public virtual string ZastitneMere { get; set; }
        public virtual string NacinGajenja { get; set; }
        public virtual string Tip { get; set; } // da li se pamti?
        public virtual string Boja { get; set; }
        public virtual int? TezinaPloda { get; set; }
        public virtual int? DubinaZemljista { get; set; }
        public virtual string UcestalostZalivanja { get; set; }
    }
}
