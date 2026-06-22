using FluentNHibernate.Mapping;

namespace ProdavnicaLibrary.Mapiranja;

internal class ProdajeSeMapiranja : ClassMap<ProdajeSe>
{
    public ProdajeSeMapiranja()
    {
        //Mapiranje tabele
        Table("PRODAJE_SE");

        //mapiranje primarnog kljuca
        Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("PRODAVNICA.PRODAJESE_ID_SEQ");

        //mapiranje veza
        References(x => x.ProdajeProzivod).Column("BAR_KOD");
        References(x => x.ProdajeOdeljenje).Column("ID_ODELJENJE");
    }
}
