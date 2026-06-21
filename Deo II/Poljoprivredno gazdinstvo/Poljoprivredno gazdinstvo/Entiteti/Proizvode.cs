using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Proizvode
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime DatumProizvodnje { get; set; }

        
        // Povezan je sa kategorijom i prinosom:
        public virtual UseviZivotinje Kategorija { get; set; }
        public virtual Prinos Prinos { get; set; }
    }
}
