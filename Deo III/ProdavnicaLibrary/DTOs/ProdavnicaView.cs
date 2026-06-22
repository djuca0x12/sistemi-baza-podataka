namespace ProdavnicaLibrary.DTOs;

public class ProdavnicaView
{
    public int Id { get; set; }
    public string? Naziv { get; set; }
    public string? Adresa { get; set; }
    public string? BrojTelefona { get; set; }
    public string? RadniDan { get; set; }
    public string? Subota { get; set; }
    public string? Nedelja { get; set; }

    public virtual IList<OdeljenjeView>? Odeljenja { get; set; }
    public virtual IList<RadnikView>? Radnici { get; set; }
    public virtual IList<SefujeView>? SefujeSefovi { get; set; }

    public ProdavnicaView()
    {
        Odeljenja = new List<OdeljenjeView>();
        Radnici = new List<RadnikView>();
        SefujeSefovi = new List<SefujeView>();
    }

    internal ProdavnicaView(Prodavnica? p) : this()
    {
        if (p != null)
        {
            Id = p.Id;
            Naziv = p.Naziv;
            Adresa = p.Adresa;
            BrojTelefona = p.BrojTelefona;
            RadniDan = p.RadniDan;
            Subota = p.Subota;
            Nedelja = p.Nedelja;
        }
    }
}
