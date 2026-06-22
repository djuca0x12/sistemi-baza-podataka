namespace ProdavnicaLibrary.Entiteti;

internal class Vojnik : Proizvod
{
    internal protected virtual string? NazivSerije { get; set; }
    internal protected virtual string? Baterije { get; set; }
    internal protected virtual string? Metal { get; set; }
    internal protected virtual string? Plastika { get; set; }
}
