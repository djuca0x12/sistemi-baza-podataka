namespace ProdavnicaLibrary.Entiteti;

internal class ProdajeSe
{
    internal protected virtual int Id { get; set; }

    internal protected virtual Proizvod? ProdajeProzivod { get; set; }
    internal protected virtual Odeljenje? ProdajeOdeljenje { get; set; }
}
