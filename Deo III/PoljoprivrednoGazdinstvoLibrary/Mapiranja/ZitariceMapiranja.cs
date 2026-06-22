namespace PoljoprivrednoGazdinstvoLibrary.Mapiranja
{
    public class ZitariceMapiranja : SubclassMap<Zitarice>
    {
        public ZitariceMapiranja()
        {
            Table("ZITARICE");

            KeyColumn("IDUSEVI");

            Map(x => x.GustinaSetve);
            Map(x => x.KolicinaSemenaPoHektaru);
            Map(x => x.PrinosPoHektaru);
            Map(x => x.TipDjubrenja);
            Map(x => x.Tip);    // psenica, jecam, kukuruz
        }
    }
}
