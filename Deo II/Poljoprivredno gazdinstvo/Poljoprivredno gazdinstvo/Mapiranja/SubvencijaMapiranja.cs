using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poljoprivredno_gazdinstvo.Entiteti;

namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class SubvencijaMapiranja : ClassMap<Subvencija>
    {
        public SubvencijaMapiranja()
        {
            Table("SUBVENCIJA");

            Id(x => x.IdSubvencija, "IDSUBVENCIJA").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojResenja, "BROJRESENJA");
            Map(x => x.Vrsta, "VRSTA");
            Map(x => x.Iznos, "IZNOS");
            Map(x => x.Valuta, "VALUTA");
            Map(x => x.DatumPodnosenja, "DATUMPODNOSENJA");
            Map(x => x.DatumOdobrenja, "DATUMODOBRENJA");
            Map(x => x.Status, "STATUS");
            Map(x => x.Komentar, "KOMENTAR");

            // Veza 1:N (slabi tip entiteta)
            References(x => x.Kategorija, "USEVIZIVOTINJEID");
        }

    }
}
