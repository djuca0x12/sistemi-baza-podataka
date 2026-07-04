using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoljoprivrednoGazdinstvoLibrary.Mapiranja
{
    internal class ProizvodeMapiranja : ClassMap<Proizvode>
    {
        public ProizvodeMapiranja()
        {
            Table("PROIZVODE");

            Id(x => x.Id).Column("PROIZVODEID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumProizvodnje, "DATUMPROIZVODNJE");

            References(x => x.Kategorija, "UseviZivotinjeId");
            References(x => x.Prinos, "IdPrinosa");
        }
    }
}
