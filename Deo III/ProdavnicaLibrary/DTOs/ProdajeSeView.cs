namespace ProdavnicaLibrary.DTOs;

public class ProdajeSeView
{
    public int Id { get; set; }
    public ProizvodView? ProdajeProzivod { get; set; }
    public OdeljenjeView? ProdajeOdeljenje { get; set; }

    public ProdajeSeView()
    {
    }

    internal ProdajeSeView(ProdajeSe? p)
    {
        if (p != null)
        {
            Id = p.Id;
            ProdajeProzivod = new ProizvodView(p.ProdajeProzivod);
            ProdajeOdeljenje = new OdeljenjeView(p.ProdajeOdeljenje);
        }
    }
}
