namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class UseviZivotinje
    {
        public virtual int UseviZivotinjeId { get; set; }
        
        // Veza 1:N (slabi tip entiteta)
        public virtual IList<Subvencija> Subvencije { get; set; }
    }
}
