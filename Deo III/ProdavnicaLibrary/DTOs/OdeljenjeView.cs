namespace ProdavnicaLibrary.DTOs;

public class OdeljenjeView
{
    public int? OdeljenjeId { get; set; }
    public string? Lokacija { get; set; }
    public string? NazivProdavnice { get; set; }
    public string? RadnoVremeRadniDan { get; set; }
    public string? RadnoVremeSubota { get; set; }
    public string? RadnoVremeNedelja { get; set; }
    public ProdavnicaView? Prodavnica;
    public int? BrojProizvoda { get; set; }
    public int? BrojKasa { get; set; }
    public string? InfoPult { get; set; }
    public string? TipOdeljenja { get; set; }

    public OdeljenjeView()
    {
    }

    internal OdeljenjeView(Odeljenje? o)
    {
        if (o != null)
        {
            OdeljenjeId = o.Id;
            Lokacija = o.Lokacija;
            NazivProdavnice = o.PripadaProdavnici?.Naziv;
            RadnoVremeRadniDan = o.PripadaProdavnici?.RadniDan;
            RadnoVremeSubota = o.PripadaProdavnici?.Subota;
            RadnoVremeNedelja = o.PripadaProdavnici?.Nedelja;
            BrojProizvoda = o.ProdajeSeProizvod?.Count;
            BrojKasa = o.BrojKasa;
            InfoPult = o.InfoPult;
            TipOdeljenja = o.GetType().Name;
        }
    }

    internal OdeljenjeView(Odeljenje? o, Prodavnica? p) : this(o)
    {
        Prodavnica = new ProdavnicaView(p);
    }
}
