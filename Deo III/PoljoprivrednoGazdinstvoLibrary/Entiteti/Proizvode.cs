
namespace PoljoprivrednoGazdinstvoLibrary.Entiteti
{
    public class Proizvode
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime DatumProizvodnje { get; set; }

        
        // Povezan je sa kategorijom i prinosom:
        public virtual UseviZivotinje Kategorija { get; set; }
        public virtual Prinos Prinos { get; set; }
    }
}
