namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Povrce : Usevi
    {
        // nasleđuje se pk roditeljske klase
        public virtual int BrojSetviGodisnje { get; set; }
        public virtual string ZastitneMere { get; set; }
        public virtual string NacinGajenja { get; set; }
        public virtual string Tip { get; set; } // diskriminatorni atribut
    }
}