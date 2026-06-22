namespace ProdavnicaLibrary.DTOs;

public class RadnikView
{
    public int Jbr { get; set; }
    public int Mbr { get; set; }
    public string? Ime { get; set; }
    public char? SrednjeSlovo { get; set; }
    public string? Prezime { get; set; }
    public DateTime? DatumRodjenja { get; set; }
    public string? StrucnaSpema { get; set; }
    public bool? Sef { get; set; }

    public IList<RadiUView>? RadiUProdavnice { get; set; }

    public RadnikView()
    {
        RadiUProdavnice = new List<RadiUView>();
    }

    internal RadnikView(Radnik? r) : this()
    {
        if (r != null)
        {
            Jbr = r.Jbr;
            Mbr = r.Mbr;
            Ime = r.Ime;
            SrednjeSlovo = r.SrednjeSlovo;
            Prezime = r.Prezime;
            DatumRodjenja = r.DatumRodjenja;
            StrucnaSpema = r.StrucnaSprema;
            Sef = r.Sef;
            //RadiUProdavnice = r.RadiUProdavnice.ToList().Select(p => new RadiUView(p)).ToList();
        }
    }

    public override string ToString()
    {
        return Ime + " " + SrednjeSlovo + " " + Prezime;
    }
}
