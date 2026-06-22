using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class IgrackaPlastikaMapiranja : SubclassMap<IgrackaPlastika>
{
    public IgrackaPlastikaMapiranja()
    {
        Table("IGRACKE_PLASTIKA");

        KeyColumn("BAR_KOD");

        Map(x => x.Uzrast).Column("UZRAST");
        Map(x => x.Vodootporna).Column("VODOOTPORNA");
        Map(x => x.Lomljiva).Column("LOMLJIVA");
    }
}
