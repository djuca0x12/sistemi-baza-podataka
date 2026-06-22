using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class AutomobilMapiranja : SubclassMap<Automobil>
{
    public AutomobilMapiranja()
    {
        Table("AUTOMOBIL");

        KeyColumn("BAR_KOD");

        Map(x => x.NazivSerije).Column("NAZIV_SERIJE");
        Map(x => x.Baterije).Column("BATERIJE");
    }
}
