using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class RadiUMapiranja : ClassMap<RadiU>
{
    public RadiUMapiranja()
    {
        Table("RADI_U");

        CompositeId(x => x.Id)
            .KeyReference(x => x!.RadnikRadiU, "JBR_RADNIK")
            .KeyReference(x => x!.RadiUProdavnica, "BROJP");

        Map(x => x.DatumOd).Column("DATUM_OD");
        Map(x => x.DatumDo).Column("DATUM_DO");
    }
}
