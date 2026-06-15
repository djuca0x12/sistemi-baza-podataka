using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Kupac
    {
        public virtual int IdKupac { get; set; }
        public virtual string KupacIme { get; set; }
        public virtual Prodaja Prodaja { get; set; }
        public virtual Prinos Prinos { get; set; }
    }
}
