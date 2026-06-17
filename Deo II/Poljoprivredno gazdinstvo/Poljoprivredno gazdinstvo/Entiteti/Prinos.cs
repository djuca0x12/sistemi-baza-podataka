using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Prinos
    {
        public virtual int IdPrinosa { get; set; }
        public virtual string Tip { get; set; }
        public virtual double Kolicina { get; set; } 
        public virtual string Komentar { get; set; }
        public virtual string KvalitetProizvoda { get; set; }
        public virtual string JedinicaMere { get; set; }

        // Veza 1:N (slabi tip entieta):
        public virtual IList<Prodaja> Prodaje { get; set; } = new List<Prodaja>();

        //Veza N:M:
        public virtual IList<KoristiZa> KorisceneMasine { get; set; } = new List<KoristiZa>();
    }
}
