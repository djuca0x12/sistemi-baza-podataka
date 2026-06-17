using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poljoprivredno_gazdinstvo.Entiteti;

namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class PrinosMapiranja : ClassMap<Prinos>
    {
        public PrinosMapiranja()
        {
            Table("PRINOS");

            Id(x => x.IdPrinosa, "IDPRINOSA").GeneratedBy.TriggerIdentity();

            Map(x => x.Tip, "TIP");
            Map(x => x.Kolicina, "KOLICINA");
            Map(x => x.Komentar, "KOMENTAR");
            Map(x => x.KvalitetProizvoda, "KVALITETPROIZVODA");
            Map(x => x.JedinicaMere, "JEDINICAMERE");

            // Veza 1:N (slabi tip entiteta):
            HasMany(x => x.Prodaje).KeyColumn("IDPRINOSA").Cascade.All().Inverse();
            // Cascade.All - sve akcije nad roditeljem se prenose na decu
            // Inverse - najpre se snima objekat roditelja, pa onda dece

            // Veza N:M:
            HasMany(x => x.KorisceneMasine)
                .KeyColumns.Add("IDPRINOSA") // kolona u tabeli spoja
                .Cascade.All()
                .Inverse();
        }
    }
}
