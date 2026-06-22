namespace ProdavnicaLibrary.DTOs;

public class SefujeView
{
    public int Id { get; set; }
    public DateTime? DatumPostavljenja { get; set; }
    public SefView? Upravnik { get; set; }
    public ProdavnicaView? Upravlja { get; set; }

    public SefujeView()
    {
    }

    internal SefujeView(Sefuje? s)
    {
        if (s != null)
        {
            Id = s.Id;
            DatumPostavljenja = s.DatumPostavljenja;
            Upravnik = new SefView(s.Upravnik);
            Upravlja = new ProdavnicaView(s.Upravlja);
        }
    }
}
