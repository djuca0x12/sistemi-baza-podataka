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

            CompositeId()
                .KeyProperty(x => x.KupacIme, "KUPAC") // PK
                .KeyReference(x => x.Prodaja, "IDPRODAJA") // PK + FK
                .KeyReference(x => x.Prinos, "IDPRINOSA"); // PK + FK
        }
    }
}
