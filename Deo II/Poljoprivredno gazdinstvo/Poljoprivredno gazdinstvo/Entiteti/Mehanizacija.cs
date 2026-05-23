using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Mehanizacija
    {
        public virtual int IdMehanizacija { get; set; }
        public virtual string BrojSasije { get; set; }
        public virtual string Status { get; set; }
        public virtual string Komentar { get; set; }
        public virtual string Model { get; set; }
        public virtual DateTime DatumKupovine { get; set; }
        public virtual int? GodinaProizvodnje { get; set; }
        public virtual string TipMehanizacije { get; set; }

        // Podatak za masinu
        public virtual int? BrojTockova { get; set; }

        // Podaci za traktor
        public virtual double? Snaga { get; set; } 
        public virtual decimal? RadniSati { get; set; }
        public virtual string BrojMotora { get; set; } // string sam po sebi moze da bude null

        // Veza N:M:
        public virtual IList<KoristiZa> KoriscenjeZaPrinose { get; set; } = new List<KoristiZa>();
    }
}
