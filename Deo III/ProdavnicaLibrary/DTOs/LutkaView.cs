namespace ProdavnicaLibrary.DTOs;

public class LutkaView : ProizvodView
{
    public string? Ime { get; set; }
    public string? Govori { get; set; }
    public string? OsetljivaDodir { get; set; }

    public LutkaView()
    {
    }

    internal LutkaView(Lutka? l) : base(l)
    {
        if (l != null)
        {
            Ime = l.Ime;
            Govori = l.Govori;
            OsetljivaDodir = l.OsetljivaDodir;
        }
    }
}
