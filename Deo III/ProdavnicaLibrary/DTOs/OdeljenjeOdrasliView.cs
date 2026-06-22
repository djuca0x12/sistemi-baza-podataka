namespace ProdavnicaLibrary.DTOs;

public class OdeljenjeOdrasliView : OdeljenjeView
{
    public OdeljenjeOdrasliView()
    {
    }

    internal OdeljenjeOdrasliView(Odeljenje? o) : base(o)
    {
    }

    internal OdeljenjeOdrasliView(Odeljenje? o, Prodavnica? p) : base(o, p)
    {
    }
}
