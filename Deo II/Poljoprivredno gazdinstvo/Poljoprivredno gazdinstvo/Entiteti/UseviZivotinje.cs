using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class UseviZivotinje
    {
        public virtual int UseviZivotinjeId { get; set; }

        // Veza 1:N (slabi tip entiteta)
        public virtual IList<Subvencija> Subvencije { get; set; }
    }
}
