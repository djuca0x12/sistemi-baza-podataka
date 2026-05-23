using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class Kupac
    {
        // Komponente složenog primarnog ključa
        public virtual string KupacIme { get; set; }
        public virtual Prodaja Prodaja { get; set; }
        public virtual Prinos Prinos { get; set; }

        // Predefinisano ponasanje metode, jer imamo kompozitni kljuc
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as Kupac;
            if (t == null) return false;

            if (KupacIme == t.KupacIme
                && Prodaja?.IdProdaja == t.Prodaja?.IdProdaja
                && Prinos?.IdPrinosa == t.Prinos?.IdPrinosa)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (KupacIme?.GetHashCode() ?? 0) ^ (Prodaja?.IdProdaja ?? 0) ^ (Prinos?.IdPrinosa ?? 0);
        }
    }
}
