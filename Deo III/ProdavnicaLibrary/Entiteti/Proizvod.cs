namespace ProdavnicaLibrary.Entiteti;

internal class Proizvod
{
    internal protected virtual int BarKod { get; set; }
    internal protected virtual string? Tip { get; set; }
    internal protected virtual string? Naziv { get; set; }
    internal protected virtual string? Proizvodjac { get; set; }

    internal protected virtual IList<ProdajeSe>? ProdajeSeOdeljenja { get; set; }

    internal Proizvod()
    {
        ProdajeSeOdeljenja = new List<ProdajeSe>();
    }
}
