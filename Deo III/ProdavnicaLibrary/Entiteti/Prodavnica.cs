namespace ProdavnicaLibrary.Entiteti;

internal class Prodavnica
{
    internal protected virtual int Id { get; set; }
    internal protected virtual string? Naziv { get; set; }
    internal protected virtual string? Adresa { get; set; }
    internal protected virtual string? BrojTelefona { get; set; }
    internal protected virtual string? RadniDan { get; set; }
    internal protected virtual string? Subota { get; set; }
    internal protected virtual string? Nedelja { get; set; }
    internal protected virtual IList<Odeljenje>? Odeljenja { get; set; }
    internal protected virtual IList<Radnik>? Radnici { get; set; }
    internal protected virtual IList<RadiU>? RadiURadnici { get; set; }
    internal protected virtual IList<Sefuje>? SefujeSefovi { get; set; }

    internal Prodavnica()
    {
        Odeljenja = new List<Odeljenje>();
        Radnici = new List<Radnik>();
        RadiURadnici = new List<RadiU>();
        SefujeSefovi = new List<Sefuje>();
    }
}
