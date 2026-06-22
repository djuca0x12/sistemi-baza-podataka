namespace ProdavnicaLibrary.DTOs;

public class VojnikView : ProizvodView
{
    public string? NazivSerije { get; set; }
    public string? Baterije { get; set; }
    public string? Metal { get; set; }
    public string? Plastika { get; set; }

    public VojnikView()
    {
    }

    internal VojnikView(Vojnik? v) : base(v)
    {
        if (v != null)
        {
            NazivSerije = v.NazivSerije;
            Baterije = v.Baterije;
            Metal = v.Metal;
            Plastika = v.Plastika;
        }
    }
}
