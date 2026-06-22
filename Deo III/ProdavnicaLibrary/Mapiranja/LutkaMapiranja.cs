using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class LutkaMapiranja : SubclassMap<Lutka>
{
    public LutkaMapiranja()
    {
        Table("LUTKA");

        KeyColumn("BAR_KOD");

        Map(x => x.Ime).Column("IME");
        Map(x => x.Govori).Column("GOVORI");
        Map(x => x.OsetljivaDodir).Column("OSETLJIVA_DODIR");
    }
}
