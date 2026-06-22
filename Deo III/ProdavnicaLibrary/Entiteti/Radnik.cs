namespace ProdavnicaLibrary.Entiteti;

internal class Radnik
{
    internal protected virtual int Jbr { get; set; }
    internal protected virtual int Mbr { get; set; }
    internal protected virtual string? Ime { get; set; }
    internal protected virtual char? SrednjeSlovo { get; set; }
    internal protected virtual string? Prezime { get; set; }
    internal protected virtual DateTime? DatumRodjenja { get; set; }
    internal protected virtual string? StrucnaSprema { get; set; }
    internal protected virtual bool? Sef { get; set; }

    internal protected virtual IList<Prodavnica>? Prodavnice { get; set; }
    internal protected virtual IList<RadiU>? RadiUProdavnice { get; set; }

    internal Radnik()
    {

        Prodavnice = new List<Prodavnica>();
        RadiUProdavnice = new List<RadiU>();
    }
}

internal class Sef : Radnik
{
    internal protected virtual IList<Sefuje>? SefujeProdavnice { get; set; }

    internal Sef()
    {
        SefujeProdavnice = new List<Sefuje>();
    }
}
