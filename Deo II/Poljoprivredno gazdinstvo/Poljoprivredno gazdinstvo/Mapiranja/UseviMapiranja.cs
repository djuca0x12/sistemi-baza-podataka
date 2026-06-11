namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class UseviMapiranja : ClassMap<Usevi>
    {
        public UseviMapiranja()
        {
            Table("USEVI");

            Id(x => x.Id).Column("ID").GeneratedBy.Sequence("USEVI_SEQ");

            Map(x => x.Naziv);
            Map(x => x.Lokacija);
            Map(x => x.Vrsta);
            Map(x => x.Povrsina);
            Map(x => x.KvalitetZemljista);
            Map(x => x.DatumSetve);
            Map(x => x.DatumZetvePlanirani);
            Map(x => x.DatumZetveStvarni);
            Map(x => x.Status);
            Map(x => x.Komentar);

            // veza sa kategorijom
            References(x => x.Kategorija)
                .Column("USEVIZIVOTINJEID")
                .Nullable();
        }
    }
}
