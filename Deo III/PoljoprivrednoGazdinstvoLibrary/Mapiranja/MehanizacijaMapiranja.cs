using FluentNHibernate.Mapping;
using PoljoprivrednoGazdinstvoLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoljoprivrednoGazdinstvoLibrary.Mapiranja
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

            DiscriminateSubClassesOnColumn("TipMehanizacije");

            // Veza N:M:
            HasMany(x => x.KoriscenjeZaPrinose)
                .KeyColumns.Add("IDMEHANIZACIJA") // kolona u tabeli spoja
                .Cascade.All()
                .Inverse();
        }
    }

    public class TraktorMapiranja : SubclassMap<Traktor>
    {
        public TraktorMapiranja()
        {
            DiscriminatorValue("TRAKTOR");

            Map(x => x.Snaga, "SNAGA");
            Map(x => x.RadniSati, "RADNISATI");
            Map(x => x.BrojMotora, "BROJMOTORA");
        }
    }

    public class MasinaMapiranja : SubclassMap<Masina>
    {
        public MasinaMapiranja()
        {
            DiscriminatorValue("MASINA");

            // Specifično polje za mašinu
            Map(x => x.BrojTockova, "BROJTOCKOVA");
        }
    }
}


