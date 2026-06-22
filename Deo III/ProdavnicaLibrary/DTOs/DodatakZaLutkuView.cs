namespace ProdavnicaLibrary.DTOs;

public class DodatakZaLutkuView : ProizvodView
{
    public string? NazivDodatka { get; set; }
    public string? TipDodatka { get; set; }

    public DodatakZaLutkuView()
    {
    }

    internal DodatakZaLutkuView(DodatakZaLutku? dzl) : base(dzl)
    {
        if (dzl != null)
        {
            NazivDodatka = dzl.NazivDodatka;
            TipDodatka = dzl.TipDodatka;
        }
    }
}
