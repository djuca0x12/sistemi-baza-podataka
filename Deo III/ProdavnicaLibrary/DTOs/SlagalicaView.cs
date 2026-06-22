namespace ProdavnicaLibrary.DTOs;

public class SlagalicaView : ProizvodView
{
    public int BrojDelova { get; set; }
    public string? Turisticka { get; set; }
    public string? Umetnicka { get; set; }
    public string? Ilustracija { get; set; }

    public SlagalicaView()
    {
    }

    internal SlagalicaView(Slagalica? s) : base(s)
    {
        if (s != null)
        {
            BrojDelova = s.BrojDelova;
            Turisticka = s.Turisticka;
            Umetnicka = s.Umetnicka;
            Ilustracija = s.Ilustracija;
        }
    }
}
