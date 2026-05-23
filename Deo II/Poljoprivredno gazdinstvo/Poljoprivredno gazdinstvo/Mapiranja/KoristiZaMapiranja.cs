using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.Cfg.XmlHbmBinding;
using Poljoprivredno_gazdinstvo.Entiteti;

namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class KoristiZaMapiranja : ClassMap<KoristiZa>
    {
        public KoristiZaMapiranja()
        {
            Table("KORISTI_ZA");

            // Kompozitni kljuc
            CompositeId()
                .KeyReference(x => x.Mehanizacija, "IDMEHANIZACIJA") // PK + Referenca
                .KeyReference(x => x.Prinos, "IDPRINOSA") // PK + Referenca
                .KeyProperty(x => x.DatumOd, "DATUMOD"); // PK

            Map(x => x.DatumDo, "DATUMDO");
        }
    }
}
