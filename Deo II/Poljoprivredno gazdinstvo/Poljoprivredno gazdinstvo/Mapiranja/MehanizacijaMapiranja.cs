using FluentNHibernate.Mapping;
using Poljoprivredno_gazdinstvo.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Mapiranja
{
    public class MehanizacijaMapiranja : ClassMap<Mehanizacija>
    {
        public MehanizacijaMapiranja() 
        {
            Table("MEHANIZACIJA");

            Id(x => x.IdMehanizacija, "IDMEHANIZACIJA").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojSasije, "BROJSASIJE");
            Map(x => x.Status, "STATUS");
            Map(x => x.Komentar, "KOMENTAR");
            Map(x => x.Model, "MODEL");
            Map(x => x.DatumKupovine, "DATUMKUPOVINE");
            Map(x => x.GodinaProizvodnje, "GODINAPROIZVODNJE");
            Map(x => x.TipMehanizacije, "TIPMEHANIZACIJE");
            Map(x => x.Snaga, "SNAGA");
            Map(x => x.RadniSati, "RADNISATI");
            Map(x => x.BrojMotora, "BROJMOTORA");
            Map(x => x.BrojTockova, "BROJTOCKOVA");

            // Veza N:M:
            HasMany(x => x.KoriscenjeZaPrinose)
                .KeyColumns.Add("IDMEHANIZACIJA") // kolona u tabeli spoja
                .Cascade.All()
                .Inverse();
        }
    }
}
