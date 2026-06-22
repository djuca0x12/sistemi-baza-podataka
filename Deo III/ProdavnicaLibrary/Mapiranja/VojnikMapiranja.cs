using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class VojnikMapiranja : SubclassMap<Vojnik>
{
    public VojnikMapiranja()
    {
        Table("VOJNIK");

        KeyColumn("BAR_KOD");

        Map(x => x.NazivSerije).Column("NAZIV_SERIJE");
        Map(x => x.Baterije).Column("BATERIJE");
        Map(x => x.Metal).Column("METAL_FLAG");
        Map(x => x.Plastika).Column("PLASTIKA_FLAG");
    }
}
