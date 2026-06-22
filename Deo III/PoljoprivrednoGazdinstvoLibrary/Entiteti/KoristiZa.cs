
namespace PoljoprivrednoGazdinstvoLibrary.Entiteti
{
    public class KoristiZa
    {
        public virtual Mehanizacija Mehanizacija { get; set; }
        public virtual Prinos Prinos { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; } // moze biti null kada se masina jos koristi

        // Predefinisano ponasanje metode, jer imamo kompozitni kljuc
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as KoristiZa;
            if (t == null) return false;

            if (Mehanizacija?.IdMehanizacija == t.Mehanizacija?.IdMehanizacija
                && Prinos?.IdPrinosa == t.Prinos?.IdPrinosa
                && DatumOd == t.DatumOd)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (Mehanizacija?.IdMehanizacija ?? 0) ^ (Prinos?.IdPrinosa ?? 0) ^ DatumOd.GetHashCode();
        }
    }
}
