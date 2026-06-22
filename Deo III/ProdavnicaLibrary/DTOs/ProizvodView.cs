namespace ProdavnicaLibrary.DTOs;

public class ProizvodView
{
    public int BarKod { get; set; }
    public string? Tip { get; set; }
    public string? Naziv { get; set; }
    public string? Proizvodjac { get; set; }

    public IList<ProdajeSeView>? ProdajeSeOdeljenja { get; set; }

    public ProizvodView()
    {
    }

    internal ProizvodView(Proizvod? p)
    {
        if (p != null)
        {
            BarKod = p.BarKod;
            Tip = p.Tip;
            Naziv = p.Naziv;
            Proizvodjac = p.Proizvodjac;
        }
    }
}
