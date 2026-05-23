using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poljoprivredno_gazdinstvo.Entiteti;

namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class UseviZivotinjeMapiranja : ClassMap<UseviZivotinje>
    {
        public UseviZivotinjeMapiranja()
        {
            Table("USEVI_ZIVOTNJE_KATEGORIJA");

            Id(x => x.UseviZivotinjeId, "USEVIZIVOTINJEID").GeneratedBy.TriggerIdentity();

            // Veza 1:N (slabi tip entiteta)
            HasMany(x => x.Subvencije).KeyColumn("USEVIZIVOTINJEID").Cascade.All().Inverse();
        }
    }
}
