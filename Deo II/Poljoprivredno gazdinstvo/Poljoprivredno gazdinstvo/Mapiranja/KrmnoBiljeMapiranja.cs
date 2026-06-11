namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class KrmnoBiljeMapiranja : SubclassMap<KrmnoBilje>
    {
        public KrmnoBiljeMapiranja()
        {
            Table("KRMNO_BILJE");

            KeyColumn("IDUSEVI");

            Map(x => x.VrstaKrme, "VRSTA");
            Map(x => x.BrojKosnjiGodisnje);
            Map(x => x.ProcenatProteina);
            Map(x => x.IshranaStokeFlag);
            Map(x => x.ZaProdajuFlag);
        }
    }
}
