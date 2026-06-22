namespace ProdavnicaLibrary.DTOs;

public class IgrackaPlastikaView : ProizvodView
{
    public int? Uzrast { get; set; }
    public string? Vodootporna { get; set; }
    public string? Lomljiva { get; set; }

    public IgrackaPlastikaView()
    {
    }

    internal IgrackaPlastikaView(IgrackaPlastika? i) : base(i)
    {
        if (i != null)
        {
            Uzrast = i.Uzrast;
            Vodootporna = i.Vodootporna;
            Lomljiva = i.Lomljiva;
        }
    }
}
