using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoljoprivrednoGazdinstvoLibrary.Entiteti;

namespace PoljoprivrednoGazdinstvoLibrary.Mapiranja
{
    public class UseviZivotinjeMapiranja : ClassMap<UseviZivotinje>
    {
        public UseviZivotinjeMapiranja()
        {
            Table("USEVI_ZIVOTNJE_KATEGORIJA");

            Id(x => x.UseviZivotinjeId, "USEVIZIVOTINJEID").GeneratedBy.TriggerIdentity();

            Map(x => x.KategorijaTip, "KATEGORIJATIP");

            // Veza 1:N (slabi tip entiteta)
            HasMany(x => x.Subvencije).KeyColumn("USEVIZIVOTINJEID").Cascade.All().Inverse();

            // Veza prema Proizvode
            HasMany(x => x.Proizvodi).KeyColumn("USEVIZIVOTINJEID").Inverse().Cascade.All();
        }
    }
}
