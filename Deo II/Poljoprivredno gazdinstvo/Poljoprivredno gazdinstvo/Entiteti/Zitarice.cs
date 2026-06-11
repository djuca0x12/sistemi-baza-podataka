namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public abstract class Zitarice : Usevi
    {
        // totalna alternativa C (TPH): sve u jednoj tabeli
        // nasleđuje se pk roditeljske klase
        public virtual double GustinaSetve { get; set; }
        public virtual double KolicinaSemenaPoHektaru { get; set; }
        public virtual double PrinosPoHektaru { get; set; }
        public virtual string TipDjubrenja { get; set; }
        // diskriminatorni atribut
        public virtual string Tip {  get; set; }    // da li se pamti?

        public Zitarice() { }
    }

    public class Psenica : Zitarice
    {
        public virtual double ProcenatGlutena { get; set; }
    }
    public class Kukuruz : Zitarice
    {
        public virtual double TezinaKlipa { get; set; }
    }
    public class Jecam : Zitarice
    {
        public virtual double KalorijskaVrednost { get; set; }
    }
}
