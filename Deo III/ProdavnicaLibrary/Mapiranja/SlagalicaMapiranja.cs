using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class SlagalicaMapiranja : SubclassMap<Slagalica>
{
    public SlagalicaMapiranja()
    {
        Table("PUZZLE");

        KeyColumn("BAR_KOD");

        Map(x => x.BrojDelova).Column("BROJ_DELOVA");
        Map(x => x.Turisticka).Column("TURISTICKA");
        Map(x => x.Umetnicka).Column("UMETNICKA");
        Map(x => x.Ilustracija).Column("ILUSTRACIJA");
    }
}
