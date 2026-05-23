using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Poljoprivredno_gazdinstvo.Entiteti;

namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class ProdajaMapiranja : ClassMap<Prodaja>
    {
        public ProdajaMapiranja()
        {
            Table("PRODAJA");

            Id(x => x.IdProdaja, "IDPRODAJA").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojFakture, "BROJFAKTURE").Unique();
            Map(x => x.TipPlacanja, "TIPPLACANJA");
            Map(x => x.Komentar, "KOMENTAR");
            Map(x => x.CenaPoJedinici, "CENAPOJEDINICI");
            Map(x => x.JedinicaMere, "JEDINICAMERE");
            Map(x => x.Datum, "DATUM");
            Map(x => x.Kolicina, "KOLICINA");

            // Veza 1:N (slabi tip entieta)
            References(x => x.Prinos, "IDPRINOSA");

            // Visevrednosni atribut:
            HasMany(x => x.Kupci).KeyColumn("IDPRODAJA").Cascade.All().Inverse();
        }
    }
}
