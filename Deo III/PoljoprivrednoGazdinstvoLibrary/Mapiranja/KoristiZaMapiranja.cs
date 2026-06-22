using FluentNHibernate.Mapping;
using PoljoprivrednoGazdinstvoLibrary.Entiteti;

namespace PoljoprivrednoGazdinstvoLibrary.Mapiranja
{
    public class KoristiZaMapiranja : ClassMap<KoristiZa>
    {
        public KoristiZaMapiranja()
        {
            Table("KORISTI_ZA");

            // Kompozitni kljuc
            CompositeId()
                .KeyReference(x => x.Mehanizacija, "IDMEHANIZACIJA") // PK + Referenca
                .KeyReference(x => x.Prinos, "IDPRINOSA") // PK + Referenca
                .KeyProperty(x => x.DatumOd, "DATUMOD"); // PK

            Map(x => x.DatumDo, "DATUMDO");
        }
    }
}
