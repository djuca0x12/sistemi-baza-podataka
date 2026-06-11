using System.Security.Cryptography;

namespace Poljoprivredno_gazdinstvo.Entiteti
{
    public class KrmnoBilje : Usevi
    {
        // totalna overlap: alternativa D
        // nasleđuje se pk roditeljske klase
        public virtual string VrstaKrme { get; set; }
        public virtual int BrojKosnjiGodisnje { get; set; }
        public virtual int ProcenatProteina { get; set; }
        public virtual int IshranaStokeFlag { get; set; }
        public virtual int ZaProdajuFlag { get; set; }

        public KrmnoBilje() { }
    }
}
