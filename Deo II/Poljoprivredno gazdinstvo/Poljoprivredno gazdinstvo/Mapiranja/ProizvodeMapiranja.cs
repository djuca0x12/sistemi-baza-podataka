using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    internal class ProizvodeMapiranja : ClassMap<Proizvode>
    {
        public ProizvodeMapiranja()
        {
            Table("PROIZVODE");

            Id(x => x.Id).Column("PROIZVODEID").GeneratedBy.TriggerIdentity();

            // Trebalo bi da references popunjava ove podatke!?
            //Map(x => x.UseviZivotinjeId, "USEVIZIVOTINJEID");
            //Map(x => x.IdPrinosa, "IDPRINOSA");
            Map(x => x.DatumProizvodnje, "DATUMPROIZVODNJE");


            References(x => x.Kategorija, "UseviZivotinjeId");
            References(x => x.Prinos, "IdPrinosa");
        }
    }
}
