namespace PoljoprivrednoGazdinstvoLibrary.Mapiranja
{
    public class VocnjaciMapiranja : SubclassMap<Vocnjaci>
    {
        public VocnjaciMapiranja()
        {
            // alternativa A: table-per-class
            Table("VOCNJACI");

            KeyColumn("IDUSEVI");

            Map(x => x.GodinaSadnje);
            Map(x => x.BrojStabala);
            Map(x => x.Sorta);
            Map(x => x.DatumRezidbe);
            Map(x => x.RodniCiklus);
        }
    }
}
