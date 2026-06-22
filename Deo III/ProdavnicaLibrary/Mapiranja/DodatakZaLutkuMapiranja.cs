using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class DodatakZaLutkuMapiranja : SubclassMap<DodatakZaLutku>
{
    public DodatakZaLutkuMapiranja()
    {
        Table("DODATAK_ZA_LUTKE");

        KeyColumn("BAR_KOD");

        Map(x => x.NazivDodatka).Column("NAZIV");
        Map(x => x.TipDodatka).Column("TIP");
    }
}
