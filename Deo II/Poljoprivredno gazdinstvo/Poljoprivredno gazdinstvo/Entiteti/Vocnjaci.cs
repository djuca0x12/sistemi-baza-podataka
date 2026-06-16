namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Vocnjaci : Usevi
    {
        // nasleđuje se pk roditeljske klase
        public virtual int GodinaSadnje { get; set; }
        public virtual int BrojStabala { get; set; }
        public virtual string Sorta { get; set; }
        public virtual DateTime DatumRezidbe { get; set; }
        public virtual string RodniCiklus { get; set; }

    }
}
