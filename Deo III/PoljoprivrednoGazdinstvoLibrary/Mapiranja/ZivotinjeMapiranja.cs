namespace PoljoprivrednoGazdinstvoLibrary.Mapiranja
{
    public class ZivotinjeMapiranja : ClassMap<Zivotinje>
    {
        public ZivotinjeMapiranja()
        {
            Table("ZIVOTINJE");

            Id(x => x.IdZivotinje).GeneratedBy.Sequence("ZIVOTINJE_SEQ");

            Map(x => x.BrojUha);
            Map(x => x.Vrsta);
            Map(x => x.Pol);
            Map(x => x.Rasa);
            Map(x => x.BrojJedinki);
            Map(x => x.DatumRodjenja);
            Map(x => x.DatumUlaska);
            Map(x => x.Tezina);
            Map(x => x.Status);
            Map(x => x.Komentar);

            // veza sa kategorijom
            References(x => x.Kategorija)
                .Column("USEVIZIVOTINJEID")
                .Nullable();
        }
    }
}