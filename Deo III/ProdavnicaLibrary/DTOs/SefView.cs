namespace ProdavnicaLibrary.DTOs;

public class SefView : RadnikView
{
    public IList<SefujeView>? SefujeProdavnice { get; set; }

    public SefView()
    {
        SefujeProdavnice = new List<SefujeView>();
    }

    internal SefView(Sef? s) : this()
    {
        if (s != null)
        {
            Jbr = s.Jbr;
            Mbr = s.Mbr;
            Ime = s.Ime;
            SrednjeSlovo = s.SrednjeSlovo;
            Prezime = s.Prezime;
            DatumRodjenja = s.DatumRodjenja;
            StrucnaSpema = s.StrucnaSprema;
            Sef = s.Sef;
        }
    }

    public override string ToString()
    {
        return Ime + " " + SrednjeSlovo + " " + Prezime;
    }
}
