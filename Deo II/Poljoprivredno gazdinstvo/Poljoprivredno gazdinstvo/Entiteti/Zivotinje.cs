namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Zivotinje
    {
        public virtual int IdZivotinje { get; set; }
        public virtual string BrojUha { get; set; }
        public virtual string Vrsta { get; set; }
        public virtual char Pol {  get; set; }
        public virtual string Rasa { get; set; }
        public virtual int BrojJedinki { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual DateTime DatumUlaska { get; set; }

        public virtual double Tezina { get; set; }
        public virtual string Status { get; set; }
        public virtual string Komentar { get; set; }

        public virtual UseviZivotinje? Kategorija { get; set; }

        public Zivotinje()
        {

        }
    }
}
