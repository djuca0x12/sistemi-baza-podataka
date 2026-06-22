using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class SefujeMapiranja : ClassMap<Sefuje>
{
    public SefujeMapiranja()
    {
        //Mapiranje tabele
        Table("SEFUJE");

        //mapiranje primarnog kljuca
        Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("PRODAVNICA.SEFUJE_ID_SEQ");

        //mapiranje svojstava.
        Map(x => x.DatumPostavljenja, "DATUM_POSTAVLJENJA");

        //mapiranje veza
        References(x => x.Upravnik).Column("JBR_RADNIK");
        References(x => x.Upravlja).Column("BROJP");
    }
}
