namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Zitarice : Usevi
    {
        // nasleđuje se pk roditeljske klase
        public virtual double GustinaSetve { get; set; }
        public virtual double KolicinaSemenaPoHektaru { get; set; }
        public virtual double PrinosPoHektaru { get; set; }
        public virtual string TipDjubrenja { get; set; }
        public virtual string Tip {  get; set; }

        public Zitarice() { }
    }
}
