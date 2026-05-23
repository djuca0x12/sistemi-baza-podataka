using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Prodaja
    {
        public virtual int IdProdaja { get; set; }
        public virtual string BrojFakture { get; set; }
        public virtual string TipPlacanja { get; set; }
        public virtual string Komentar { get; set; }
        public virtual double CenaPoJedinici { get; set; }
        public virtual string JedinicaMere { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual double Kolicina { get; set; }

        // Veza 1:N:
        public virtual Prinos Prinos { get; set; }

        // Visevrednosni atribut:
        public virtual IList<Kupac> Kupci { get; set; } = new List<Kupac>();
    }
}
