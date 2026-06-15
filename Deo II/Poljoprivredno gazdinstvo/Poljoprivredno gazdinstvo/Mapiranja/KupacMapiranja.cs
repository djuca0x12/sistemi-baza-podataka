using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poljoprivredno_gazdinstvo.Entiteti;

namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class KupacMapiranja : ClassMap<Kupac>
    {
        public KupacMapiranja()
        {
            Table("KUPAC");

            // 1. Definišemo novi primarni ključ
            // 'GeneratedBy.Native()' govori Fluent-u da koristi triger/sekvencu iz baze
            Id(x => x.IdKupac, "IDKUPAC").GeneratedBy.TriggerIdentity();

            Map(x => x.KupacIme, "KUPAC");

            // Veze sa ostalim tabelama:
            References(x => x.Prodaja, "IDPRODAJA");
            References(x => x.Prinos, "IDPRINOSA");
        }
    }
}
