namespace ProdavnicaLibrary.DTOs;

public class AutomobilView : ProizvodView
{
    public string? NazivSerije { get; set; }
    public string? Baterije { get; set; }

    public AutomobilView()
    {
    }

    internal AutomobilView(Automobil? a) : base(a)
    {
        if (a != null)
        {
            NazivSerije = a.NazivSerije;
            Baterije = a.Baterije;
        }
    }
}
