using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class OdeljenjeMapiranja : ClassMap<Odeljenje>
{
    public OdeljenjeMapiranja()
    {
        //Mapiranje tabele
        Table("ODELJENJE");

        //mapiranje podklasa
        DiscriminateSubClassesOnColumn("TIP");

        //mapiranje primarnog kljuca
        // Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity().UnsavedValue(-1);
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        //mapiranje svojstava
        //Map(x => x.Tip, "TIP");
        Map(x => x.Lokacija, "LOKACIJA");
        Map(x => x.BrojKasa, "BROJ_KASA");
        Map(x => x.InfoPult, "INFO_PULT");

        //mapiranje veze 1:N Prodavnica-Odeljenje
        References(x => x.PripadaProdavnici).Column("BROJP").LazyLoad();

        HasMany(x => x.ProdajeSeProizvod).KeyColumn("ID_ODELJENJE").LazyLoad().Cascade.All().Inverse();
    }
}

internal class OdeljenjeDo5Mapiranja : SubclassMap<OdeljenjeDo5>
{
    public OdeljenjeDo5Mapiranja()
    {
        DiscriminatorValue("DO5");
    }
}

internal class OdeljenjeOd6Do16Mapiranja : SubclassMap<OdeljenjeOd6Do16>
{
    public OdeljenjeOd6Do16Mapiranja()
    {
        DiscriminatorValue("OD6DO16");
    }
}

internal class OdeljenjeOdrasliMapiranja : SubclassMap<OdeljenjeOdrasli>
{
    public OdeljenjeOdrasliMapiranja()
    {
        DiscriminatorValue("ODRASLI");
    }
}
