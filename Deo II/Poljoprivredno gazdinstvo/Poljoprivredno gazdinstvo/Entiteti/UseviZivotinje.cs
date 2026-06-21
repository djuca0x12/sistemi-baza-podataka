using NHibernate.Type;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class UseviZivotinje
    {
        public virtual int UseviZivotinjeId { get; set; }
        public virtual char KategorijaTip {  get; set; }
        
        // Veza 1:N (slabi tip entiteta)
        public virtual IList<Subvencija> Subvencije { get; set; }

        // Veza prema Proizvode:
        public virtual IList<Proizvode> Proizvodi { get; set; } = new List<Proizvode>();
    }
}
