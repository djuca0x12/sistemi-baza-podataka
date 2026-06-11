namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class PovrceMapiranja : SubclassMap<Povrce>
    {
        public PovrceMapiranja()
        {
            // alternativa A: table-per-class
            Table("Povrce");

            KeyColumn("IDUSEVI");

            Map(x => x.BrojSetviGodisnje);
            Map(x => x.ZastitneMere);
            Map(x => x.NacinGajenja);
            Map(x => x.Tip);    // korenasto, listato, plodovito ili null
        }
    }
}